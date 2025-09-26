using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class CooldownImage : MonoBehaviour
{

    private float currentTime;
    [SerializeField] private float colldownTimer;


    Image image;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       image = this.GetComponent<Image>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) {
            currentTime = 0.0f;
        }

        currentTime += Time.deltaTime;

        float facto = Mathf.Min(1.0f,currentTime / colldownTimer);
        image.fillAmount = facto;
    }
}
