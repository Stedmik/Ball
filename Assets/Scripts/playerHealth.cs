using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            //����� bulletcollision 
            bulletCollision bc = collision.gameObject.GetComponent<bulletCollision>();
            //��������� canHit
            if(bc.canHit == true)
            {
                //������������� �����
                SceneManager.LoadScene("SampleScene");
            }
            
            
        }
    }
}
