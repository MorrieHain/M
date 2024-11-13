using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenetest : MonoBehaviour
{
    float timetester = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log(scene.name);
    }

    // Update is called once per frame
    void Update()
    {
        timetester += Time.deltaTime;
        if (timetester > 5)
        {
            SceneManager.LoadScene("testscene", LoadSceneMode.Additive);
            timetester = 0;
        }
    }
}
