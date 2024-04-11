using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private Vector3 _scale;
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(_rotate * _speed);
        transform.localScale += _scale;
        transform.position += transform.forward * _speed * Time.deltaTime;
    }
}
