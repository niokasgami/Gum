using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gum2.Commands
{
    public enum TabLocation
    {
        RightBottom,
        RightTop,
        CenterTop,
        CenterBottom,
        Left
    }

    public class GuiCommands
    {
        TabControl RightBottomTabControl;
        TabControl RightTopTabControl;
        TabControl CenterTopTabControl;
        TabControl CenterBottomTabControl;
        TabControl LeftTabControl;

        public void Initialize(TabControl left, TabControl centerTop, TabControl centerBottom, TabControl rightTop, TabControl rightBottom)
        {
            this.RightTopTabControl = rightTop;
            this.RightBottomTabControl = rightBottom;
            this.CenterTopTabControl = centerTop;
            this.CenterBottomTabControl = centerBottom;
            this.LeftTabControl = left;
        }


        public void AddControl(UserControl control, string tabTitle, TabLocation tabLocation = TabLocation.CenterBottom)
        {
            CheckForInitialization();
            switch (tabLocation)
            {
                case TabLocation.RightBottom:
                    RightBottomTabControl.Items.Add(new TabItem { Header = tabTitle, Content = control });
                    break;
                case TabLocation.RightTop:
                    RightTopTabControl.Items.Add(new TabItem { Header = tabTitle, Content = control });
                    break;
                case TabLocation.CenterTop:
                    CenterTopTabControl.Items.Add(new TabItem { Header = tabTitle, Content = control });
                    break;
                case TabLocation.CenterBottom:
                    CenterBottomTabControl.Items.Add(new TabItem { Header = tabTitle, Content = control });
                    break;
                case TabLocation.Left:
                    LeftTabControl.Items.Add(new TabItem { Header = tabTitle, Content = control });
                    break;
            }
        }

        private void CheckForInitialization()
        {
            if (RightBottomTabControl == null)
            {
                throw new InvalidOperationException("Need to call Initialize first");
            }
        }


    }

}
