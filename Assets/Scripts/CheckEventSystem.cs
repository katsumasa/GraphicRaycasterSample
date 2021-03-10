using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CheckEventSystem : MonoBehaviour
{
    public EventSystem mEventSystem;
    PointerEventData mPointerEventData;
    List<RaycastResult> mRaycastResults;


    // Start is called before the first frame update
    void Start()
    {
        mPointerEventData = new PointerEventData(mEventSystem);
        mRaycastResults = new List<RaycastResult>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mRaycastResults.Clear();
            mPointerEventData.position = Input.mousePosition;
            mEventSystem.RaycastAll(mPointerEventData, mRaycastResults);
            foreach(var raycastResult in mRaycastResults)
            {
                Debug.Log(raycastResult);
            }
        }
    }
}
