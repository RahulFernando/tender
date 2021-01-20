using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ceb_tender_app.Models;
using ceb_tender_app.Repository.ItemRepo;
using ceb_tender_app.ViewModels.Order;
using Microsoft.AspNetCore.Mvc;

namespace ceb_tender_app.Controllers
{
    public class ItemController : Controller
    {
        private applicationContext _applicationContext;
        private ItemImpl _itemRepository;
        private Random rand = new Random();

        public ItemController(applicationContext applicationContext)
        {
            _applicationContext = applicationContext;
            _itemRepository = new ItemImpl(applicationContext);
        }

        // list out all orders 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            List<Item> items = _itemRepository.GetAllItems();
            AddOrderViewModel addOrderView = new AddOrderViewModel(items);

            return View(addOrderView);
        }

        // create new order 
        [HttpPost]
        public async Task<IActionResult> Create(AddOrderViewModel addOrderViewModel)
        {
            if (ModelState.IsValid)
            {
                Item item = _itemRepository.FindById(addOrderViewModel.ItemId);

                Order order = new Order
                {
                    OrderId = "WPSII/" + addOrderViewModel.Type + "/" + addOrderViewModel.Opening.Year.ToString() + "/" + rand.Next(),
                    Opening = addOrderViewModel.Opening,
                    Init = addOrderViewModel.Init,
                    Item = item,
                    Total = addOrderViewModel.Total
                };

            }

            return View(addOrderViewModel);
        }
    }
}