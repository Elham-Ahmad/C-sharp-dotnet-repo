using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using TESTWebApi.DataModels;
using TESTWebApi.Models;

namespace TESTWebApi.Controllers
{
    [ApiController]
    public class ItemEFController : Controller
    {
        [HttpGet]
        [Route("GetItemsEF")]

        public List <Item> GetItems()
        {
            TestWebApiContext context = new TestWebApiContext();
            return context.Items.ToList();

        }


        [HttpGet]
        [Route("GetItemsByIDEF")]
        public  List<Item> GetItemsByIDEF(string itemid)
        {
           
            TestWebApiContext context = new TestWebApiContext();
            return  context.Items.Where(e => e.ItemCode == itemid).ToList();
        }



        [HttpPost]
        [Route("PostItemsEF")]
        public string PostItemsEF(Item item)
        {

            TestWebApiContext context = new TestWebApiContext();
            context.Items.Add(item);
            context.SaveChanges();

            return "Item Added successfully!!!";

        }

        [HttpDelete]
        [Route("DeleteItemBYID")]
        public string DeleteItemByID(string ItemCode)
        {

          
            TestWebApiContext context = new TestWebApiContext();
            context.Remove(context.Items.FirstOrDefault(e => e.ItemCode == ItemCode));  
            context.SaveChanges();


            return "Item Deleted successfully!!!";

        }

    }
}
