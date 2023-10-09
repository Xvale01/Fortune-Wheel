using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoState<LevelManager> 
{
    int sceneCount;

    // el metodo Awake es como el constructor de la clase, se ejecuta cuando el juego comienza, o cuando comienza la escena
    protected override void Awake()
    {
        base.Awake();
        sceneCount = SceneManager.sceneCountInBuildSettings - 1;
        //obtiene el total de escenas

    }

    public void FirstScene()
    {
        //SI SE ESTA EN LA PRIMERA ESCENA Y SE LE DICE LEA LA ESCENA NO DEBERIA LEERLA, YA SE ESTA AHÍ.
        //PARA VOLVER A LEER LA PRIMERA ESCENA HAY UN MÉTODO LLAMADO RELOAD


        //Si se esta en la escena (0) haga un return 
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            return;
        }

        SceneManager.LoadScene(0);
    }

    public void LastScene()
    {
        //si el número de escena es igual al numero total de escenas del juego entonces salgase
        //como va de 0 a -1 entonces quiere decir que el numero de sceneCountInBuildSettings es menor
        if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings)
        {
            //si es la ultima escena salgase
            return;
        }
        //sino lea la última escena
        SceneManager.LoadScene(sceneCount);



    }

    public void NextScene()
    {
        // la escena actual es ....
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        //se pasa a la siguiente escena solo si es menor a sceneCount
        if (currentScene >= sceneCount)
        {
            return;
        }

        SceneManager.LoadScene(currentScene + 1);

    }

    public void PreviousScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if (currentScene <= sceneCount)
        {
            return;
        }

        SceneManager.LoadScene(currentScene - 1);
    }




}

