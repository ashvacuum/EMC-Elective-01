using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elective : MonoBehaviour
{
    [SerializeField]private float _loadingScreenDelay = 1f;
    [SerializeField]private float _startupDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadSceneDelay(_loadingScreenDelay));
    }

    IEnumerator LoadSceneDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
