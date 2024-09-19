using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POINT1 : MonoBehaviour
{
    [SerializeField] private int points;
    [SerializeField] private GameObject UI;

    public void Add(int point){
        this.points+=point;
    }

    void FixedUpdate(){
        UI.gameObject.GetComponent<TextMesh>().text = this.points.ToString();
    }
}
