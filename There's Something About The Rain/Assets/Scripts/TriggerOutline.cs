using UnityEngine;

public class TriggerOutline : MonoBehaviour
{
    [SerializeField] private string outlineLayerName = "Outline"; // Target layer name
    [SerializeField] private string defaultLayerName = "Default"; // Reset layer name
    [SerializeField] private string triggeringTag = "Player"; // Who triggers the switch

    private int outlineLayer;
    private int defaultLayer;

    void Awake()
    {
        // Cache layer indexes to avoid lookup every time
        outlineLayer = LayerMask.NameToLayer(outlineLayerName);
        defaultLayer = LayerMask.NameToLayer(defaultLayerName);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(triggeringTag))
        {
            gameObject.layer = outlineLayer;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(triggeringTag))
        {
            gameObject.layer = defaultLayer;
        }
    }
}
