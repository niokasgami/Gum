using Avalonia.Controls;
using Gum2.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gum2.Commands
{
    public class GumCommands : Singleton<GumCommands>
    {
        public GuiCommands GuiCommands
        {
            get;
            private set;
        }


        public void Initialize(TabControl left, TabControl centerTop, TabControl centerBottom, TabControl rightTop, TabControl rightBottom)
        {
            GuiCommands = new GuiCommands();
            GuiCommands.Initialize(left, centerTop, centerBottom, rightTop, rightBottom);
            //FileCommands.Initialize(mainWindow);
        }
    }
}
