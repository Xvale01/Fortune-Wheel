using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    //3 PARTES DE LOS SONIDOS
    //audio listener = parlantes
    //audio source = reproductor
    //existen dos tipos
        //1.music source
        //2.sound source / sfx source
    //audio clip = la cancion

    [SerializeField]
    Sound[] sounds;

    AudioSource _musicSource;
    AudioSource _sfxSource;

    protected override void Awake()
    {
        base.Awake();

        if (_musicSource == null)
        {
            _musicSource = gameObject.AddComponent<AudioSource>();
            _sfxSource = gameObject.AddComponent<AudioSource>();

        }
    }

        //vamos a buscar en el arreglos los sonidos
        Sound FindSound(string name)
    {
        return Array.Find(sounds, s => s.name == name);
    }


    public void PlayMusic(string name)
    {
        Sound music = FindSound(name);
        if (music != null)
        {
            _musicSource.loop = true;
            _musicSource.clip = music.sound;
            _musicSource.Play();
        }

    }

    //SFX es la forma de minimizar Play Sound Effects


    public void PlaySFX(string name, bool loop = true)
    {
        Sound sfx = FindSound(name);
        if (sfx == null) return;

        if (loop)
        {
            _sfxSource.loop = loop;
            _sfxSource.clip = sfx.sound;
            _sfxSource.Play();
        }
        else
        {
            _sfxSource.PlayOneShot(sfx.sound);
        }
    }

    public void StopSFX()
    {
        _sfxSource.Stop();
    }




}
