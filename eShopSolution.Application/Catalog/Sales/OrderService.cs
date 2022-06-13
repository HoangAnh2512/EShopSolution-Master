using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using eShopSolution.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Sales
{
    public class OrderService : IOrderService
    {
        private readonly EShopDbContext _context;
        public OrderService(EShopDbContext context)
        {
            _context = context;
           
        }

        public Task<int> ChechOut(CheckoutRequest request)
        {
            var orderdetail = _context.OrderDetails;
            var ListOrDetail = new List<OrderDetail>();
            foreach (var item in request.OrderDetails)
            {
                ListOrDetail.Add(new OrderDetail
                {
                     
                });
            }
          
           
            var order = new Order()
            {
                OrderDate  = DateTime.Now,
                ShipName = request.Name,
                ShipAddress = request.Address,
                ShipEmail = request.Email,
                ShipPhoneNumber = request.PhoneNumber,
                Status = OrderStatus.InProgress,
                OrderDetails = request.OrderDetails
                
            };
        }
    }
}
