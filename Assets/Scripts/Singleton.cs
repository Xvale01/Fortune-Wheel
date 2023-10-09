using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour
    where T : MonoBehaviour
    //el t significa es que es generico T=tipo el tipo tiene que ser MonoBehaviour

{
    //es estatico lo que significa que se puede acceder sin necesidad de una instancia
    //y como es abstract no se puede acceder con una instancia, solo de manera heredada
    //a los hijos o padres

    static Singleton<T> _instance;
    protected static object _lock = new object();

    protected virtual void Awake()
    {
        //destruyame 
        bool destroyMe = true;

        //instance es null?
        if (_instance == null)
        {   
            //si, instance es null, entonces ponga un candado
            lock (_lock)
            {
                //instance es null?
                if (_instance == null)
                {
                    //si, instance es null, entonces ponga un candado
                    //entonces no me destruya
                    destroyMe = false;

                    //y ahora la instancia soy yo
                    _instance = this;

                    //nunca más me vuelva a destruir
                    DontDestroyOnLoad(gameObject);
                }
            }
        }

        //si, instance es true, entonces destruyame y salgase
        if (destroyMe)
        {
            Destroy(gameObject);
            return;
        }
    }

    //convierta la instancia en un tipo T y devuelvalo
    //así nos aseguramos de que no se destruya el objeto
    public static T Instance
    {
        get
        {
            return _instance as T;
        }
    }
}
