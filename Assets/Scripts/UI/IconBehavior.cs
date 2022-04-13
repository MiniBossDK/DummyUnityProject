using UnityEngine;
using System.Linq;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class IconBehavior : MonoBehaviour
{
    [SerializeField]
    private string pathToIconPack;
    private Texture2D[] _icons;
    public RawImage _rawImage;

    private void Start()
    {
        _rawImage = GetComponent<RawImage>();

        _icons = Resources.LoadAll(pathToIconPack, typeof(Texture2D)).Cast<Texture2D>().ToArray();

        if (Screen.dpi <= 160)
        {
            //change your UI textures for mdpi
            _rawImage.texture = _icons[4];
            Debug.Log("Using " + 160);
        }
        else if (Screen.dpi <= 240)
        {
            //change your UI textures for hdpi
            _rawImage.texture = _icons[4];

            Debug.Log("Using " + 240);
        }
        else if (Screen.dpi <= 320)
        {
            //change your UI textures for xhdpi
            _rawImage.texture = _icons[4];
            Debug.Log("Using " + 320);
        }
        else if (Screen.dpi <= 480)
        {
            //change your UI textures for xxhdpi
            _rawImage.texture = _icons[4];
            Debug.Log("Using " + 480);
        }
        else
        {
            //change your UI textures for xxxhdpi
            _rawImage.texture = _icons[4];
            Debug.Log("Using OG");
        }
    }
}
