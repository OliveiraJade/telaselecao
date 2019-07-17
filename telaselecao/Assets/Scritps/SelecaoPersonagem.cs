using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelecaoPersonagem : MonoBehaviour
{
    public Sprite spriteSelecionado;

    public Sprite spriteNaoSelecionado;

    public Sprite personagemFoto;

    public int hp;

    public int xp;

    public int ataque;

    public bool selecionado;

    private void Start(){
        var spritePersonagem = transform.GetChild(3).GetComponent<Image>();
        spritePersonagem.sprite = personagemFoto;

        var sliderHP = transform.GetChild(0).GetComponentInChildren<Slider>();
        sliderHP.value = hp;

        var sliderXP = transform.GetChild(1).GetComponentInChildren<Slider>();
        sliderXP.value = xp;

        var sliderAtaque = transform.GetChild(2).GetComponentInChildren<Slider>();
        sliderAtaque.value = ataque;

        if (selecionado)
            AtivarBotao();
        else
            DesativarBotao();

    }

    public void AtivarBotao(){
        selecionado = true;
        GetComponent<Image>().sprite = spriteSelecionado;
    }

    public void DesativarBotao(){
        selecionado = false;
        GetComponent<Image>().sprite = spriteNaoSelecionado;
    }

    public void Clicou(){
        var listaBotoes = FindObjectsOfType<SelecaoPersonagem>();
        foreach(var botao in listaBotoes)
        {
            botao.DesativarBotao();
        }

        AtivarBotao();
    }
}
