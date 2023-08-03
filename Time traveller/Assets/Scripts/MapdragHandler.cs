using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MapdragHandler : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public RectTransform Canvas;
    public Transform Content;
    public GameObject Country;
    public GameObject Self;
    public Overcountry overcountry;
    public Mouserotate rotator;

    public void OnBeginDrag(PointerEventData eventData){
        rotator.enabled = false;
    }

    public void OnDrag(PointerEventData eventData){
        transform.SetParent(Canvas);
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData){
        if(overcountry.check){
            // Country.SetActive = true;
            Destroy(Self);
            Debug.Log("Its India");
        }
        else{
        transform.SetParent(Content);
        transform.localPosition = Vector3.zero;
        }
        rotator.enabled = true;
    }

}
