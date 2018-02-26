using BLL.Interfaces;
using DAL.CRUDDAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BLL
{
    public class JogoBLL:PadraoBLL<Jogo>,IJogoBLL
    {
        private JogoDAL jogoDAL = new JogoDAL();

        public JogoBLL()
        {
            base.contextObj = jogoDAL;
        }
    }
}
