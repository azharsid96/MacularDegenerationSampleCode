using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndSceneUI : MonoBehaviour
{
    public Text endResult;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject newGO = new GameObject("myTextGO");
        //newGO.transform.SetParent(this.transform);

        //Text myText = newGO.AddComponent<Text>();
        //myText.text = "Ta-dah!";

        //Scene scene = SceneManager.GetSceneByName("SampleScene");
        //SceneManager.LoadScene(scene.name);

        bool result = Checkout.finalResult;

        endResult = GetComponent<Text>();

        endResult.text = result.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
