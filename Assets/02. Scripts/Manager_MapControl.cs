using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_MapControl : MonoBehaviour {

    public GameObject pattern1;
    public GameObject StartGuide;
    public GameObject EndGuide;

    private int runDur = 2;

	void Start () {

        StartCoroutine(Run());
    }

    IEnumerator Run()
    {
        pattern1.transform.DOMove(EndGuide.transform.position, runDur);
        yield return new WaitForSeconds(runDur);
        pattern1.SetActive(false);
        pattern1.transform.position = StartGuide.transform.position;
        yield return new WaitForSeconds(1);
        pattern1.SetActive(true);
    }
}
