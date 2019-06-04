using DevIO.Business.Notifications;
using System.Collections.Generic;

namespace DevIO.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificações();
        void Handle(Notificacao notificacao);
    }
}
