using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ceb_tender_app.Models;

namespace ceb_tender_app.Repository.ItemRepo
{
    public class ItemImpl : IItem
    {
        private applicationContext _applicationContext;

        public ItemImpl(applicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void AddItem(Item item)
        {
            _applicationContext.Items.AddAsync(item);
            _applicationContext.SaveChangesAsync();
        }

        public Item FindById(int id)
        {
            return _applicationContext.Items.Find(id);
        }

        public List<Item> GetAllItems()
        {
            return _applicationContext.Items.ToList();
        }
    }
}
