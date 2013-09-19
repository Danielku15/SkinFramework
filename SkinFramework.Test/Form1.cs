// This file is part of CoderLine SkinFramework.
//
// CoderLine SkinFramework is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// CoderLine SkinFramework is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with CoderLine SkinFramework.  If not, see <http://www.gnu.org/licenses/>.
//
// (C) 2010 Daniel Kuschny, (http://www.coderline.net)
using System;
using System.Windows.Forms;

namespace SkinFramework.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radSilver_CheckedChanged(object sender, EventArgs e)
        {
            DefaultSkin skin = DefaultSkin.Office2007Luna;
            if (sender == radLuna && radLuna.Checked)
                skin = DefaultSkin.Office2007Luna;
            else if (sender == radSilver && radSilver.Checked)
                skin = DefaultSkin.Office2007Silver;
            else if (sender == radObsidian && radObsidian.Checked)
                skin = DefaultSkin.Office2007Obsidian;

            skinningManager1.DefaultSkin = skin;
        }

    }
}
