using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TESTWebApi.Models;

using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;

namespace TESTWebApi.Controllers
{
    [ApiController]
    public class ItemController : Controller
    {
        
        private readonly IConfiguration _configuration;
        public ItemController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetItems")]
        public List<ItemModel> GetItems()
        {
            //return LoadList();
            return LoadListFromDB();


        }
       
        [HttpGet]
        [Route("GetItemsByID")]
        public List<ItemModel> GetItemsByID(string itemId)
        {
            //return LoadList().Where(e=>e.ItemCode ==itemId).ToList();
            return LoadListFromDB().Where(e=>e.ItemCode == itemId).ToList();
        }

        [HttpPost]
        [Route("PostItems")]
        public string PostItems(ItemModel item)
        {

            //List<ItemModel> list = new List<ItemModel>();
            //list.Add(item);

            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            string sql = $"insert into Items (ItemCode,ItemName,ItemPrice,ItemQuantity) values ('{item.ItemCode}','{item.ItemName}','{item.ItemPrice}','{item.ItemQuantity}')"; 
            SqlCommand sqlCommand = new SqlCommand(sql,connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();


            return "Item Added successfully!!!";

        }


        // api to delete a item using ItemCode from database 

        [HttpDelete]
        [Route("DeleteItem")]
        public string DeleteItemByID(string ItemCode)
        {

            //List<ItemModel> list = new List<ItemModel>();
            //list.Add(item);

            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            string sql = $"delete from Items where ItemCode = {ItemCode}";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();


            return "Item Deleted successfully!!!";

        }

        [HttpPut]
        [Route("UpdateItem")]
        
        public string UpdateItemByID( ItemModel itemModel, string ItemCode)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            string sql = $"Update Items set ItemCode = '{itemModel.ItemCode}',ItemName = '{itemModel.ItemName}',ItemPrice = '{itemModel.ItemPrice}',ItemQuantity = '{itemModel.ItemQuantity}' where ItemCode ='{ItemCode}'";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();

            return $"Item Updated successfully!!";
        }


        private List<ItemModel> LoadListFromDB()
        {
            List<ItemModel> list = new List<ItemModel>();

            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            SqlCommand cmd = new SqlCommand("select * from Items",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ItemModel itemModel = new ItemModel();
                itemModel.ItemCode = dt.Rows[i]["ItemCode"].ToString();
                itemModel.ItemName = dt.Rows[i]["ItemName"].ToString();
                itemModel.ItemPrice = decimal.Parse(dt.Rows[i]["ItemPrice"].ToString());
                itemModel.ItemQuantity = Convert.ToInt32(dt.Rows[i]["itemQuantity"]);


                list.Add(itemModel);
            }
            con.Close();

            
            return list;

        }

            private List<ItemModel> LoadList()
            
            {
                List<ItemModel> list = new List<ItemModel>();

                ItemModel item = new ItemModel();
                item.ItemCode = "1001";
                item.ItemName = "Lenovo bluetooth mouse";
                item.ItemPrice = 600;
                list.Add(item);

                item = new ItemModel();
                item.ItemCode = "1002";
                item.ItemName = "Lenovo Laptop";
                item.ItemPrice = 70000;
                list.Add(item);

                item = new ItemModel();
                item.ItemCode = "1003";
                item.ItemName = "Lenovo KeyBoard";
                item.ItemPrice = 700;
                list.Add(item);

                return list;


        }

    }
}
