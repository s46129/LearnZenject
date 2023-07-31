using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Test4_FactoryBinding
{
    public class ItemFactoryInstaller : MonoInstaller
    {
        [SerializeField] private int _itemCount = 10;

        public override void InstallBindings()
        {
            Container.BindFactory<List<Item>, ItemListFactory>()
                .WithFactoryArguments(_itemCount).AsSingle();
        }
    }
}