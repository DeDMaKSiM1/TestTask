using Components;
using Configs;
using Managers;
using UnityEngine;
using Zenject;

public class Installer : MonoInstaller
{
    [SerializeField] private PlayerConfig playerConfig;
    [SerializeField] private WeaponConfig weaponConfig;

    public override void InstallBindings()
    {
        Container.Bind<SpawnComponent>().AsTransient();
        Container.Bind<PlayerConfig>().AsSingle();
        //Container.Bind<WeaponConfig>().FromScriptableObject(weaponConfig);

    }
}