using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public static class Vaga {
   public static int vaga = 0;
}


public class SelecionarVaga : MonoBehaviour {
    public TextMeshProUGUI output;
    public void Selecionar(int selectedPos) {
        Vaga.vaga = selectedPos + 16;
        Debug.Log(selectedPos + " " + Vaga.vaga);
        SceneManager.LoadScene(0);
    }
}
