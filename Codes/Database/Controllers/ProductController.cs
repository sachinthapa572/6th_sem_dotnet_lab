using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using MySqlAdoNetCrude.Models;

namespace MySqlAdoNetCrude.Controllers
{
    public class ProductController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public ProductController(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection") ??
                throw new InvalidOperationException("Connection string 'DefaultConnection' is not configured.");
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<ProductModel> productsList = new List<ProductModel>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Products";
                    using var command = new MySqlCommand(query, conn);
                    using MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        productsList.Add(new ProductModel
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Price = reader.GetDecimal("Price"),
                            Quantity = reader.GetInt32("Quantity")
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                ViewData["Result"] = $"Error: {ex.Message}";
            }

            return View(productsList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(_connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO Products (Name, Price, Quantity) VALUES (@Name, @Price, @Quantity)";
                        using var command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@Name", product.Name);
                        command.Parameters.AddWithValue("@Price", product.Price);
                        command.Parameters.AddWithValue("@Quantity", product.Quantity);
                        command.ExecuteNonQuery();
                    }

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    // Log the exception
                    ModelState.AddModelError("", $"Error: {ex.Message}");
                }
            }

            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ProductModel product = new ProductModel();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Products WHERE Id=@Id";
                    using var command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Id", id);
                    using MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        product.Id = reader.GetInt32("Id");
                        product.Name = reader.GetString("Name");
                        product.Price = reader.GetDecimal("Price");
                        product.Quantity = reader.GetInt32("Quantity");
                    }
                    else
                    {
                        return NotFound();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                ViewData["Result"] = $"Error: {ex.Message}";
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(_connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE Products SET Name=@Name, Price=@Price, Quantity=@Quantity WHERE Id=@Id";
                        using var command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@Id", product.Id);
                        command.Parameters.AddWithValue("@Name", product.Name);
                        command.Parameters.AddWithValue("@Price", product.Price);
                        command.Parameters.AddWithValue("@Quantity", product.Quantity);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            return NotFound();
                        }
                    }

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    // Log the exception
                    ModelState.AddModelError("", $"Error: {ex.Message}");
                }
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Products WHERE Id=@Id";
                    using var command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Id", id);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        ViewData["Result"] = "Product not found or already deleted.";
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                ViewData["Result"] = $"Error: {ex.Message}";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}