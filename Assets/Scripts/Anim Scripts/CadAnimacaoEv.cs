using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadAnimacaoEv : MonoBehaviour
{
    public UIController UI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AbrirCadernoGeral()
    {
        UI.telaInicialDoCaderno.SetActive(true);
        UI.telaRespostUnit.SetActive(false);
    }

    void AbrirCadernoUnitaria()
    {
        UI.telaRespostUnit.SetActive(true);
    }

    void AbrirCadernoPeticao()
    {
        UI.telaPeticao.SetActive(true);
        UI.telaRespostUnit.SetActive(false);
    }

    void FecharCadernoGeral()
    {
        UI.telaInicialDoCaderno.SetActive(true);
    }

}