using UnityEngine;

public class CameraAdjuster
{
    private readonly SpriteRenderer _templateSprite;
    private readonly Camera _mainCamera;

    public CameraAdjuster(SpriteRenderer templateSprite)
    {
        _templateSprite = templateSprite;
        _mainCamera = Camera.main;
    }

    public void AdjustCameraToBackground()
    {

        float spriteWidth = _templateSprite.bounds.size.x;
        float spriteHeight = _templateSprite.bounds.size.y;

        float screenAspect = (float)Screen.width / Screen.height;
        float spriteAspect = spriteWidth / spriteHeight;

        if (screenAspect >= spriteAspect)
        {
            _mainCamera.orthographicSize = spriteHeight / 2;
        }
        else
        {
            float differenceInSize = spriteAspect / screenAspect;
            _mainCamera.orthographicSize = spriteHeight / 2 * differenceInSize;
        }
        _mainCamera.transform.position = new Vector3(_templateSprite.transform.position.x,
                                                     _templateSprite.transform.position.y, _mainCamera.transform.position.z);
    }
}
