using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SpriteRenderer _background;
    [SerializeField] private SpriteRenderer _midleground;
    [SerializeField] private GameObject _player;
    private ChracterView _chracterView;
    private ParalaxManager _paralaxManager;
    private SpriteAnimator _spriteAnimator;

    private void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _background.transform, _midleground.transform);
        SpriteAnimationConfig config = Resources.Load<SpriteAnimationConfig>("SpriteAnimationConfig");
        _spriteAnimator = new SpriteAnimator(config);
        _chracterView = _player.GetComponent<ChracterView>();
        _spriteAnimator.StartAnimation(_chracterView.SpriteRenderer, Track.characterIdle, true, 10);
    }

    private void Update()
    {
        _paralaxManager.Update();
        
        _spriteAnimator.Update();
    }

    private void FixedUpdate()
    {
        
    }

    private void OnDestroy()
    {
        
    }
}
