using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onhover : MonoBehaviour
{
    [Space(10)] [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip sound_click;
    [SerializeField] AudioClip sound_hover;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void UIClick()
    {
        audioSource.PlayOneShot(sound_click);
    }

    public void UIHover()
    {
        audioSource.PlayOneShot(sound_hover);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
