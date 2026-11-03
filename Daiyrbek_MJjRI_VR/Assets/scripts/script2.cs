using UnityEngine;

public class script2 : MonoBehaviour
{
    public script1 script_1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("GG");

        if(script_1 !=null)
        {
            print(script_1.GetTotalInfo());
        }
    }
}   
