using ceb_tender_app.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ceb_tender_app.ViewModels.Order
{
    public class AddOrderViewModel
    {
        public DateTime Init { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Opening date is required")]
        public DateTime Opening { get; set; }
        [Required(ErrorMessage = "Item is required")]
        public int ItemId { get; set; }
        public List<SelectListItem> Items { get; set; }
        public int Total { get; set; }
        public string Type { get; set; }

        public AddOrderViewModel()
        {
        }

        public AddOrderViewModel(List<Item> items)
        {
            Items = new List<SelectListItem>();

            foreach (var item in items)
            {
                Items.Add(new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.Name
                });
            }
        }
    }
}
