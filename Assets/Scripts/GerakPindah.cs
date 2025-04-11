using UnityEngine;

public class GerakPindah : MonoBehaviour
{

    float speed = 5f;
    public Sprite[]  sprites;

    void Start()
    {
        int index = Random.Range(0,sprites.Length);
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[index];
    }

    void Update()
    {
        float move = transform.position.y + (speed * Time.deltaTime  )  ;
        transform.position = new Vector3(transform.position.x, move);
        
    }
    private Vector3 screenPoint;
    private Vector3 offset;
    private float firstY;

    void OnMouseDown()
    {
        firstY = transform.position.y;
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
    }

    void OnMouseUp()
    {
        transform.position = new Vector3(0, firstY, transform.position.z);
    }
}
