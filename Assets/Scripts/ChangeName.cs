using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeName : MonoBehaviour
{
    public TextMeshProUGUI NameText;
    string[] names = {"Jacob","Lori","Chris","Aunt Tina"};
    int i=0;

    private void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            if (i < names.Length){
                NameText.text = names[i];
                i++;

            }
        }



    }
}
