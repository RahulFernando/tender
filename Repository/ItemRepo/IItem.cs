using ceb_tender_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ceb_tender_app.Repository.ItemRepo
{
    public interface IItem
    {
        void AddItem(Item item);
        Item FindById(int id);
        List<Item> GetAllItems();
    }
}
