using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Sales
{
    public  interface IOrderService
    {
        Task<int> ChechOut(CheckoutRequest request);
    }
}
