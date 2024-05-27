using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class saikoro : MonoBehaviour
{
    public static List<int> list;
    public Slider s_kaz;
    public Slider s_type;
    public Slider s_size;
    public Toggle c_deme;
    public int kaz;
    public int type;
    public int size;
    public GameObject[] kao;
    public GameObject dem;
    private GameObject oy;
    private bool saiok;
    Text tex;

    // Start is called before the first frame update
    void Start()
    {
        list = new List<int>();
        list.Add(4);
        tex = dem.GetComponent<Text>();
        saiok = true;
        kaz = 3;
        type = 1;
        size = 1;
        oy = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    { 
        if (saiok == true)
        {
            kaz = (int)s_kaz.value;
            type = (int)s_type.value;
            size = (int)s_size.value;
            oy.transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine(Saikoro(kaz));

            }
        }
        if(tex.text.Length == kaz * 2 - 1)
        {
            Debug.Log("dddddddddddddddddddddddddd");
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

    }

    IEnumerator Saikoro(int n)
    {
        saiok = false;
        int a = 0;
       // oy.transform.Rotate(0, Random.Range(0, 360), 0);
        while (a < n)
        {
            GameObject sui = Instantiate(kao[type-1], transform.position, Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            sui.transform.localScale = new Vector3(size * 0.2f * 0.85f, size * 0.2f * 0.85f, size * 0.2f * 0.85f);
            Rigidbody bd = sui.GetComponent<Rigidbody>();
            bd.velocity = transform.forward.normalized * 10f;
            bd.AddTorque(new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)), ForceMode.Acceleration);
            yield return new WaitForSeconds(0.15f);
            ++a;
        }
        saiok = true;
    }

    public void Deme()
    {
        //dem.SetActive(c_deme.isOn);
        if(c_deme.isOn == true)
        {
            dem.GetComponent<Text>().enabled = true;
        }else
        {
            dem.GetComponent<Text>().enabled = false;
        }
           

    }
}
