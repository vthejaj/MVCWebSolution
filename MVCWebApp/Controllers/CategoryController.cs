using MVCWebApp.Models.adonet;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult List()
        {
            // Connect to LocalDB database 
            SqlConnection con = new SqlConnection(Database.MSDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from categories", con);
            SqlDataReader dr = cmd.ExecuteReader();
            // Convert Rows in DataReader to Category objects and place them in List
            var cats = new List<Category>();
            while (dr.Read())
            {
                cats.Add(
                    new Category
                    {
                        Code = dr[0].ToString(),
                        Description = dr[1].ToString()
                    }
                );
            }
            dr.Close();
            con.Close();

            return View(cats);
        }

        public ActionResult Add()
        {
            var model = new Category();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Category model)
        {
            if (ModelState.IsValid)
            {
                SqlConnection con = new SqlConnection(Database.MSDBConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand
                     ("insert into categories values(@code,@desc)", con);
                cmd.Parameters.AddWithValue("@code", model.Code);
                cmd.Parameters.AddWithValue("@desc", model.Description);
                try
                {
                    cmd.ExecuteNonQuery();
                    return RedirectToAction("List");
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Sorry! Could not add category. Error : " + ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }

            return View(model);
        }
    }
}