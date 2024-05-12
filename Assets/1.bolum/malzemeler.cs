using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class malzemeler : MonoBehaviour
{
    [SerializeField] GameObject[] materials;
    [SerializeField] float secondSpawn = 0.2f;
    void Start()
    {
        StartCoroutine(MaterialSpawn());
        //Time.timeScale = 0f;
    }

    IEnumerator MaterialSpawn()
    {
        while (true)
        {
            var position = new Vector3(Random.Range(-5.8f, 5.8f), transform.position.y);
            GameObject gameObject = Instantiate(materials[Random.Range(0, materials.Length)],
            position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}