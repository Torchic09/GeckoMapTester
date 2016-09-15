using System;
using System.Windows.Forms;

namespace GeckoMapTester
{
    public partial class Form1 : Form
    {

        public TCPGecko Gecko;
        bool hasExtendedHandlerInstalled = false;

        uint diffforhandler = 0x9000;

        public Form1()
        {
            InitializeComponent();
            NameWrapper[] maps = {
                new NameWrapper("<no change>", "<no change>"),
                new NameWrapper("Urchin Underpass","Fld_Crank00_Vss"),
                new NameWrapper("Walleye Warehouse","Fld_Warehouse00_Vss"),
                new NameWrapper("Saltspray Rig","Fld_SeaPlant00_Vss"),
                new NameWrapper("Arowana Mall","Fld_UpDown00_Vss"),
                new NameWrapper("Blackbelly Skatepark","Fld_SkatePark00_Vss"),
                new NameWrapper("Camp Triggerfish","Fld_Athletic00_Vss"),
                new NameWrapper("Port Mackerel","Fld_Amida00_Vss"),
                new NameWrapper("Kelp Dome","Fld_Maze00_Vss"),
                new NameWrapper("Moray Towers","Fld_Tuzura00_Vss"),
                new NameWrapper("Bluefin Depot","Fld_Ruins00_Vss"),
                new NameWrapper("Shooting Range","Fld_ShootingRange_Shr"),
                new NameWrapper("Ancho-V Games","Fld_Office00_Vss"),
                new NameWrapper("Piranha Pit","Fld_Quarry00_Vss"),
                new NameWrapper("Flounder Heights","Fld_Jyoheki00_Vss"),
                new NameWrapper("Museum d'Alfonsino","Fld_Pivot00_Vss"),
                new NameWrapper("Mahi-Mahi Resort","Fld_Hiagari00_Vss"),
                new NameWrapper("Hammerhead Bridge","Fld_Kaisou00_Vss"),
                new NameWrapper("Urchin Underpass (Dojo)","Fld_Crank00_Dul"),
                new NameWrapper("Walleye Warehouse (Dojo)","Fld_Warehouse00_Dul"),
                new NameWrapper("Saltspray Rig (Dojo)","Fld_SeaPlant00_Dul"),
                new NameWrapper("Arowana Mall (Dojo)","Fld_UpDown00_Dul"),
                new NameWrapper("Blackbelly Skatepark (Dojo)","Fld_SkatePark00_Dul"),
                new NameWrapper("Tutorial 1","Fld_Tutorial00_Ttr"),
                new NameWrapper("Tutorial 2","Fld_TutorialShow00_Ttr"),
                new NameWrapper("Octotrooper Hideout","Fld_EasyHide00_Msn"),
                new NameWrapper("Lair of the Octoballs","Fld_EasyClimb00_Msn"),
                new NameWrapper("Rise of the Octocopters","Fld_EasyJump00_Msn"),
                new NameWrapper("Gusher Gauntlet","Fld_Geyser00_Msn"),
                new NameWrapper("Floating Sponge Garden","Fld_Sponge00_Msn"),
                new NameWrapper("Propeller Lift Fortress","Fld_Propeller00_Msn"),
                new NameWrapper("Spreader Splatfest","Fld_PaintingLift00_Msn"),
                new NameWrapper("Octoling Invasion","Fld_RvlMaze00_Msn"),
                new NameWrapper("Unidentified Flying Object","Fld_OctZero00_Msn"),
                new NameWrapper("Inkrail Skyscape","Fld_InkRail00_Msn"),
                new NameWrapper("Inkvisible Avenues","Fld_Invisible00_Msn"),
                new NameWrapper("Flooder Junkyard","Fld_Dozer00_Msn"),
                new NameWrapper("Shifting Splatforms","Fld_SlideLift00_Msn"),
                new NameWrapper("Octoling Assault","Fld_RvlSkatePark00_Msn"),
                new NameWrapper("Undeniable Flying Object","Fld_OctRuins00_Msn"),
                new NameWrapper("Propeller Lift Playground","Fld_Propeller01_Msn"),
                new NameWrapper("Octosniper Ramparts","Fld_Charge00_Msn"),
                new NameWrapper("Spinning Spreaders","Fld_PaintingLift01_Msn"),
                new NameWrapper("Tumbling Splatforms","Fld_TurnLift00_Msn"),
                new NameWrapper("Octoling Uprising","Fld_RvlRuins00_Msn"),
                new NameWrapper("Unwelcome Flying Object","Fld_OctCrank00_Msn"),
                new NameWrapper("Switch Box Shake-Up","Fld_Trance00_Msn"),
                new NameWrapper("Spongy Observatory","Fld_Sponge01_Msn"),
                new NameWrapper("Pinwheel Power Plant","Fld_Fusya00_Msn"),
                new NameWrapper("Far-Flung Flooders","Fld_Dozer01_Msn"),
                new NameWrapper("Octoling Onslaught","Fld_RvlSeaPlant00_Msn"),
                new NameWrapper("Unavoidable Flying Object","Fld_OctSkatePark00_Msn"),
                new NameWrapper("Staff Roll","Fld_StaffRoll00_Stf"),
                new NameWrapper("Boss 1","Fld_BossStampKing_Bos_Msn"),
                new NameWrapper("Boss 2","Fld_BossCylinderKing_Bos_Msn"),
                new NameWrapper("Boss 3","Fld_BossBallKing_Bos_Msn"),
                new NameWrapper("Boss 4","Fld_BossMouthKing_Bos_Msn"),
                new NameWrapper("Boss 5","Fld_BossRailKing_Bos_Msn"),
            };
            NameCBox.DataSource = maps;
            NameCBox.SelectedIndex = 0;

            NameWrapper[] sceneenvsets = {
                new NameWrapper("<no change>", "<no change>"),
                new NameWrapper("Day 1","MisSkyDay01,Common"),
                new NameWrapper("Twilight 1","MisSkyTwilight,Common"),
                new NameWrapper("Day 2","MisSkyDay,Common"),
                new NameWrapper("Green","MisSkyGreen,Common"),
                new NameWrapper("Sunset","MisSkySunset,Common"),
                new NameWrapper("Night","MisSkyNight,Common"),
                new NameWrapper("Galaxy Monitors","MisSkyGalaxy,Common"),
                new NameWrapper("Gray","MisSkyGray,Common"),
                new NameWrapper("Twilight 2","MisTwilight,Common"),
                new NameWrapper("Dozer","MisDozer,Common"),
                new NameWrapper("Battle","MisBattle"),
                new NameWrapper("Broken Monitors","MisMonitorBroken,Common"),
                new NameWrapper("Boss 1","Stampking,Common"),
                new NameWrapper("Boss 2","CylinderKing,Common"),
                new NameWrapper("Boss 3","BallKing,Common"),
                new NameWrapper("Boss 4","Mouthking,Common"),
                new NameWrapper("Boss 5","RailKing,Common"),
            };
            seCBox.DataSource = sceneenvsets;
            seCBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gecko = new TCPGecko(IPBox.Text, 7331);
            try
            {
                Gecko.Connect();
            }
            catch (ETCPGeckoException exc)
            {
                MessageBox.Show("Connection to the TCPGecko failed: \n\n" + exc.Message + "\n\nCheck your network connection/firewall.", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            Gecko.poke(0x10014cfc, 0x00000001);
            System.Threading.Thread.Sleep(1000);
            if (Gecko.peek(0x10014D00) == 0x00000000)
            {
                /*
                MessageBox.Show("register: " + String.Format("{0:x2}", Gecko.peek(0x10014D00)), "info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                MessageBox.Show("✘", "fail", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                */
                hasExtendedHandlerInstalled = false;
            }
            else
            {
                /*
                MessageBox.Show("register: " + String.Format("{0:x2}", Gecko.peek(0x10014D00)), "info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                MessageBox.Show("✓", "good", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                */
                hasExtendedHandlerInstalled = true;
            }
            Gecko.poke(0x10014cfc, 0x00000000);

            Gecko.poke(0x10613C2C, 0x5F476573);
            Gecko.poke(0x10613C3C, 0x756C6174);
            Gecko.poke(0x10613C4C, 0x68650000);
            Gecko.poke(0x10613C88, 0x63650000);

            groupBox2.Enabled = true;
            DisconnButton.Enabled = true;
            ConnectButton.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gecko.Disconnect();
            groupBox2.Enabled = false;
            DisconnButton.Enabled = false;
            ConnectButton.Enabled = true;
        }

        private void PokeAllMaps(string NewMapName)
        {
            if (VerCBox.Text == "2.7.0")
            {
                if (hasExtendedHandlerInstalled)
                {
                    if (OnlineCheckBox.Checked && NewMapName != "<no change>")
                    {
                        // Main maps
                        pokeThem(0x12AEDE8C + diffforhandler, NewMapName, 16);

                        // other maps
                        pokeThem(0x12B4BA3C + diffforhandler, NewMapName, 12);

                        // redundant maps
                        pokeThem(0x12B4D89C + diffforhandler, NewMapName, 9);

                    }
                    if (DojoCheckBox.Checked && NewMapName != "<no change>")
                    {
                        // Dojo
                        pokeThem(0x12B533BC + diffforhandler, NewMapName, 5);
                    }
                }
                else
                {
                    if (OnlineCheckBox.Checked && NewMapName != "<no change>")
                    {
                        // Main maps
                        pokeThem(0x12AEDE8C, NewMapName, 16);

                        // other maps
                        pokeThem(0x12B4BA3C, NewMapName, 12);

                        // redundant maps
                        pokeThem(0x12B4D89C, NewMapName, 9);
                    }
                    if (DojoCheckBox.Checked && NewMapName != "<no change>")
                    {
                        // Dojo
                        pokeThem(0x12B533BC, NewMapName, 5);
                    }
                }
            }
            if (VerCBox.Text == "2.8.0")
            {
                if (hasExtendedHandlerInstalled)
                {
                    if (OnlineCheckBox.Checked && NewMapName != "<no change>")
                    {
                        // Main maps
                        pokeThem(0x12AEDE8C + diffforhandler, NewMapName, 16);

                        // other maps
                        pokeThem(0x12B4BA3C + diffforhandler, NewMapName, 12);

                        // redundant maps
                        pokeThem(0x12B4D89C + diffforhandler, NewMapName, 9);
                    }
                    if (DojoCheckBox.Checked && NewMapName != "<no change>")
                    {
                        // Dojo
                        pokeThem(0x12B533BC + diffforhandler, NewMapName, 5);
                    }
                }
                else
                {
                    if (OnlineCheckBox.Checked && NewMapName != "<no change>")
                    {
                        // Main maps
                        pokeThem(0x12AEDE8C, NewMapName, 16);

                        // other maps
                        pokeThem(0x12B4BA3C, NewMapName, 12);

                        // redundant maps
                        pokeThem(0x12B4D89C, NewMapName, 9);
                    }
                    if (DojoCheckBox.Checked && NewMapName != "<no change>")
                    {
                        // Dojo
                        pokeThem(0x12B533BC, NewMapName, 5);
                    }
                }
            }

            if (VerCBox.Text == "2.10.0" || VerCBox.Text == "2.9.0")
            {
                if (hasExtendedHandlerInstalled)
                {
                    if (OnlineCheckBox.Checked && NewMapName != "<no change>")
                    {
                        // Main maps
                        pokeThem(0x12B4D6E4 + diffforhandler, NewMapName, 16);
                    }
                    if (DojoCheckBox.Checked && NewMapName != "<no change>")
                    {
                        // Dojo
                        pokeThem(0x12B55A84 + diffforhandler, NewMapName, 5);
                    }
                    if (ShootingRangeCheckBox.Checked && NewMapName != "<no change>")
                    {
                        // Shooting Range
                        pokeThem(0x105FB948 + diffforhandler, NewMapName, 1);
                    }
                }
                else
                {
                    if (OnlineCheckBox.Checked && NewMapName != "<no change>")
                    {
                        // Main maps
                        pokeThem(0x12B4D6E4, NewMapName, 16);

                    }
                    if (DojoCheckBox.Checked && NewMapName != "<no change>")
                    {
                        // Dojo
                        pokeThem(0x12B55A84, NewMapName, 5);
                    }
                    if (ShootingRangeCheckBox.Checked && NewMapName != "<no change>")
                    {
                        // Shooting Range
                        pokeThem(0x105FB948, NewMapName, 1);
                    }
                }
            }
        }

        public void PokeAllSceneEnvSetNames(string SetName)
        {
            if (SetName != "<no change>")
            {
                uint baseAddress = 0x12B4BB20;
                if (VerCBox.Text == "2.10.0" || VerCBox.Text == "2.9.0")
                {
                    baseAddress = 0x12B4D7C8;
                }
                if (hasExtendedHandlerInstalled)
                {
                    for (uint i = 0; i < 16; i++)
                    {
                        writeStringSimple(baseAddress + diffforhandler + i * 0x0288, SetName, "MisMonitorBroken,Common".Length);
                    }
                }
                else
                {
                    for (uint i = 0; i < 16; i++)
                    {
                        writeStringSimple(baseAddress + i * 0x0288, SetName, "MisMonitorBroken,Common".Length);
                    }
                }
            }
        }

        private void pokeThem(uint startOffset, string NewMapName, int num)
        {
            for (uint i = 0; i < num; i++)
                writeStringSimple(startOffset + i * 0x288, NewMapName, "Fld_BossCylinderKing_Bos_Msn".Length);
        }

        private void PokeButton_Click(object sender, EventArgs e)
        {
            try
            {
                PokeAllMaps(((NameWrapper)NameCBox.SelectedItem).dataName);
            }
            catch (NullReferenceException)
            {
                PokeAllMaps(NameCBox.Text);
            }

            try
            {
                PokeAllSceneEnvSetNames(((NameWrapper)seCBox.SelectedItem).dataName);
            }
            catch (NullReferenceException)
            {
                PokeAllSceneEnvSetNames(seCBox.Text);
            }

            MessageBox.Show("Success!", "GeckoTool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void writeString(string s, uint offset)
        {
            uint push = 0;
            int pos = 0;
            if (offset % 4 != 0)
            {
                push = s[pos++];
                offset -= offset % 4;
                Gecko.poke(offset, push);
                offset += 4;
            }
            for (; pos < s.Length; pos += 2, offset += 4)
            {
                if (pos + 1 == s.Length)
                {
                    push = (uint)(s[pos] << 16) + (Gecko.peek(offset) & 0xFF);
                }
                push = (uint)(s[pos] << 16) + s[pos + 1];
                Gecko.poke(offset, push);
            }
        }

        private void writeStringSimple(uint offset, string s)
        {
            writeStringSimple(offset, s, s.Length);
        }
        private void writeStringSimple(uint offset, string s, int length)
        {
            uint push = 0;
            int pos = 0;
            if (offset % 4 != 0)
            {
                for (int i = 0; i < offset % 4; i++)
                {
                    push = push << 8 | s[pos++];
                }
                if (offset % 4 == 1)
                {
                    push = Gecko.peek(offset - offset % 4) & 0xFF000000 | push;
                }
                if (offset % 4 == 2)
                {
                    push = Gecko.peek(offset - offset % 4) & 0xFFFF0000 | push;
                }
                if (offset % 4 == 3)
                {
                    push = Gecko.peek(offset - offset % 4) & 0xFFFFFF00 | push;
                }
                Gecko.poke(offset, push);
                offset += offset % 4;
            }
            for (; pos < s.Length; offset += 4)
            {
                push = 0;
                if (pos + 1 == s.Length)
                {
                    push = (uint)s[pos++] << 24 | Gecko.peek(offset) & 0x00FFFFFF;
                    Gecko.poke(offset, push);
                    offset += 1;
                    break;
                }
                if (pos + 2 == s.Length)
                {
                    push = s[pos++];
                    push = push << 8 | s[pos++];
                    push = push << 16 | Gecko.peek(offset) & 0x0000FFFF;
                    Gecko.poke(offset, push);
                    offset += 2;
                    break;
                }
                if (pos + 3 == s.Length)
                {
                    push = s[pos++];
                    push = push << 8 | s[pos++];
                    push = push << 8 | s[pos++];
                    push = push << 8 | Gecko.peek(offset) & 0x000000FF;
                    Gecko.poke(offset, push);
                    break;
                }
                for (int i = 0; i < 4; i++)
                {
                    push = push << 8 | s[pos++];
                }
                Gecko.poke(offset, push);
            }
            for (; pos < length; offset += 4, pos += 4)
            {
                if (pos % 4 == 1)
                {
                    Gecko.poke(offset, Gecko.peek(offset) & 0xFF000000);
                    pos--;
                    continue;
                }
                if (pos % 4 == 2)
                {
                    Gecko.poke(offset, Gecko.peek(offset) & 0xFFFF0000);
                    pos--; pos--;
                    continue;
                }
                if (pos % 4 == 3)
                {
                    Gecko.poke(offset, Gecko.peek(offset) & 0xFFFFFF00);
                    pos--; pos--; pos--;
                    continue;
                }
                if (pos + 1 == length)
                {
                    push = Gecko.peek(offset) & 0x00FFFFFF;
                    Gecko.poke(offset, push);
                    offset += 1;
                    pos++;
                    break;
                }
                if (pos + 2 == length)
                {
                    push = Gecko.peek(offset) & 0x0000FFFF;
                    Gecko.poke(offset, push);
                    offset += 2;
                    pos += 2;
                    break;
                }
                if (pos + 3 == length)
                {
                    push = Gecko.peek(offset) & 0x000000FF;
                    Gecko.poke(offset, push);
                    offset += 3;
                    pos += 3;
                    break;
                }
                Gecko.poke(offset, 0);
            }
        }
    }
}
