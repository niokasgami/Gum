using Gum2.Mvvm;
using MonoGameRenderer;

namespace Gum2.Plugins.MonoGamePlugin.ViewModels
{
    public class MonoGameViewModel : ViewModel
    {
        public RendererGame Game
        {
            get => Get<RendererGame>();
            set => Set(value);
        }

        public MonoGameViewModel()
        {
            Game = new RendererGame();
        }
    }
}
