using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public SceneControl SC;
    public Image Image;
    public Animator cadAnim;

    [Header("TELAS INICIAIS")] 
    public List<GameObject> telasInicio;
    public GameObject telaAbertura;

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
    public GameObject telaDeConfirmacao;
    public GameObject telaPC;
    public GameObject telaCaso;
    public GameObject botoesTelaCaso;
    public GameObject botaoFinalizar;

    [Header("TELAS DE FINAL")]
    public GameObject telaFinal;

    [Header("VARIAVEIS")]
    public int contadorTelaInicio = 0;

    [Header("IMAGENS DO CADERNO")]
    public GameObject CadernoGeneralImagem;

    [Header("ICONES")]
    public GameObject IconePC;

    [Header("PISCAR TELA")]
    public GameObject piscarTela;

    public void Start()
    {
        //telasInicio[contadorTelaInicio].SetActive(true); 
    }

    public void AvancarTelaInicio()
    {
        if (contadorTelaInicio == 1) //Ta igual a 1 para pular a tela de tutorial durante o primeiro prototipo, vai voltar a ser == 2 quando o tutorial estiver pronto
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
                CadernoGeneralImagem.SetActive(true);
                telaComputador.SetActive(false);
                
                break;
            case 1:
                telaJogo.SetActive(false);
                telaComputador.SetActive(true);
                break;
            case 2:
                telaInicialDoCaderno.SetActive(false);
                IconePC.SetActive(false);
                cadAnim.SetInteger("Anim", 2);
                //telaRespostUnit.SetActive(true);
                break;
            case 3:
                telaInicialDoCaderno.SetActive(false);
                IconePC.SetActive(false);
                cadAnim.SetInteger("Anim", 4);
                //telaPeticao.SetActive(true);
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
                telaPeticaoOrdinaria.SetActive(false);
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
            case 14:
                telasInicio[1].SetActive(false);
                telaComputador.SetActive(true);
                break;
            case 15:
                //telaInicialDoCaderno.SetActive(true);
                CadernoGeneralImagem.SetActive(true);
                telaInicialDoCaderno.SetActive(true);
                telaRespostUnit.SetActive(false);
                //cadAnim.SetInteger("Anim", 1);
                telaPC.SetActive(false);
                break;
            case 16:
                telaComputador.SetActive(false);
                telaPC.SetActive(false);
                telaFinal.SetActive(true);
                break;
            case 17:
                CadernoGeneralImagem.SetActive(true);
                telaInicialDoCaderno.SetActive(true);
                telaRespostUnit.SetActive(false);
                telaRespArt.SetActive(false);
                telaRespArtPEspecial.SetActive(false);
                TelaRespArtPOrdinaria.SetActive(false);
                telaRespSumula.SetActive(false);
                telaRespSumulaPEspecial.SetActive(false);
                TelaRespSumulaPOrdinaria.SetActive(false);
                telaPeticao.SetActive(false);
                telaPeticaoEspecial.SetActive(false);
                telaPeticaoOrdinaria.SetActive(false);
                telaFundEspecial.SetActive(false);
                TelaFundOrdinaria.SetActive(false);
                break;
        }
    }

    public void VoltarTelas(int x)
    {
        switch (x)
        {
            case 5: //Sair da tela inicial do caderno para tela de jogo
                //telaJogo.SetActive(true);
                //cadAnim.SetInteger("Anim", 6);
                telaInicialDoCaderno.SetActive(false);
                CadernoGeneralImagem.SetActive(false);
                break;
            case 6: //Sair da tela de resposta unitaria para tela inicial do caderno
                //telaInicialDoCaderno.SetActive(true);
                telaRespostUnit.SetActive(false);
                IconePC.SetActive(false);
                cadAnim.SetInteger("Anim", 5);
                CadernoGeneralImagem.SetActive(true);
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
                //telaInicialDoCaderno.SetActive(true);
                telaPeticao.SetActive(false);
                IconePC.SetActive(false);
                cadAnim.SetInteger("Anim", 5);
                CadernoGeneralImagem.SetActive(true);
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
                telaPeticao.SetActive(true);
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

    public void telaDeConfirmação() //Ativa a tela de confirmação de resposta
    {
        telaComputador.SetActive(false);
        telaDeConfirmacao.SetActive(true);
    }

    public void ConfirmarSim() //Caso o candidato escolha confirmar a resposta, o sistema desativa aquela questão
    {
        telaDeConfirmacao.SetActive(false);
        telaComputador.SetActive(true);
        //SC.fecharQuestão();
    }

    public void ConfirmarNao() //Caso o candidato escolha nao confirmar a resposta, o sistema volta pra tela do computador
    {
        telaDeConfirmacao.SetActive(false);
        telaComputador.SetActive(true);
    }
    public void SairCaderno(GameObject tela)
    {
        //Pega a tela atual pelo inspector e desativa ela, logo depois ativa a tela de computador
        telaComputador.SetActive(true);
        tela.SetActive(false);
        CadernoGeneralImagem.SetActive(false);
    }

    public void ReiniciarCena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void FecharTelaCaso()
    {
        telaCaso.SetActive(false);
        botoesTelaCaso.SetActive(false);
    }

    public void BotaoHotbar()
    {
        if (telaCaso.active == true)
        {
            telaCaso.SetActive(false);
            botoesTelaCaso.SetActive(false);
        }
        else
        {
            telaCaso.SetActive(true);
        }
    }
}
