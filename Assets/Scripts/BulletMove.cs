using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public static BulletMove insance;
    public Vector3 targePosition;

    private void Awake()
    {
        insance = this;
    }
    private void Start()
    {
        LeanTween.move(this.gameObject, targePosition, 1f);
    }
}