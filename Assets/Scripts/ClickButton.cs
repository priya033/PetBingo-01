using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ClickButton : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image _img;
    [SerializeField] private Sprite _default, _pressed;
    [SerializeField] AudioClip _compressClip, _uncompressClip;
    [SerializeField] AudioSource _source;
    public void OnPointerDown(PointerEventData eventData)
    {
        _img.sprite = _pressed;
        _source.PlayOneShot(_compressClip);
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        _img.sprite = _default;
        _source.PlayOneShot(_uncompressClip);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }




}
