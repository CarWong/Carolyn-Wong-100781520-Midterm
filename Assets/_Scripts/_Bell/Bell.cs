using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bell : MonoBehaviour
{
    public abstract string Name { get; }

    public abstract GameObject Create(GameObject prefab);
}

public class GreenBell : Bell
{
    public override string Name => "green bell";

    public override GameObject Create(GameObject prefab)
    {
        GameObject bell = Instantiate(prefab);
        return bell;
    }
}

public class WhiteBell : Bell
{
    public override string Name => "white bell";

    public override GameObject Create(GameObject prefab)
    {
        GameObject bell = Instantiate(prefab);
        return bell;
    }
}

public class YellowBell : Bell
{
    public override string Name => "yellow bell";

    public override GameObject Create(GameObject prefab)
    {
        GameObject bell = Instantiate(prefab);
        return bell;
    }
}
