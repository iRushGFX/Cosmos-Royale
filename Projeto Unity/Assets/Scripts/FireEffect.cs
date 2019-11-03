using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEffect : MonoBehaviour
{
    public float tamanhoMinimo;
    public float tamanhoNormal;
    public float tamanhoMaximo;
    public ParticleSystem fogo;

    private float valorAtual;
    private ParticleSystem.MainModule pMain;
    private Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        valorAtual = tamanhoNormal;
        fogo = GetComponent<ParticleSystem>();
        joystick = FindObjectOfType<Joystick>();

        pMain = fogo.main;
    }

    // Update is called once per frame
    void Update()
    {
        verificaAceleracao();
        pMain.startSize = new ParticleSystem.MinMaxCurve(valorAtual, valorAtual);
    }

    public void verificaAceleracao()
    {
        if (joystick.Vertical > 0 && valorAtual < tamanhoMaximo) //Aumentar Fogo
        {
            valorAtual++;
        }

        if (joystick.Vertical < 0 && valorAtual > tamanhoMinimo) //Diminuir Fogo
        {
            valorAtual--;
        }

        if (joystick.Vertical == 0 && valorAtual > tamanhoNormal)
        {
            valorAtual--;
        }
        else
        if(joystick.Vertical == 0 && valorAtual < tamanhoNormal)
        {
            valorAtual++;
        }
    }



}
