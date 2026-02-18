using UnityEngine;
using UnityEngine.EventSystems;  // Necesario para detectar el mouse

public class UnderlineOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Arrastra tu línea aquí desde el Inspector
    public GameObject underline;

    // Cuando el cursor entra al botón
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (underline != null)
            underline.SetActive(true);  // Activa la línea
    }

    // Cuando el cursor sale del botón
    public void OnPointerExit(PointerEventData eventData)
    {
        if (underline != null)
            underline.SetActive(false); // Desactiva la línea
    }
}
