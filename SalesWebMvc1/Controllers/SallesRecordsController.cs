﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc1.Services;

namespace SalesWebMvc1.Controllers
{
    public class SallesRecordsController : Controller
    {
        private readonly SallesRecordService _sallesRecordService;

        public SallesRecordsController(SallesRecordService sallesRecordService)
        {
            _sallesRecordService = sallesRecordService;
        }

        public IActionResult Index()
        {
            return View();
        }
            
        public async Task<IActionResult> SimpleSearch(DateTime? minDate,DateTime? maxDate)
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

            var result = await _sallesRecordService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        public IActionResult GroupSearch()
        {
            return View();
        }
    }
}
