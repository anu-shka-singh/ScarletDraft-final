using UnityEngine;

public class doorRemover : MonoBehaviour
    
{
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    //public float t;
    public GameObject door;
    //public Transform target;
    //public Transform sceptor;
    //public sceptormove sceptorMove;
    //public AudioSource Correct;

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player") && !key1.activeSelf && !key2.activeSelf && !key3.activeSelf)
        {
            Debug.Log("Open");
            //Correct.Play();
            //sceptorMove.sceptor();
            Destroy(gameObject);
            Destroy(gameObject);
            Destroy(gameObject);
            door.SetActive(false);




            
          // StartCoroutine(ExecuteAfterTime());
        }
    }

}