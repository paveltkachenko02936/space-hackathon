using UnityEngine;

public class kate_lobster : MonoBehaviour
{
    // скорость вращени€
    public float rotationSpeed = 50f;

    // частота пульсации
    public float pulseSpeed = 2f;

    // амплитуда изменени€ размера
    public float pulseAmplitude = 0.3f;

    // исходный размер
    private Vector3 startScale;

    void Start()
    {
        startScale = transform.localScale;
    }

    void Update()
    {
        // --- ¬–јў≈Ќ»≈ ---
        // вращаем куб по разным ос€м
        float rotX = Mathf.Sin(Time.time) * rotationSpeed * Time.deltaTime;
        float rotY = Mathf.Cos(Time.time * 0.8f) * rotationSpeed * Time.deltaTime;
        transform.Rotate(rotX, rotY, 0);

        // --- ѕ”Ћ№—ј÷»я ---
        float scale = 1 + Mathf.Sin(Time.time * pulseSpeed) * pulseAmplitude;
        transform.localScale = startScale * scale;
    }
}
