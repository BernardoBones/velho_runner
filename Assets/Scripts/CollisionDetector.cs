using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerAnimation;
    [SerializeField] AudioSource collisionFX;
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject fadeOut;
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CollisionEnd());
    }

    IEnumerator CollisionEnd()
    {
        collisionFX.Play();
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        playerAnimation.GetComponent<Animator>().Play("Stumble Backwards");
        mainCamera.GetComponent<Animator>().Play("CollisionCamera");
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
    }
}
