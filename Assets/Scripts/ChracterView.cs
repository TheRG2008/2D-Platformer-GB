using UnityEngine;

public class ChracterView : MonoBehaviour
{
   [SerializeField] private SpriteRenderer _spriteRenderer;

   public SpriteRenderer SpriteRenderer => _spriteRenderer;
}
