using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Services;
using SalesWebMVC.Models;
using SalesWebMVC.Models.ViewModels;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService _salesRecordService;
        private readonly SellerService _sellerService;

        public SalesRecordsController(SalesRecordService salesRecordService, SellerService sellerService)
        {
            _salesRecordService = salesRecordService;
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] =maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _salesRecordService.FindByDateAsync(minDate, maxDate);

            return View(result);
        }
        public async Task<IActionResult> GroupingSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _salesRecordService.FindByDateGroupingAsync(minDate, maxDate);

            return View(result);
        }

        //TESTE
        public async Task<IActionResult> Register()
        {
            var sellers = await _sellerService.FindAllAsync();
            var status = new List<SaleStatus> { SaleStatus.Pending, SaleStatus.Billed, SaleStatus.Canceled } ;
            var viewModel = new SaleFormViewModel { Sellers = sellers, Status = status };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(SalesRecord sale)
        {
            if (!ModelState.IsValid)
            {
                var sellers = await _sellerService.FindAllAsync();
                var status = new List<SaleStatus> { SaleStatus.Pending, SaleStatus.Billed, SaleStatus.Canceled };
                var viewModel = new SaleFormViewModel { Sellers = sellers, Status = status };

                return View(viewModel);
            }

            await _salesRecordService.InsertAsync(sale);
            return RedirectToAction(nameof(Index));
        }
    }
}
