using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

public class LoadSprite : MonoBehaviour
{
    [SerializeField] private Image _image = null;

    private void Start()
    {
        Addressables.LoadAsset<Sprite>("Assets/Textures/icon_medical/icon_medical_man01.png").Completed +=
            op => _image.sprite = op.Result;
    }

    private void OnDestroy()
    {
        Addressables.ReleaseAsset(_image.sprite);
    }
}
