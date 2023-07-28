using UnityEngine;
using Zenject;

namespace Test3_ProjectContainer
{
    public class ProjectContainerBinding : MonoInstaller
    {
        [SerializeField] SoundManager soundManager;
        [SerializeField] LocalizationManager localizeManager;

        public override void InstallBindings()
        {
            Container.Bind<SoundManager>().FromComponentInNewPrefab(soundManager).AsSingle();
            Container.Bind<LocalizationManager>().FromInstance(localizeManager).AsSingle();
        }
    }
}