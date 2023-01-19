using UnityEngine;

[CreateAssetMenu]
public class HighlightData : ScriptableObject
{
    [field: SerializeField] public Material Hover { get; private set; }
    [field: SerializeField] public Material Selected { get; private set; }
}