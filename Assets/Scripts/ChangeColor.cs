using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private void OnMouseDown()
    {
        SetColor();
    }

    private void SetColor()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }
}
