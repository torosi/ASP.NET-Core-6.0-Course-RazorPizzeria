using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;
using System.Collections.Generic;
using System.Linq;

namespace RazorPizzeria.Pages
{
    public class OrdersModel : PageModel
    {

        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();


        private readonly ApplicationDbContext _context;

        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }


        public void OnGet()
        {
            PizzaOrders = _context.PizzaOrders.ToList();

        }
    }
}
