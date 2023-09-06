using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowScript : MonoBehaviour
{
    private bool IsHolding;

    [SerializeField] float _degreesPerSecond = 30f;
    [SerializeField] Vector3 _axis = Vector3.forward;

    public Rigidbody2D rb;

    public float moveSpeed = 100f;

    public bool throwed = false;
    // Start is called before the first frame update
    void Start()
    {
        
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
                //transform.Rotate(v * 0.1f);
                transform.Rotate(_axis.normalized * _degreesPerSecond * Time.deltaTime);
            }

            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Held");

                IsHolding = true;
            }
            else if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("Not held");
                IsHolding = false;
                rb.velocity = transform.right * moveSpeed;
                rb.constraints = RigidbodyConstraints2D.None;
                throwed = true;
            }

        }

    }
}
