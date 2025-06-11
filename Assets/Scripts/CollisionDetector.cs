using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerAnimation;
    [SerializeField] AudioSource collisionFX;
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject fadeOut;
    [SerializeField] PostGameUI postGameUI;
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

        // Aqui mostramos a tela de pós-jogo antes de mudar de cena
        postGameUI.ShowPostGame();

        // Se você quiser pausar o jogo para o jogador ver a tela:
        // Time.timeScale = 0f;
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}
