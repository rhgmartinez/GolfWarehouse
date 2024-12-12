using System.Transactions;
using Golf_Warehouse_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface ITransactionRepository
{
    Task<Customer> CreateTransaction(TransactionRequest request);
}

public class TransactionRepository : ITransactionRepository
{
    private readonly GolfWarehouseContext _context;

    public TransactionRepository(GolfWarehouseContext context)
    {
        _context = context;
    }

    public async Task<Customer> CreateTransaction(TransactionRequest request)
    {
        var customer = await _context.Customers.FindAsync(request);
        if (customer == null)
        {
            throw new NotFoundException("Customer not found");
        }

        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                var transactionEntity = new Customer
                {
                    CustomerNumber = customer.CustomerNumber,
                    Name = customer.Name,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    StoreId = "",
                    NumberOfTransactions = 1
                };

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

                await transaction.CommitAsync();

                return transactionEntity;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }

    Task<Customer> ITransactionRepository.CreateTransaction(TransactionRequest request)
    {
        throw new NotImplementedException();
    }
}