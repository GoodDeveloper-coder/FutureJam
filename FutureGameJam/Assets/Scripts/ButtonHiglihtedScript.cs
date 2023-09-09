
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonHiglihtedScript : MonoBehaviour, IPointerEnterHandler
{
    public AudioSource AudioHiglihted;
    public AudioSource AudioSelected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        AudioHiglihted.Play();
        
    }

    public void Clicked()
    {
        AudioSelected.Play();
    }

}
