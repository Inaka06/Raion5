using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ultimate : MonoBehaviour
{
    public Transform shootingPoint;
    public Slider ultimateSlider;
    public float ultimateCharge = 0f;

    void Start()
    {
        ultimateSlider.maxValue = 100f;
        ultimateSlider.minValue = 0f;
        ultimateSlider.value = ultimateCharge;
    }

    // Update is called once per frame

    [SerializeField] private Animator ultAnimator;
    bool ultReady = false;

    void fillUltimate()
    {
        ultimateSlider.value = Mathf.Lerp(ultimateSlider.minValue, ultimateSlider.maxValue, 1f * Time.deltaTime);
    }
    void resetUltimate()
    {
        ultimateSlider.value = ultimateSlider.minValue;
    }

    void Update()
    {
        fillUltimate();

        if(ultimateCharge >= 100f)
        {
            Debug.Log("Ultimate Ready");
            ultReady = true;
        }else{
            ultReady = false;
        }

        //ultimate press g
        if(Input.GetKeyDown(KeyCode.G) && ultReady == true)
        {
            ultAnimator.SetBool("isUlt", true);
            ultimateCharge = 0f;
            ultimateSlider.value = ultimateCharge;
            // resetUltimate();
            ultReady = false;
        }else{
            ultAnimator.SetBool("isUlt", false);;
        }
    }
}
