using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDemo
{
    enum MenuPopUp {menuProject,menuUsers,menuGroups,menuNothing } ;
    class PopMenu
    {
        private MenuPopUp menuState;

        public ContextMenuStrip projectsMenu,usersMenu,groupsMenu;

        
        public PopMenu() 
        {
            menuState = MenuPopUp.menuNothing;
        }
       
        public  void setMenuState(MenuPopUp state)
        {
            menuState = state;
        }

        public MenuPopUp getMenuState()
        {
            return menuState;
        }


        
    }
}
