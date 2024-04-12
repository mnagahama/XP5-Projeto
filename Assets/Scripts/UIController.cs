using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [Header("TELAS INICIAIS")] 
    public List<GameObject> telasInicio;

    [Header("TELAS DO CADERNO")] 
    public GameObject telaInicialDoCaderno;
    
    [Header("TELAS DE RESPOSTA UNITARIA")]
    public GameObject telaRespostUnit;
    public GameObject telaRespArt;
    public GameObject telaRespSumula;
    
    [Header("TELAS DE PECA PROCESSUAL")]
    public GameObject telaPeticao;
    
    [Header("TELAS DE PETICAO ESPECIAL")]
    public GameObject telaPeticaoEspecial;
    public GameObject telaFundEspecial;
    public GameObject telaRespArtPEspecial;
    public GameObject telaRespSumulaPEspecial;
    
    [Header("TELAS DE PETICAO ORDINARIA")]
    public GameObject telaPeticaoOrdinaria;
    public GameObject TelaFundOrdinaria;
    public GameObject TelaRespArtPOrdinaria;
    public GameObject TelaRespSumulaPOrdinaria;


    [Header("TELA DO JOGO")]
    public GameObject telaJogo;

    [Header("TELAS DO COMPUTADOR")] 
    public GameObject telaComputador;

    private int contadorTelaInicio = 0;

    public void Start()
    {
        telasInicio[contadorTelaInicio].SetActive(true); 
    }

    public void AvancarTelaInicio()
    {
        if (contadorTelaInicio == 2)
        {
            telasInicio[contadorTelaInicio].SetActive(false);
            telaJogo.SetActive(true);
        }
        else
        {
            telasInicio[contadorTelaInicio].SetActive(false);
            contadorTelaInicio++;
            telasInicio[contadorTelaInicio].SetActive(true);
        }
    }

    public void JogoTela(int x)
    {
        switch (x)
        {
            case 0:
                telaJogo.SetActive(false);
                telaInicialDoCaderno.SetActive(true);
                break;
            case 1:
                telaJogo.SetActive(false);
                telaComputador.SetActive(true);
                break;
            case 2:
                telaInicialDoCaderno.SetActive(false);
                telaRespostUnit.SetActive(true);
                break;
            case 3:
                telaInicialDoCaderno.SetActive(false);
                telaPeticao.SetActive(true);
                break;
            case 4:
                telaRespostUnit.SetActive(false);
                telaRespArt.SetActive(true);
                break;
            case 5:
                telaRespostUnit.SetActive(false);
                telaRespSumula.SetActive(true);
                break;
            case 6:
                telaPeticao.SetActive(false);
                telaPeticaoEspecial.SetActive(true);
                break;
            case 7:
                telaPeticao.SetActive(false);
                telaPeticaoOrdinaria.SetActive(true);
                break;
            case 8:
                telaPeticaoEspecial.SetActive(false);
                telaFundEspecial.SetActive(true);
                break;
            case 9:
                telaFundEspecial.SetActive(false);
                telaRespArtPEspecial.SetActive(true);
                break;
            case 10:
                telaFundEspecial.SetActive(false);
                telaRespSumulaPEspecial.SetActive(true);
                break;
            case 11:
                telaPeticaoOrdinaria.SetActive(false);
                TelaFundOrdinaria.SetActive(true);
                break;
            case 12:
                TelaFundOrdinaria.SetActive(false);
                TelaRespArtPOrdinaria.SetActive(true);
                break;
            case 13:
                TelaFundOrdinaria.SetActive(false);
                TelaRespSumulaPOrdinaria.SetActive(true);
                break;
        }
    }

    public void VoltarTelas(int x)
    {
        switch (x)
        {
            case 5: //Sair da tela inicial do caderno para tela de jogo
                telaJogo.SetActive(true);
                telaInicialDoCaderno.SetActive(false);
                break;
            case 6: //Sair da tela de resposta unitaria para tela inicial do caderno
                telaInicialDoCaderno.SetActive(true);
                telaRespostUnit.SetActive(false);
                break;
            case 7: //Sair da tela de resposta em artigo para tela de resposta unitaria
                telaRespostUnit.SetActive(true);
                telaRespArt.SetActive(false);
                break;
            case 8: //Sair da tela de resposta em sumula para tela de resposta unitaria
                telaRespostUnit.SetActive(true);
                telaRespSumula.SetActive(false);
                break;
            case 9: //Sair da tela de peticao para tela inicial do caderno
                telaInicialDoCaderno.SetActive(true);
                telaPeticao.SetActive(false);
                break;
            case 10: //Sair da tela de peticao especial para tela de peticao
                telaPeticao.SetActive(true);
                telaPeticaoEspecial.SetActive(false);
                break;
            case 11: //Sair da tela de Fundamentacao em Peticao Especial para tela de peticao especial
                telaPeticaoEspecial.SetActive(true);
                telaFundEspecial.SetActive(false);
                break;
            case 12: //Sair da tela de resposta em artigo para tela de fundamentacao em peticao especial
                telaFundEspecial.SetActive(true);
                telaRespArtPEspecial.SetActive(false);
                break;
            case 13: //Sair da tela de resposta em sumula para tela de fundamentacao em peticao especial
                telaFundEspecial.SetActive(true);
                telaRespSumulaPEspecial.SetActive(false);
                break;
            case 14: //Sair da tela de peticao ordinaria para tela de peticao
                telaPeticao.SetActive(true);
                telaPeticaoOrdinaria.SetActive(false);
                break;
            case 15: //Sair da tela de Fundamentacao em Peticao Ordinaria para tela de peticao ordinaria
                telaPeticaoOrdinaria.SetActive(true);
                TelaFundOrdinaria.SetActive(false);
                break;
            case 16: //Sair da tela de resposta em artigo para tela de fundamentacao em peticao ordinaria
                TelaFundOrdinaria.SetActive(true);
                TelaRespArtPOrdinaria.SetActive(false);
                break;
            case 17: //Sair da tela de resposta em sumula para tela de fundamentacao em peticao ordinaria
                TelaFundOrdinaria.SetActive(true);
                TelaRespSumulaPOrdinaria.SetActive(false);
                break;
            case 18: //Sair da tela do computador para tela de jogo
                telaJogo.SetActive(true);
                telaComputador.SetActive(false);
                break;
        }
    }

    public void SairCaderno(GameObject tela)
    {
        //Pega a tela atual pelo inspector e desativa ela, logo depois ativa a tela de jogo
        telaJogo.SetActive(true);
        tela.SetActive(false);
    }
}