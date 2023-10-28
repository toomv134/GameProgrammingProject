using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Onhover : MonoBehaviour
{
    [Space(10)] [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip sound_click;
    [SerializeField] AudioClip sound_hover;
    public Image buttonImage;
    public Sprite normalSprite; // 원래 이미지
    public Sprite hoverSprite; // 마우스 호버 시에 보여줄 이미지
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void UIClick()
    {
        audioSource.PlayOneShot(sound_click);
        buttonImage.sprite = normalSprite;
    }


    public void OnMouseOver()
    {
        buttonImage.sprite = hoverSprite; // 마우스가 버튼 위에 있을 때 이미지를 바꿉니다.
        audioSource.PlayOneShot(sound_hover);
    }

    public void OnMouseExit()
    {
        buttonImage.sprite = normalSprite; // 마우스가 버튼에서 빠져나갈 때 이미지를 복구합니다.
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
