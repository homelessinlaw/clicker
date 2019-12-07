using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Damager : MonoBehaviour, IPointerDownHandler
{
    Camera mainCamera;
    Ray ray;
    RaycastHit hit;
    string hitedName;
    HealthforTower hpBlock;

    public float damage = 90;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        hpBlock = GetComponent<HealthforTower>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //     ray = mainCamera.ScreenPointToRay(Input.mous);
        //     if(Physics.Raycast(ray,out hit, 100))
        //    { 
        //        hitedName = hit.collider.name;
        //        if (hitedName != "Tower")
        //        {
        //            hpBlock = GameObject.Find(hitedName).GetComponent<HealthforTower>();
        //            hpBlock.health -= damage;
        //            //Destroy(GameObject.Find(hitedName));
        //        }
        //    }
        //}
    }
    public void OnPointerDown (PointerEventData eventData)
    {
        hpBlock.health -= damage;

    }
}
