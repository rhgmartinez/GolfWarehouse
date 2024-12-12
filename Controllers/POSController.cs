using Golf_Warehouse_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Golf_Warehouse_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class POSController : ControllerBase
    {
        private readonly GolfWarehouseContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public POSController(GolfWarehouseContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> CreateCustomerTransaction(Customer c, List<Item> i)
        {
            var customer = await _context.Customers.FindAsync(c.CustomerNumber);
            if (customer == null)
            {
                return NotFound("Customer not found");
            }
            await _unitOfWork.BeginTransactionAsync();

            try
            {

                var t_customer = new Customer
                {
                    CustomerNumber = c.CustomerNumber,
                    Name = customer.Name,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    StoreId = "",
                    NumberOfTransactions = 1
                };

                _context.Customers.Add(t_customer);
                await _context.SaveChangesAsync();

                foreach (var item in i)
                {
                    var product = await _context.Items.FindAsync(item);
                    if (product == null)
                    {
                        return NotFound("Item/Product not found");
                    }

                    var transactionItem = new Item
                    {
                        ItemNo = item.ItemNo,
                        QuantityDecimals = item.QuantityDecimals,
                        Price1 = item.Price1
                    };

                    _context.Items.Add(transactionItem);
                }

                await _context.SaveChangesAsync();
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitTransactionAsync();

            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackTransactionAsync();
                throw;
            }

            return CreatedAtAction(nameof(CreateCustomerTransaction), new { id = c.CustomerNumber }, customer);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetTransaction(int id)
        {
            var posHeader = await _context.POSHeaders.FindAsync(id);
            if (posHeader == null)
            {
                return NotFound();
            }

            // Optionally, return the details of the transaction
            return Ok(posHeader);
        }
    }
}
