﻿using CinemaGo.DataModels.CustomModels;
using CinemaGo.Logic.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaGo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IWebHostEnvironment env;
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService, IWebHostEnvironment _env) 
        {
            this._adminService = adminService;
            this.env = _env;
        }

        [HttpPost]
        [Route("AdminLogin")]

        public IActionResult AdminLogin(LoginModel loginModel) 
        {
            var data = _adminService.AdminLogin(loginModel);
            return Ok(data);
        }

        

        [HttpPost]
        [Route("SaveCinema")]

        public IActionResult SaveCinema(CinemaModel newCinema)
        {
            var data = _adminService.SaveCinema(newCinema);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetCinemas")]

        public IActionResult GetCinemas()
        {
            var data = _adminService.GetCinemas();
            return Ok(data);
        }

        [HttpPost]
        [Route("UpdateCinema")]

        public IActionResult UpdateCinema(CinemaModel cinemaToUpdate)
        {
            var data = _adminService.UpdateCinema(cinemaToUpdate);
            return Ok(data);
        }

        [HttpPost]
        [Route("DeleteCinema")]

        public IActionResult DeleteCinema(CinemaModel cinemaToDelete)
        {
            var data = _adminService.DeleteCinema(cinemaToDelete);
            return Ok(data);
        }

        [HttpPost]
        [Route("SaveCategory")]

        public IActionResult SaveCategory(CategoryModel newCategory)
        {
            var data = _adminService.SaveCategory(newCategory);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetCategories")]

        public IActionResult GetCategories()
        {
            var data = _adminService.GetCategories();
            return Ok(data);
        }

        [HttpPost]
        [Route("UpdateCategory")]

        public IActionResult UpdateCategory(CategoryModel categoryToUpdate)
        {
            var data = _adminService.UpdateCategory(categoryToUpdate);
            return Ok(data);
        }

        [HttpPost]
        [Route("DeleteCategory")]

        public IActionResult DeleteCategory(CategoryModel categoryToDelete)
        {
            var data = _adminService.DeleteCategory(categoryToDelete);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetProducts")]

        public IActionResult GetProducts()
        {
            var data = _adminService.GetProducts();
            return Ok(data);
        }

        [HttpPost]
        [Route("SaveProduct")]

        public IActionResult SaveProduct(ProductModel newProduct)
        {
            int nextProductId = _adminService.GetNewProductId();
            newProduct.ImageUrl = @"Images/" + nextProductId + ".png";
            var path = $"{env.WebRootPath}\\Images\\{nextProductId + ".png"}";
            var fs = System.IO.File.Create(path);
            fs.Write(newProduct.FileContent, 0, newProduct.FileContent.Length);
            fs.Close();
            string uploadsFolder = Path.Combine(env.WebRootPath, "Images");
            var data = _adminService.SaveProduct(newProduct);
            return Ok(data);
        }

        [HttpPost]
        [Route("DeleteProduct")]

        public IActionResult DeleteProduct(ProductModel productToDelete)
        {
            var data = _adminService.DeleteProduct(productToDelete);
            return Ok(data);
        }

        [HttpPost]
        [Route("UpdateProduct")]

        public IActionResult UpdateProduct(ProductModel productToUpdate)
        {
            var data = _adminService.UpdateProduct(productToUpdate);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetProductStock")]

        public IActionResult GetProductStock()
        {
            var data = _adminService.GetProductStock();
            return Ok(data);
        }

        [HttpPost]
        [Route("UpdateProductStock")]

        public IActionResult UpdateProductStock(StockModel stock)
        {
            var data = _adminService.UpdateProductStock(stock);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetContacts")]

        public IActionResult GetContacts()
        {
            var data = _adminService.GetContacts();
            return Ok(data);
        }


        [HttpPost]
        [Route("DeleteContact")]

        public IActionResult DeleteContact(ContactModel contactToDelete)
        {
            var data = _adminService.DeleteContact(contactToDelete);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetOrderDetails")]

        public IActionResult GetOrderDetails()
        {
            var data = _adminService.GetOrderDetails();
            return Ok(data);
        }


        [HttpPost]
        [Route("DeleteOrderDetail")]

        public IActionResult DeleteOrderDetail(OrderDetailModel orderdetailToDelete)
        {
            var data = _adminService.DeleteOrderDetail(orderdetailToDelete);
            return Ok(data);
        }

    }
}
