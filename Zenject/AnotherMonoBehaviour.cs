//Using Factory bindings to create objects
public class MyFactory : PlaceholderFactory<int, string, MyObject> {}

public class AnotherMonoBehaviour : MonoBehaviour
{
    private MyFactory _myFactory;

    [Inject]
    public void Construct(MyFactory myFactory)
    {
        _myFactory = myFactory;
    }

    private void Start()
    {
        MyObject myObject = _myFactory.Create(42, "Hello, world!");
        // Use myObject...
    }
}
