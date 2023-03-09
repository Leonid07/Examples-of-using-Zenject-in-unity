//Using Scene Contexts to manage object lifetimes
public class MySceneInstaller : MonoInstaller<MySceneInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<IMyDependency>().To<MyDependency>().AsSingle();
        Container.Bind<MyMonoBehaviour>().FromComponentInNewPrefabResource("MyPrefab").AsSingle();
    }
}

public class MySceneBehaviour : MonoBehaviour
{
    private DiContainer _container;

    [Inject]
    public void Construct(DiContainer container)
    {
        _container = container;
    }

    private void Start()
    {
        SceneContext sceneContext = _container.Resolve<SceneContext>();
        sceneContext.Install<MySceneInstaller>();
    }
}
