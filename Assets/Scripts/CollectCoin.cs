using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        UIInfo.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}
