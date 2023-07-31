using UnityEngine;
using Zenject;

namespace Test4_FactoryBinding
{
    public class FactoryUser : MonoBehaviour
    {
        [Inject] private ItemListFactory _itemList;


        public void Start()
        {
            var items = _itemList.Create();
            foreach (var item in items)
            {
                var itemObject = new GameObject($"Item {(item.ID + 1).ToString()}");
            }

            Debug.Log("FactoryUser.Start()");
        }
    }
}