using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private ProjectitleBehaviourScript _bulletRef;
    [SerializeField]
    private float _bulletForce;

    public void Fire()
    {
        GameObject bullet = Instantiate(_bulletRef.gameObject, transform.position, transform.rotation);
        ProjectitleBehaviourScript bulletBehaviour = bullet.GetComponent<ProjectitleBehaviourScript>();
        bulletBehaviour.RigidBody.AddForce(transform.forward * _bulletForce, ForceMode.Impulse);
    }
}
