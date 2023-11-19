using Unity.Mathematics;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // var asd = Input.GetAxisRaw("Horizontal");

        // if (asd == -1)
        // {
        //     transform.rotation = quaternion.Euler(0f, 0f, 0f);
        //     anim.SetFloat("Speed", 1F);
        // }

        // if (asd == +1)
        // {
        //   //  transform.rotation = quaternion.Euler(0f, 180, 0f);
        //     
        // }
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput > 0)
        {
            anim.SetFloat("Speed", 1F);
            transform.eulerAngles = new Vector3(0,0,0);
        }
        else if (horizontalInput < 0)
        {
            anim.SetFloat("Speed", 1F);
            transform.eulerAngles = new Vector3(0, 180, 0);
        }


        Vector3 movement = new Vector3(inputX, inputY, 0) * Time.deltaTime;

        transform.position += 10f * movement;

        transform.Translate(movement);
        anim.SetFloat("Speed", 0F);

    }
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
}
