﻿using UnityEngine;
using System.Collections;

public class LifebarBehaviour : MonoBehaviour {
    CharacterBehaviour cb;
    Transform barra;
    Vector3 barraSize;
    Vector3 targetSize;
    float lifeRatio;

    // Use this for initialization
    void Awake() {
        Transform pai = transform.parent;
        cb = pai.GetComponent<CharacterBehaviour>();
        barra = transform.Find("Bar");
        barraSize = barra.localScale;
        targetSize = barraSize;
        targetSize.x = 0.0f;
    }

    void Start() {
        
    }
    
    // Update is called once per frame
    void Update() {
        lifeRatio = cb.Lifebar * 0.001f;
        barra.localScale = Vector3.Lerp(targetSize, barraSize, lifeRatio);
        barra.renderer.material.color = Color.Lerp(Color.red, Color.green, lifeRatio);
    }
}
