namespace ConsoleApp2;

public class Inventory
{
    public int _id;
    private string _name;
    private int _count;
    static public int _idd = 1;

    public Inventory(string name, int count)
    {
        _id = _idd++;
        _name = name;
        _count = count;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int Count
    {
        get => _count;
        set => _count = value;
    }

}
