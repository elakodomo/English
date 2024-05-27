using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sai : MonoBehaviour
{
    public int kinds;
    public AudioClip[] c1;
    public static GameObject dem;
    bool mukiowari;
    float ff;
    AudioSource audioSource;
    Rigidbody Rig;
    Text tex;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        mukiowari = false;
        i = 0;
        dem = GameObject.Find("demeX");
        tex = dem.GetComponent<Text>();
        audioSource = GetComponent<AudioSource>();
        Rig = GetComponent<Rigidbody>();
        ff = 1 / Mathf.Sqrt(2f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Rig.IsSleeping())
        {
            if (mukiowari == false)
            {
                Muki();
            }
        }
    }
    void OnCollisionEnter(Collision col)
    {
        i = Random.Range(0, 4);
        audioSource.clip = c1[i];
        audioSource.Play();
       // Debug.Log(i);
       
    }

    public void Muki()
    {
        mukiowari = true;
        var k4 = transform.TransformDirection(Vector3.forward);
        var k2 = transform.TransformDirection(Vector3.right);
        var k1 = transform.TransformDirection(Vector3.up);
        var k3 = transform.TransformDirection(Vector3.back);
        var k5 = transform.TransformDirection(Vector3.left);
        var k6 = transform.TransformDirection(Vector3.down);
        if (kinds == 1)
        {
            if (k1.y > ff && k1.y <= 1f) tex.text = tex.text + "," + "1";
            if (k2.y > ff && k2.y <= 1f) tex.text = tex.text + "," + "2";
            if (k3.y > ff && k3.y <= 1f) tex.text = tex.text + "," + "3";
            if (k4.y > ff && k4.y <= 1f) tex.text = tex.text + "," + "4";
            if (k5.y > ff && k5.y <= 1f) tex.text = tex.text + "," + "5";
            if (k6.y > ff && k6.y <= 1f) tex.text = tex.text + "," + "6";
        }else
            if (kinds == 2)
        {
            if (k1.y > ff && k1.y <= 1f) tex.text = tex.text + "," + "4";
            if (k2.y > ff && k2.y <= 1f) tex.text = tex.text + "," + "6";
            if (k3.y > ff && k3.y <= 1f) tex.text = tex.text + "," + "5";
            if (k4.y > ff && k4.y <= 1f) tex.text = tex.text + "," + "5";
            if (k5.y > ff && k5.y <= 1f) tex.text = tex.text + "," + "6";
            if (k6.y > ff && k6.y <= 1f) tex.text = tex.text + "," + "4";
        }
        else
            if (kinds == 3)
        {
            tex.text = tex.text + "," + "1";


        }
        else
            if (kinds == 4)
        {
            if (k1.y > ff && k1.y <= 1f) tex.text = tex.text + "," + "4";
            if (k2.y > ff && k2.y <= 1f) tex.text = tex.text + "," + "8";
            if (k3.y > ff && k3.y <= 1f) tex.text = tex.text + "," + "5";
            if (k4.y > ff && k4.y <= 1f) tex.text = tex.text + "," + "7";
            if (k5.y > ff && k5.y <= 1f) tex.text = tex.text + "," + "6";
            if (k6.y > ff && k6.y <= 1f) tex.text = tex.text + "," + "9";
        }
        if(tex.text.Length == 2)
        {
            tex.text = tex.text.Remove(0, 1);
        }
        
    }
   
}
