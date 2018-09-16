using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

public class LoadSprite2 : MonoBehaviour
{
    [AssetReferenceTypeRestriction(typeof(Texture2D))]
    public AssetReference AssetReference;

    [SerializeField] private Image _image = null;

    private void Start()
    {
        Addressables.LoadAsset<Sprite>(AssetReference).Completed += op => _image.sprite = op.Result;
    }

    private void OnDestroy()
    {
        Addressables.ReleaseAsset(_image.sprite);
    }
}
