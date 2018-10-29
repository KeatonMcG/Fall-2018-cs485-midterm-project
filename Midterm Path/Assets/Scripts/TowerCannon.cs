using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TowerCannon : MonoBehaviour {

    public AudioSource lazer;
    public GameObject BulletPrefab;
    public Transform BulletSpawn;

    public float BulletVelocity = 25;
    public float timeAlive = 3;

	// Use this for initialization
	void Start () {

        lazer = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
            lazer.Play();
        }
	}

    private void Fire()
    {
         GameObject Bullet = Instantiate(BulletPrefab);

         Physics.IgnoreCollision(BulletSpawn.GetComponent<Collider>(), BulletSpawn.parent.GetComponent<Collider>());

         Bullet.transform.position = BulletSpawn.position;

         Vector3 rotation = Bullet.transform.rotation.eulerAngles;
         Bullet.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);
         Bullet.GetComponent<Rigidbody>().AddForce(BulletSpawn.forward * BulletVelocity, ForceMode.Impulse);

        StartCoroutine(DestroyBulletAfterTime(Bullet, timeAlive));
    }

    private IEnumerator DestroyBulletAfterTime(GameObject Bullet, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(Bullet);
    }

}
