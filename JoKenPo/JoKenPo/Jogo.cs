﻿using System;
using System.Drawing;


namespace JoKenPo
{
    internal class Jogo
    {
        public enum resultado
        { 
            Ganhar, Perder,Empatar
        }

        public static Image[] imagens =
        {
            Image.FromFile("Pedra.png"),
            Image.FromFile("Papel.png"),
            Image.FromFile("Tesoura.png"),
            Image.FromFile("Empatar.png"),
            Image.FromFile("Ganhar.png"),
            Image.FromFile("Perder.png")
        };

        public Image img_maquina { get; private set; }
        public Image img_jogador {  get; private set; }

        public resultado Jogar (int jogador)
        {
            int pc = JogadaPC();
            img_jogador = imagens[jogador];
            img_maquina = imagens[pc];

            if (jogador == pc)
            {
                return resultado.Empatar;
            }
            else if ((jogador == 0 && pc == 1) || (jogador == 1 && pc == 2) || (jogador == 2 && pc == 0))

            {
                return resultado.Perder;

            }
            else
            {
                return resultado.Ganhar;
            }
        } 

        private int JogadaPC()
        {
            int mil = DateTime.Now.Millisecond;

            if (mil < 333)
            {
                return 0;
            }else if (mil >=333 && mil < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
