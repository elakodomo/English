using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlidTo : MonoBehaviour
{
    public GameObject suu;
    Slider sl;

    // Start is called before the first frame update
    void Start()
    {
        sl = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void hen()
    {
        Text tex = suu.GetComponent<Text>();
        tex.text = sl.value.ToString();
    }
}
