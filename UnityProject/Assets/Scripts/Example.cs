using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private GameObject m_gameObject;
    [SerializeField] private Transform  m_parent;
    [SerializeField] private int        m_count;

    private void Awake()
    {
        for ( var i = 0; i < m_count; i++ )
        {
            var x = Random.Range( -8f, 8f );
            var y = Random.Range( -4f, 4f );

            Instantiate( m_gameObject, new Vector3( x, y ), Quaternion.identity, m_parent );
        }

        Destroy( m_gameObject );
    }
}