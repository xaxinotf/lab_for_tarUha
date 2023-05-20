﻿using DeBiLaba2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DeBiLaba2.Controllers
{
    public class Sql_queriesController : Controller
    {

        const string secuelconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LabaDb2;Integrated Security=True";
        const string path = @"C:\Users\Богдан\Desktop\DeBiLaba2\DeBiLaba2\Queries";
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Q1(Zaput model)
        {
            model.ides = new List<int>();
            model.ProductsInOrders = new List<int>();
            model.queryId = 1;
            string sqlFilePath = Path.Combine(path, "Q1.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            using (var conn = new SqlConnection(secuelconnection))
            {
                conn.Open();
                using (var com = new SqlCommand(sqlQuery, conn))
                {
                    using (var reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            model.ides.Add(reader.GetInt32(0));
                            model.ProductsInOrders.Add(reader.GetInt32(1));
                        }
                    }
                }
            }
            return View("Vivo", model);
        }

        [HttpPost]
        public IActionResult Q2(Zaput model)
        {
            if (model.UserrrId == 0)
            {
                TempData["Error1"] = $"Блін, пліз, введіть id користувача!";
                return RedirectToAction("Index", "Sql_queries");
            }
            int UserId = model.UserrrId;
            model.Names = new List<string>();
            model.TerminPrudatn = new List<string>();
            model.Dozirovka = new List<string>();
            model.queryId = 2;
            string sqlFilePath = Path.Combine(path, "Q2.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            sqlQuery = sqlQuery.Replace("@Id", UserId.ToString());

            using (var conn = new SqlConnection(secuelconnection))
            {
                conn.Open();
                using (var com = new SqlCommand(sqlQuery, conn))
                {
                    using (var reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            model.Names.Add(reader.GetString(0));
                            model.Dozirovka.Add(reader.GetString(1));
                            model.TerminPrudatn.Add(reader.GetString(2));
                        }
                    }
                }
            }
            return View("Vivo", model);
        }
        public IActionResult Q3(Zaput model)
        {
            model.OrderCount = new List<int>();
            model.Names = new List<string>();
            model.queryId = 3;
            string sqlFilePath = Path.Combine(path, "Q3.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            using (var conn = new SqlConnection(secuelconnection))
            {
                conn.Open();
                using (var com = new SqlCommand(sqlQuery, conn))
                {
                    using (var reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            model.Names.Add(reader.GetString(0));
                            model.OrderCount.Add(reader.GetInt32(1));
                        }
                    }
                }
            }
            return View("Vivo", model);
        }
        public IActionResult Q4(Zaput model)
        {
            if (model.PaymentTypeeee == null)
            {
                TempData["Error2"] = $"Блін, пліз, введіть тип оплати ";
                return RedirectToAction("Index", "Sql_queries");
            }
            model.ides = new List<int>();
            model.Names = new List<string>();
            model.LastNames = new List<string>();
            model.queryId = 4;

            string sqlFilePath = Path.Combine(path, "Q4.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            sqlQuery = sqlQuery.Replace("@PaymentType", model.PaymentTypeeee.ToString());

            using (var conn = new SqlConnection(secuelconnection))
            {
                conn.Open();
                using (var com = new SqlCommand(sqlQuery, conn))
                {
                    using (var reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            model.ides.Add(reader.GetInt32(0));
                            model.Names.Add(reader.GetString(1));
                            model.LastNames.Add(reader.GetString(2));
                        }
                    }
                }
            }
            return View("Vivo", model);
        }
        public IActionResult Q5(Zaput model)
        {
            model.ides = new List<int>();
            model.DeliveryAdress = new List<string>();
            model.PaymentTypeName = new List<string>();
            model.ShipTypeName = new List<string>();
            model.queryId = 5;
            string sqlFilePath = Path.Combine(path, "Q5.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            using (var conn = new SqlConnection(secuelconnection))
            {
                conn.Open();
                using (var com = new SqlCommand(sqlQuery, conn))
                {
                    using (var reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            model.ides.Add(reader.GetInt32(0));
                            model.DeliveryAdress.Add(reader.GetString(1));
                            model.PaymentTypeName.Add(reader.GetString(2));
                            model.ShipTypeName.Add(reader.GetString(3));
                        }
                    }
                }
            }
            return View("Vivo", model);
        }

        public IActionResult HardQ1(Zaput model)
        {
            if (model.OrdeId == 0)
            {
                TempData["Error3"] = $"Блін, пліз, введіть order id користувача!";
                return RedirectToAction("Index", "Sql_queries");
            }
            if (model.oid == 0)
            {
                TempData["Error4"] = $"Блін, пліз, введіть order id користувача, який ви хочете виключити!";
                return RedirectToAction("Index", "Sql_queries");
            }
            int OrderrrIddddd = model.OrdeId;

            model.ides = new List<int>();
            model.queryId = 6;
            string sqlFilePath = Path.Combine(path, "HardQ1.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            sqlQuery = sqlQuery.Replace("@OrderId", OrderrrIddddd.ToString());
            sqlQuery = sqlQuery.Replace("@oId", model.oid.ToString());
            using (var conn = new SqlConnection(secuelconnection))
            {
                conn.Open();
                using (var com = new SqlCommand(sqlQuery, conn))
                {
                    using (var reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            model.ides.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return View("Vivo", model);
        }
        public IActionResult HardQ2(Zaput model)
        {
            if (model.oid == 0)
            {
                TempData["Error5"] = $"Блін, пліз, введіть order id користувача, який ви хочете виключити!";
                return RedirectToAction("Index", "Sql_queries");
            }
            if (model.OrdeId == 0)
            {
                TempData["Error6"] = $"Блін, пліз, введіть order id користувача!";
                return RedirectToAction("Index", "Sql_queries");
            }

            int OrderrrIddddd = model.OrdeId;

            model.ides = new List<int>();
            model.queryId = 7;
            string sqlFilePath = Path.Combine(path, "HardQ2.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            sqlQuery = sqlQuery.Replace("@oId", model.oid.ToString());
            sqlQuery = sqlQuery.Replace("@OrderId", OrderrrIddddd.ToString());
            using (var conn = new SqlConnection(secuelconnection))
            {
                conn.Open();
                using (var com = new SqlCommand(sqlQuery, conn))
                {
                    using (var reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            model.ides.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return View("Vivo", model);
        }

        public IActionResult HardQ3(Zaput model)
        {
            if (model.oid == 0)
            {
                TempData["Error7"] = $"Блін, пліз, введіть order id користувача, який ви хочете виключити!";
                return RedirectToAction("Index", "Sql_queries");
            }
            if (model.OrdeId == 0)
            {
                TempData["Error8"] = $"Блін, пліз, введіть order id користувача!";
                return RedirectToAction("Index", "Sql_queries");
            }

            int OrderrrIddddd = model.OrdeId;

            model.ides = new List<int>();
            model.queryId = 8;
            string sqlFilePath = Path.Combine(path, "HardQ3.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            sqlQuery = sqlQuery.Replace("@oId", model.oid.ToString());
            sqlQuery = sqlQuery.Replace("@OrderId", OrderrrIddddd.ToString());
            using (var conn = new SqlConnection(secuelconnection))
            {
                conn.Open();
                using (var com = new SqlCommand(sqlQuery, conn))
                {
                    using (var reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            model.ides.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return View("Vivo", model);
        }

    }
}