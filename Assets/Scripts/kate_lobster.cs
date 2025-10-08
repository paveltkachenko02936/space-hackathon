using UnityEngine;

public class kate_lobster : MonoBehaviour
{
    // �������� ��������
    public float rotationSpeed = 50f;

    // ������� ���������
    public float pulseSpeed = 2f;

    // ��������� ��������� �������
    public float pulseAmplitude = 0.3f;

    // �������� ������
    private Vector3 startScale;

    void Start()
    {
        startScale = transform.localScale;
    }

    void Update()
    {
        // --- �������� ---
        // ������� ��� �� ������ ����
        float rotX = Mathf.Sin(Time.time) * rotationSpeed * Time.deltaTime;
        float rotY = Mathf.Cos(Time.time * 0.8f) * rotationSpeed * Time.deltaTime;
        transform.Rotate(rotX, rotY, 0);

        // --- ��������� ---
        float scale = 1 + Mathf.Sin(Time.time * pulseSpeed) * pulseAmplitude;
        transform.localScale = startScale * scale;
    }
}
