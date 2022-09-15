
using System;
using System.Collections.Generic;
using UnityEngine;

public enum Track
{
    characterIdle,
    characterWalk
}

[CreateAssetMenu (fileName = "SpriteAnimationConfig", menuName = "Config/SpriteAnimationConfig", order = 1)]
public class SpriteAnimationConfig : ScriptableObject
{
    [Serializable] public class SpritesSequence
    {
        public Track Track;
        public List<Sprite> Sprites = new List<Sprite>();
    }

    public List<SpritesSequence> Sequences = new List<SpritesSequence>();

}
