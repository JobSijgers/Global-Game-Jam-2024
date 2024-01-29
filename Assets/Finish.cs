using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Transform EndPoint;
    public Transform bomb;
    public float time;
    public AudioSource source;

    private IEnumerator MoveBomb()
    {
        float t = 0;
        Vector3 startPos = bomb.position;
        while (t < 1)
        {
            t += Time.deltaTime / time;
            bomb.transform.position = Vector3.Lerp(startPos, EndPoint.position, t);
            yield return null;
        }
        source.Play();
        yield return new WaitForSeconds(source.clip.length);
        Application.Quit();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(MoveBomb());
        }
    }
}
