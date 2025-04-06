using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchButton : MonoBehaviour {
    void Update()    {
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase) {
                case TouchPhase.Began:
                    Debug.Log("Begun ");
                    break;
                 case TouchPhase.Ended:
                    // Touch

                    RaycastHit hit;
                    Ray ray = Camera.main.ScreenPointToRay(touch.position);
                    bool rayDidHit = Physics.Raycast(ray, out hit);//, m_LayerMask);
                    if (rayDidHit) {
                        Debug.Log("hit");
                        if(hit.transform.gameObject.tag == "Button") {
                            Debug.Log("Button");
                            //hit.transform.position += new Vector3(0.2f, 0, 0.2f); 
                            SceneManager.LoadScene(1);
                        }
                        //var obj = hit.transform.gameObject.GetComponent<UpgradeTower>();
                        //Debug.Log(obj);
                        //obj?.onTowerClick();
                    }

                    Debug.Log("Ending ");
                    break;
            }
        }

    }
}
