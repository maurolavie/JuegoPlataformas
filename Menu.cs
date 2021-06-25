﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject flecha, lista;

    int indice = 0;

    // Start is called before the first frame update
    void Start() {
        Dibujar();
    }

    // Update is called once per frame
    void Update() {

        bool up = Input.GetKeyDown("up");
        bool down = Input.GetKeyDown("down");

        if (up) indice--;
        if (down) indice++;

        if (indice > lista.transform.childCount-1) indice = 0;
        else if (indice < 0) indice = lista.transform.childCount-1;

        if (up || down) Dibujar();

        if (Input.GetKeyDown("return")) Accion();

    }

    void Dibujar() {
        Transform opcion = lista.transform.GetChild(indice);
        flecha.transform.position = opcion.position;
    }

    void Accion() {
        Transform opcion = lista.transform.GetChild(indice);

       // if (opcion.gameObject.name = "Salir") {
       //     print("Cerrando juego...");
       //     Application.Quit();
       // } else {
       //      SceneManager.LoadScene(opcion.gameObject.name);
       // }
    }
}
