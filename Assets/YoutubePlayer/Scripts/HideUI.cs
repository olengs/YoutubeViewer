using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUI : MonoBehaviour
{

    public GameObject[] UIs;

    public float timetodisappear;
    public const float timelimit = 2f;

    Vector3 MouseLastCoord;

    bool ishidden;
    // Start is called before the first frame update
    void Start()
    {
        timetodisappear = 0f;
        ishidden = false;
        MouseLastCoord = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        timetodisappear += Time.deltaTime;
        if (timetodisappear > timelimit && ishidden == false)
        {
            ishidden = false;
            Hide();
        }

        if(Input.mousePosition != MouseLastCoord)
        {
            timetodisappear = 0f;
            MouseLastCoord = Input.mousePosition;
            ishidden = true;
            Hide();
        }

    }

    public void Hide()
    {
        if (!ishidden)
        {
            foreach (var obj in UIs)
            {
                obj.SetActive(false);
            }
            ishidden = true;
        }
        else
        {
            foreach (var obj in UIs)
            {
                obj.SetActive(true);
            }
            ishidden = false;
        }
    }
}
