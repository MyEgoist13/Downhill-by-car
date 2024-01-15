using UnityEngine;

public class TriggerSystem : MonoBehaviour
{
    private GameRules gr;
    public int TriggerType = 1;

    private void Start()
    {
        gr = GameObject.Find("GameController").GetComponent<GameRules>();
        if(gr == null)
        {
            Debug.Log("gr");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(TriggerType == 1)
        {
            if(other.gameObject.tag == "CarCollider"){
                gr.GameOver();
            }
        } else if(TriggerType == 2)
        {
            if(other.gameObject.tag == "CarCollider"){
                gr.Win();
            }
        }
    }
}