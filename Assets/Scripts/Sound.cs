
using System;
using UnityEngine;

[Serializable]

public class Sound 
{
    //3 PARTES DE LOS SONIDOS
    //audio listener = parlantes
    //audio source = reproductor
    //audio clip = la cancion



    //se les haría un get, pero solo se hacen get cuando son controladores (componentes)
    //al no ser componente si se pueden hacer de manera publica, es una clase que si puede ser moldada
    //los compoenentes no pueden cambiar
    //para obtenerlos en  Sound FindSound(string name){}

    [SerializeField]
    public string name;

    [SerializeField]
    public AudioClip sound;


}
