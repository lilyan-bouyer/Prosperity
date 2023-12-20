using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;

    public void Init(bool isoffset) {
        _renderer.color = (isoffset ? _offsetColor : _baseColor);
    }
}
