using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetCollision : MonoBehaviour
{
    public double lifeTime= 100;
    public double hitPoint = 20;
    public GameObject target;
    public GameObject player;
    public double score =0;
    public Text point;
    public Text winText;


private void Update()
{
    point.text = "Points: "+score;
    if(lifeTime<=0){
        DestroyImmediate(target);

        winText.text = "You Win!";
        DestroyImmediate(player);
    }
}
    private void OnParticleCollision(GameObject other)
    {
        lifeTime -= hitPoint;
        score += hitPoint;
        Debug.Log(lifeTime);
    }
}
