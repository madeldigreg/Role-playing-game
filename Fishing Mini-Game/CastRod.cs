using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastRod : MonoBehaviour
{
    public GameObject bait;
    public float hookSpeed;
    public Transform hookPoint;
    Vector2 direction;
    public LineRenderer fishingLine;
    GameObject fishTarget;
    GameObject logTarget;
    public SpringJoint2D springJnt;

    // Start is called before the first frame update
    void Start()
    {
        fishingLine.enabled = false;
        springJnt.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)transform.position;
        FaceMouse();

        if (Input.GetMouseButtonDown(0))
        {
            // cast fishing line when mouse button clicked
            Cast();
        }

        if(fishTarget != null)
        {
            fishingLine.SetPosition(0, hookPoint.position);
            fishingLine.SetPosition(1, fishTarget.transform.position);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Release();
        }
    }

    void FaceMouse()
    {
        transform.right = direction;
    }

    void Cast()
    {
        GameObject baitInstance = Instantiate(bait, hookPoint.position, Quaternion.identity);
        baitInstance.GetComponent<Rigidbody2D>().AddForce(transform.right * hookSpeed);
    }

    public void FishHit(GameObject hit)
    {
        fishTarget = hit;
        fishingLine.enabled = true;
        springJnt.enabled = true;
        springJnt.connectedBody = fishTarget.GetComponent<Rigidbody2D>();
    }

    public void LogHit(GameObject hit)
    {
        logTarget = hit;
        fishingLine.enabled = false;
        springJnt.enabled = false;
    }

    void Release()
    {
        fishingLine.enabled = false;
        springJnt.enabled = false;
        fishTarget = null;
    }
}
