using UnityEngine;

public class ParalaxManager
{
    private const float _coefBack = 0.8f;
    private const float _coefMidle = 0.3f;
    
    private readonly Camera _camera;
    private readonly Transform _backTransform;
    private readonly Transform _midleTransform;
    private readonly Vector3 _backStartPosition;
    private readonly Vector3 _midleStartPosition;
    private readonly Vector3 _cameraStartPosition;
    


    public ParalaxManager(Camera camera, Transform backTransform, Transform midleTransform)
    {
        _camera = camera;
        _backTransform = backTransform;
        _midleTransform = midleTransform;
        _backStartPosition = backTransform.position;
        _midleStartPosition = midleTransform.position;
        _cameraStartPosition = camera.transform.position;
    }

    public void Update()
    {
        _backTransform.position = _backStartPosition + (_camera.transform.position - _cameraStartPosition) * _coefBack;
        _midleTransform.position =
            _midleStartPosition + (_camera.transform.position - _cameraStartPosition) * _coefMidle;
    }
}
