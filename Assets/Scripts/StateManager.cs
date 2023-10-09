using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ahora hereda de Singleton (ya no de MonoBehaviour) y el tipo T ahora es StateManager
public class StateManager : Singleton<StateManager>
{
    //en videojuego no se usan propiedades, sino modificadores de acceso
    //setter y getter
    string _name;
    float _prize;

    public string getName()
    {
        return _name;
    }

    public void setName (string newName)
    {
        _name = newName;
    }

    public float getPrize()
    {
        return _prize;
    }


    public void setPrize(float newPrize)
    {
        _prize = newPrize;
    }



}
