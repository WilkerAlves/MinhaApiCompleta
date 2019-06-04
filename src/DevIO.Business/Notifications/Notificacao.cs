using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Notifications
{
    public class Notificacao
    {
        public string mensagem { get; }

        public Notificacao(string mensagem)
        {
            this.mensagem = mensagem;
        }

        
    }
}
