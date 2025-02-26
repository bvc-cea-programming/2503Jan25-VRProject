using UnityEngine;

public class FlashLight : MonoBehaviour
{
    private bool _isOn = false;

    [SerializeField] private MeshRenderer bulbRenderer;
    [SerializeField] private GameObject spotLight;
    [SerializeField] private Material lightOffMat;
    [SerializeField] private Material lightOnMat;

    public void ToggleLight()
    {
        _isOn = !_isOn;

        spotLight.SetActive(_isOn);

        bulbRenderer.material = _isOn ? lightOnMat : lightOffMat;
    }
    
}
