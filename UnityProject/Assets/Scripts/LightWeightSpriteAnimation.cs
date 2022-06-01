using UnityEngine;

public sealed class LightWeightSpriteAnimation : MonoBehaviour
{
    [SerializeField] private Sprite[]       m_spriteArray;
    [SerializeField] private SpriteRenderer m_spriteRenderer;
    [SerializeField] private float          m_duration;

    private int   m_frame;
    private float m_elapsedTime;

    private void Start()
    {
        m_spriteRenderer.sprite = m_spriteArray[ m_frame ];
    }

    private void Update()
    {
        m_elapsedTime += Time.deltaTime;

        if ( m_elapsedTime < m_duration ) return;

        m_elapsedTime -= m_duration;
        m_frame       =  ( m_frame + 1 ) % m_spriteArray.Length;

        m_spriteRenderer.sprite = m_spriteArray[ m_frame ];
    }
}