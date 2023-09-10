using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowScript : MonoBehaviour
{
    private bool IsHolding;

    [SerializeField] float _degreesPerSecond = 60f;
    [SerializeField] Vector3 _axis = Vector3.forward;

    public Rigidbody2D rb;

    public float moveSpeed = 100f;

    public bool throwed = false;

    private bool hh;
    private bool gg;

    public HitThingScript HTS;
    public GameObject ThrowThingPos;

    public GameObject CircleClueOnOff;

    public AudioSource Audio;

    //public GameObject OriginalThrowThingPos;

    //Vector3 rotation = gameObject.transform.rotation.eulerAngles;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Startad());
    }

    // Update is called once per frame
    void Update()
    {
        HoldMoseButton();
    }

    public void HoldMoseButton()
    {
        if (!throwed)
        {
            
            if (IsHolding)
            {

                transform.Rotate(_axis.normalized * _degreesPerSecond * Time.deltaTime);

                if (transform.rotation.eulerAngles.z > 220)
                {
                    _degreesPerSecond = 60f;
                    Debug.Log("<100");
                }
                else if (transform.rotation.eulerAngles.z < 140)
                {
                    _degreesPerSecond = -60f;
                    Debug.Log(">100");
                }
            }
            
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Held");

                IsHolding = true;
                //gg = true;
                //StartCoroutine(Startad());
            }
            else if (Input.GetMouseButtonUp(0))
            {
                
                Debug.Log("Not held");
                IsHolding = false;
                rb.velocity = transform.right * moveSpeed;
                rb.constraints = RigidbodyConstraints2D.None;
                throwed = true;
                CircleClueOnOff.SetActive(false);
                Audio.Play();
                
                //hh = true;
                //StartCoroutine(Startad());
            }
            
        }
    }

    
    IEnumerator Startad()
    {
        if (throwed)
        {
            yield return new WaitForSeconds(4f);
            if (!HTS.PlayerWonLevel)
            {
                rb.constraints = RigidbodyConstraints2D.FreezeAll;
                yield return new WaitForSeconds(0.01f);
                //rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                //yield return new WaitForSeconds(0.1f);
                transform.position = ThrowThingPos.transform.position;
                throwed = false;
                CircleClueOnOff.SetActive(true);
            }  


        }
        /*
        if (gg)
        {
            if (Input.GetMouseButtonDown(0))
            {
                yield return new WaitForSeconds(0.3f);
                IsHolding = true;
                Debug.Log("Heldd");
            }
            else if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("NoHeld");
            }


        }

        if (hh)
        {
            if (Input.GetMouseButtonUp(0))
            {
                yield return new WaitForSeconds(0.3f);
                Debug.Log("Not held");
                IsHolding = false;
                rb.velocity = transform.right * moveSpeed;
                rb.constraints = RigidbodyConstraints2D.None;
                throwed = true;
                CircleClueOnOff.SetActive(false);
                Audio.Play();
            }
            else if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("NoHeld");
            }
        }
        */
        yield return new WaitForSeconds(1);
        StartCoroutine("Startad");
    } 
}

