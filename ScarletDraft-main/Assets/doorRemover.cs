using UnityEngine;

public class doorRemover : MonoBehaviour
    
{
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
       public GameObject door;

   //public Transform target;
    public float t;

    //public Transform sceptor;
    //public sceptormove sceptorMove;
    public AudioSource Correct;

    public void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.name == "Player" && !key1.activeSelf && !key2.activeSelf && !key3.activeSelf)
        {
            Correct.Play();
            //sceptorMove.sceptor();
            Destroy(gameObject);
            door.SetActive(false);


            
          // StartCoroutine(ExecuteAfterTime());
        }
    }

}