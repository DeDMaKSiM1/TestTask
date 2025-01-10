using Components;
using Configs;
using Interfaces;
using Managers;
using Scripts;
using UnityEngine;
using Zenject;

public class Installer : MonoInstaller
{
    [SerializeField] private SceneRebooterManager sceneRebooter;
    [SerializeField] private PlayerConfig playerConfig;
    private IDamageDealable weapon;

    public override void InstallBindings()
    {
        Container.Bind<SpawnComponent>().AsTransient();

        Container.Bind<PlayerConfig>().FromScriptableObject(playerConfig).AsSingle();
        Container.Bind<SceneRebooterManager>().FromInstance(sceneRebooter);
        Container.Bind<IDamageDealable>().To<Weapon>().AsTransient();

    }
}