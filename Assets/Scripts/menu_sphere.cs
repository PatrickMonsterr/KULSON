using UnityEngine;

public class menu_sphere : MonoBehaviour
{
     private bool isDragging = false;
    private Vector3 lastMousePosition;
    private Vector3 momentum; // Przechowuje bezwładność
    public float rotationSpeed = 10f; // Prędkość obracania kuli
    public float momentumDampening = 5f; // Tłumienie bezwładności

    void OnMouseDown()
    {
        // Rozpoczęcie przeciągania kuli
        isDragging = true;
        lastMousePosition = Input.mousePosition;
        momentum = Vector3.zero; // Resetuj momentum przy nowym chwyceniu
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            // Oblicz różnicę pozycji myszy
            Vector3 deltaMousePosition = Input.mousePosition - lastMousePosition;

            // Obracaj kulę na podstawie ruchu myszy
            float rotationX = deltaMousePosition.y * rotationSpeed * Time.deltaTime;
            float rotationY = -deltaMousePosition.x * rotationSpeed * Time.deltaTime;

            transform.Rotate(Camera.main.transform.up, rotationY, Space.World);
            transform.Rotate(Camera.main.transform.right, rotationX, Space.World);

            // Zapisz momentum (ostatni ruch myszy)
            momentum = new Vector3(rotationX, rotationY, 0);

            // Zaktualizuj ostatnią pozycję myszy
            lastMousePosition = Input.mousePosition;
        }
    }

    void OnMouseUp()
    {
        // Zakończenie przeciągania kuli
        isDragging = false;
    }

    void Update()
    {
        // Jeśli kula nie jest przeciągana, zastosuj bezwładność
        if (!isDragging && momentum.magnitude > 0.01f)
        {
            // Obracaj kulę z użyciem momentum
            transform.Rotate(Camera.main.transform.up, momentum.y, Space.World);
            transform.Rotate(Camera.main.transform.right, momentum.x, Space.World);

            // Tłumienie momentum
            momentum = Vector3.Lerp(momentum, Vector3.zero, momentumDampening * Time.deltaTime);
        }
    }
}
