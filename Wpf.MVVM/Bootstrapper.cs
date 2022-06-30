using System.Windows;
using Caliburn.Micro;
using Wpf.MVVM.ViewModels;

namespace Wpf.MVVM
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            // Inicializa o projeto
            base.Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // Define qual será o Controlador padrão
            // Nota: O controlador MainViewModel ainda não foi criado nessa etapa.
            base.DisplayRootViewFor<MainViewModel>();
        }
    }
}
