using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;


public class ButTransitor : MonoBehaviour,IPointerEnterHandler, IPointerDownHandler, IPointerClickHandler, IPointerExitHandler, IPointerUpHandler
{
    public Color norma = Color.white;
    public Color hover = Color.white;
    public Color down = Color.white;

    private Image img;

    private void Awake()
    {
        img = GetComponent<Image>();

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        print("Enter");
        img.color = hover;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        print("Exit");
        img.color = norma;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        print("Down");
        img.color = down;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        print("Up");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        print("Click");
        img.color = hover;
    }




}
