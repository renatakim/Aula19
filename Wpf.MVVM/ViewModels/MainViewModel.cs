using System.Windows;
using Caliburn.Micro;

namespace Wpf.MVVM.ViewModels
{
    public class MainViewModel : Screen
    {
        private string nomeCompleto;

        public string NomeCompleto
        {
            get
            {
                return nomeCompleto;
            }
            set
            {
                nomeCompleto = value;
                // Observa se o atributo/instância FirstName recebeu alguma atualização.
                base.NotifyOfPropertyChange(() => NomeCompleto);
            }
        }
    }
}
