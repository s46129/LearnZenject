using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Test4_FactoryBinding
{
    public class ItemListFactory : PlaceholderFactory<List<Item>>
    {
        private readonly int _itemCount;

        public ItemListFactory(int itemCount)
        {
            _itemCount = itemCount;
        }

        public override List<Item> Create()
        {
            var items = new List<Item>();

            for (var i = 0; i < _itemCount; i++)
            {
                items.Add(new Item(i));
            }

            Debug.Log("ItemListFactory.Create()");
            return items;
        }
    }
}