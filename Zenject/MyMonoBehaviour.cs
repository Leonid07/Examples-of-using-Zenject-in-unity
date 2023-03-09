// Injecting dependencies into MonoBehaviours
public class MyMonoBehaviour : MonoBehaviour
{
    private IMyDependency _myDependency;

    [Inject]
    public void Construct(IMyDependency myDependency)
    {
        _myDependency = myDependency;
    }

    private void Start()
    {
        _myDependency.DoSomething();
    }
}
