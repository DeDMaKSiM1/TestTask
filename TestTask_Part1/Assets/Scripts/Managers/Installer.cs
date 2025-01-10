using Components;
using Configs;
using Interfaces;
using Managers; 
using UnityEngine;
using Zenject;

public class Installer : MonoInstaller
{ 
    [SerializeField] private PlayerConfig playerConfig;
    private IDamageDealable weapon;

    public override void InstallBindings()
    {
        Container.Bind<SpawnComponent>().AsTransient();

        Container.Bind<PlayerConfig>().FromScriptableObject(playerConfig).AsSingle(); 
        Container.Bind<IDamageDealable>().To<Weapon>().AsTransient();

    }
}