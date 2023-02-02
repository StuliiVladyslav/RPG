
while (true) 
{
    Console.Clear();
    Console.CursorVisible = false;
Map NewMap = new Map();

Orc Orc1 = new Orc("xWARx",25,5);
Orc Orc2 = new Orc("B1ack",25,10);
Orc Orc3 = new Orc("Incas",25,15);
Orc Orc4 = new Orc("Луша",25,20);
Elf Elf1 = new Elf("3veR",85,5);
Elf Elf2 = new Elf("EvZ",85,10);
Elf Elf3 = new Elf("Ssize",85,15);
Elf Elf4 = new Elf("L1ssa",85,20);
OrcBase Orcbase = new OrcBase();
ElfBase Elfbase = new ElfBase();
NewMap.ShowMap(); NewMap.addhouse(-10, 0); NewMap.addhouse2(25, 0); NewMap.addhouse2(40, 0); NewMap.addhouse2(65, 0); NewMap.addhouse(85, 0);
NewMap.addhuman(21, 0); NewMap.addhuman(24, 0); NewMap.addhuman(27, 0); NewMap.addhuman(30, 0); NewMap.addhuman(37, 0); NewMap.addhuman(50, 0);
NewMap.addCact(67, 0); NewMap.addCact2(2, 0); NewMap.addCact3(75, 0); NewMap.addGrass(70, 2); NewMap.addGrass(33, 2); NewMap.addGrass(92, 2);
NewMap.addCact2(96, 0); NewMap.addGrass(116, 2);
    
while (true)
{
    Orcbase.ShowBase();
    Elfbase.ShowBase();
    Orc1.ShowPlayer();
    Orc2.ShowPlayer();
    Orc3.ShowPlayer();
    Orc4.ShowPlayer();
    Elf1.ShowPlayer();
    Elf2.ShowPlayer();
    Elf3.ShowPlayer();
    Elf4.ShowPlayer();
        if (Orcbase.HP == 0 | Elfbase.HP == 0) { break; }
        NewMap.ShowMoveOrc( ref Orc1, ref Elf1,ref Elfbase);
    
    NewMap.ClearConsole();
    Orc1.ShowPlayer();
    Orc2.ShowPlayer();
    Orc3.ShowPlayer();
    Orc4.ShowPlayer();
    Elf1.ShowPlayer();
    Elf2.ShowPlayer();
    Elf3.ShowPlayer();
    Elf4.ShowPlayer();
        if (Orcbase.HP == 0 | Elfbase.HP == 0) { break; }
        NewMap.ShowMoveElf( ref Elf1, ref Orc1, ref Orcbase);
        
        NewMap.ClearConsole();
    Orc1.ShowPlayer();
    Orc2.ShowPlayer();
    Orc3.ShowPlayer();
    Orc4.ShowPlayer();
    Elf1.ShowPlayer();
    Elf2.ShowPlayer();
    Elf3.ShowPlayer();
    Elf4.ShowPlayer();
        if (Orcbase.HP == 0 | Elfbase.HP == 0) { break; }
        NewMap.ShowMoveOrc( ref Orc2, ref Elf2 , ref Elfbase);
        
        NewMap.ClearConsole();
    Orc1.ShowPlayer();
    Orc2.ShowPlayer();
    Orc3.ShowPlayer();
    Orc4.ShowPlayer();
    Elf1.ShowPlayer();
    Elf2.ShowPlayer();
    Elf3.ShowPlayer();
    Elf4.ShowPlayer();
        if (Orcbase.HP == 0 | Elfbase.HP == 0) { break; }
        NewMap.ShowMoveElf( ref Elf2, ref Orc2, ref Orcbase);
        
        NewMap.ClearConsole();
    Orc1.ShowPlayer();
    Orc2.ShowPlayer();
    Orc3.ShowPlayer();
    Orc4.ShowPlayer();
    Elf1.ShowPlayer();
    Elf2.ShowPlayer();
    Elf3.ShowPlayer();
    Elf4.ShowPlayer();
        if (Orcbase.HP == 0 | Elfbase.HP == 0) { break; }
        NewMap.ShowMoveOrc( ref Orc3, ref Elf3, ref Elfbase);
        
        NewMap.ClearConsole();
    Orc1.ShowPlayer();
    Orc2.ShowPlayer();
    Orc3.ShowPlayer();
    Orc4.ShowPlayer();
    Elf1.ShowPlayer();
    Elf2.ShowPlayer();
    Elf3.ShowPlayer();
    Elf4.ShowPlayer();
        if (Orcbase.HP == 0 | Elfbase.HP == 0) { break; }
        NewMap.ShowMoveElf(ref Elf3, ref Orc3, ref Orcbase);
       
        NewMap.ClearConsole();
    Orc1.ShowPlayer();
    Orc2.ShowPlayer();
    Orc3.ShowPlayer();
    Orc4.ShowPlayer();
    Elf1.ShowPlayer();
    Elf2.ShowPlayer();
    Elf3.ShowPlayer();
    Elf4.ShowPlayer();
        if (Orcbase.HP == 0 | Elfbase.HP == 0) { break; }
        NewMap.ShowMoveOrc( ref Orc4, ref Elf4, ref Elfbase);
        
        NewMap.ClearConsole();
    Orc1.ShowPlayer();
    Orc2.ShowPlayer();
    Orc3.ShowPlayer();
    Orc4.ShowPlayer();
    Elf1.ShowPlayer();
    Elf2.ShowPlayer();
    Elf3.ShowPlayer();
    Elf4.ShowPlayer();
        if (Orcbase.HP == 0 | Elfbase.HP == 0) { break; }
        NewMap.ShowMoveElf(ref Elf4 , ref Orc4, ref Orcbase);
        
        NewMap.ClearConsole();
    Orc1.ShowPlayer();
    Orc2.ShowPlayer();
    Orc3.ShowPlayer();
    Orc4.ShowPlayer();
    Elf1.ShowPlayer();
    Elf2.ShowPlayer();
    Elf3.ShowPlayer();
    Elf4.ShowPlayer();
    NewMap.ClearConsole();


}


}
class OrcBase
{
    public int HP = 1000;
    
    public void ShowBase()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(0, 5);
        Console.WriteLine("░▓░▓░▓");
        Console.SetCursorPosition(0, 6);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(0, 7);
        Console.WriteLine("░▓░▓░▓");
        Console.SetCursorPosition(0, 8);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(0, 9);
        Console.WriteLine("░▓░▓░▓");
        Console.SetCursorPosition(0, 10);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(0, 11);
        Console.WriteLine("░▓░▓░▓");
        Console.SetCursorPosition(0, 12);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(0, 13);
        Console.WriteLine("░▓░▓░▓");
        Console.SetCursorPosition(0, 14);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(0, 15);
        Console.WriteLine("░▓░▓░▓");
        Console.SetCursorPosition(0, 16);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(0, 17);
        Console.WriteLine("░▓░▓░▓");
        Console.SetCursorPosition(0, 18);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(0, 19);
        Console.WriteLine("░▓░▓░▓");
        Console.SetCursorPosition(0, 20);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(0, 21);
        Console.WriteLine("░▓░▓░▓");
        Console.SetCursorPosition(0, 22);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(0, 23);
        Console.WriteLine("░▓░▓░▓");
        Console.SetCursorPosition(2, 24);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine("████");////////////////
        Console.SetCursorPosition(2, 24);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.BackgroundColor = ConsoleColor.Yellow;
        if(HP <0)
        {
            HP = 0;
        }
       Console.Write((int)HP);
        if(HP <= 0)
        {
            WMPLib.WindowsMediaPlayer axMusicPlayer = new WMPLib.WindowsMediaPlayer();

            string path = Path.GetFullPath(@"\boom.mp3");//////////////////
            axMusicPlayer.URL = path;
            axMusicPlayer.settings.setMode("loop", false);
            axMusicPlayer.controls.play();
            HP = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("░▓░▓░▓");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("░▓░▓░▓");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("░▓░▓░▓");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("░▓░▓░▓");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(0, 13);
            Console.WriteLine("░▓░▓░▓");
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("░▓░▓░▓");
            Console.SetCursorPosition(0, 16);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(0, 17);
            Console.WriteLine("░▓░▓░▓");
            Console.SetCursorPosition(0, 18);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(0, 19);
            Console.WriteLine("░▓░▓░▓");
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(0, 21);
            Console.WriteLine("░▓░▓░▓");
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(0, 23);
            Console.WriteLine("░▓░▓░▓");
            Console.SetCursorPosition(2, 24);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("ELFS WIN!");
            Thread.Sleep(5000);
            return;
        }

    }
}
class ElfBase
{
    public int HP = 1000;
    public void ShowBase()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(114, 5);
        Console.WriteLine("▓░▓░▓░");
        Console.SetCursorPosition(113, 6);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(114, 7);
        Console.WriteLine("▓░▓░▓░");
        Console.SetCursorPosition(113, 8);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(114, 9);
        Console.WriteLine("▓░▓░▓░");
        Console.SetCursorPosition(113, 10);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(114, 11);
        Console.WriteLine("▓░▓░▓░");
        Console.SetCursorPosition(113, 12);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(114, 13);
        Console.WriteLine("▓░▓░▓░");
        Console.SetCursorPosition(113, 14);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(114, 15);
        Console.WriteLine("▓░▓░▓░");
        Console.SetCursorPosition(113, 16);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(114, 17);
        Console.WriteLine("▓░▓░▓░");
        Console.SetCursorPosition(113, 18);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(114, 19);
        Console.WriteLine("▓░▓░▓░");
        Console.SetCursorPosition(113, 20);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(113, 21);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(114, 22);
        Console.WriteLine("▓░▓░▓░");
        Console.SetCursorPosition(113, 23);
        Console.WriteLine("▓▓▓▓▓▓▓");
        Console.SetCursorPosition(113, 24);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine("████");////////////////
        Console.SetCursorPosition(113, 24);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.BackgroundColor = ConsoleColor.Yellow;
       
        if (HP < 0)
        {
            HP = 0;
        }
        Console.Write((int)HP);
        if (HP <= 0)
        {
            WMPLib.WindowsMediaPlayer axMusicPlayer = new WMPLib.WindowsMediaPlayer();

            string path = Path.GetFullPath(@"\boom.mp3");//////////////////
            axMusicPlayer.URL = path;
            axMusicPlayer.settings.setMode("loop", false);
            axMusicPlayer.controls.play();
            HP = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(114, 5);
            Console.WriteLine("▓░▓░▓░");
            Console.SetCursorPosition(113, 6);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(114, 7);
            Console.WriteLine("▓░▓░▓░");
            Console.SetCursorPosition(113, 8);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(114, 9);
            Console.WriteLine("▓░▓░▓░");
            Console.SetCursorPosition(113, 10);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(114, 11);
            Console.WriteLine("▓░▓░▓░");
            Console.SetCursorPosition(113, 12);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(114, 13);
            Console.WriteLine("▓░▓░▓░");
            Console.SetCursorPosition(113, 14);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(114, 15);
            Console.WriteLine("▓░▓░▓░");
            Console.SetCursorPosition(113, 16);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(114, 17);
            Console.WriteLine("▓░▓░▓░");
            Console.SetCursorPosition(113, 18);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(114, 19);
            Console.WriteLine("▓░▓░▓░");
            Console.SetCursorPosition(113, 20);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(113, 21);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.SetCursorPosition(114, 22);
            Console.WriteLine("▓░▓░▓░");
            Console.SetCursorPosition(113, 23);
            Console.WriteLine("▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("ORCS WIN!");
            Thread.Sleep(5000);
            
            


        }
    }
}


class Orc
{
    public int Helth;
    public string name;
    public int pos1, pos2;
    public Orc(string name, int pos1, int pos2)
    {
        int helth = new Random().Next(90, 180);
        Helth = helth;
        this.name = name;
        this.pos1 = pos1;
        this.pos2 = pos2;
       
    }
    public void ShowPlayer()
    {
        if (pos1 != 5)
        {
            if (Helth > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(pos1 - 5, pos2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 - 5, pos2 + 1);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 - 5, pos2 + 2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 - 5, pos2 + 3);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 + 5, pos2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 + 5, pos2 + 1);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 + 5, pos2 + 2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 + 5, pos2 + 3);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 + 5, pos2 - 1);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 - 5, pos2 - 1);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" o  /");
                Console.SetCursorPosition(pos1, pos2 + 1);
                Console.WriteLine("/█L/");
                Console.SetCursorPosition(pos1, pos2 + 2);
                Console.WriteLine(" П");
                Console.SetCursorPosition(pos1, pos2 + 3);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("███");
                Console.SetCursorPosition(pos1, pos2 + 3);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine((int)Helth);
                Console.SetCursorPosition(pos1, pos2 - 1);
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine(name);

                Console.ResetColor();
            }
            if (Helth <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(pos1, pos2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 + 1);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 + 2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 + 3);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 + 1);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 + 2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 + 3);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 - 1);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 - 1);
                Console.WriteLine("█████");
                pos1 = 5;
            }
        }
       


    }
}
   
class Elf 
{
    public int Helth;
    public string name;
    public int pos1, pos2;
    public  Elf(string name, int pos1,int pos2)
    {
        int helth = new Random().Next(90, 180);
        Helth = helth;
        this.name = name;
        this.pos1 = pos1; 
        this.pos2 = pos2;
    }
    public  void ShowPlayer()
    {
        if (pos1 != 108)
        {
            if (Helth > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(pos1 - 5, pos2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 - 5, pos2 + 1);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 - 5, pos2 + 2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 - 5, pos2 + 3);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 + 5, pos2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 + 5, pos2 + 1);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 + 5, pos2 + 2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 + 5, pos2 + 3);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 - 5, pos2 - 1);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1 + 5, pos2 - 1);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\\ o ");
                Console.SetCursorPosition(pos1, pos2 + 1);
                Console.WriteLine(" \\█\\");
                Console.SetCursorPosition(pos1, pos2 + 2);
                Console.WriteLine("  П");
                Console.SetCursorPosition(pos1 + 1, pos2 + 3);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("███");
                Console.SetCursorPosition(pos1 + 1, pos2 + 3);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine((int)Helth);
                Console.SetCursorPosition(pos1, pos2 - 1);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(name);

                Console.ResetColor();
            }
            if (Helth <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(pos1, pos2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 + 1);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 + 2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 + 3);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 + 1);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 + 2);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 + 3);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 - 1);
                Console.WriteLine("█████");
                Console.SetCursorPosition(pos1, pos2 - 1);
                Console.WriteLine("█████");
                pos1 = 108;
            }
        }
       

    }
}
class Map
{

    public void ShowMap()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("[][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][]");
        Console.ResetColor();

    }
    public void addhouse(int a, int b)
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.SetCursorPosition(a+18, b);
        Console.WriteLine("░▓░▓░▓░▓░▓");
        Console.SetCursorPosition(a+17, b+1);
        Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓");
        Console.SetCursorPosition(a+16, b+2);
        Console.WriteLine("░▓░▓░▓░▓░▓░▓░▓");
        Console.SetCursorPosition(a+15, b+3);
        
        Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
    }
    public void addhouse2(int a, int b)
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.DarkYellow;
       
        Console.SetCursorPosition(a + 19, b + 1);
        Console.WriteLine("▓▓");
        Console.SetCursorPosition(a + 17, b + 2);
        Console.WriteLine("▓░▓░▓░");
        Console.SetCursorPosition(a + 15, b + 3);

        Console.WriteLine("▓▓▓▓▓▓▓▓▓▓");
    }
    public void addhuman(int a, int b)
    {

        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Blue;

        Console.SetCursorPosition(a, b+1);
        
        Console.WriteLine(" o  ");
        Console.SetCursorPosition(a, b + 2);
        Console.WriteLine("/█0");
        Console.SetCursorPosition(a, b + 3);
        Console.WriteLine(" П");
    }
    public void addCact(int a, int b)
    {

        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(a - 1, b);
        Console.WriteLine("░");
        Console.SetCursorPosition(a - 1, b + 1);
        Console.WriteLine("░");
        Console.SetCursorPosition(a+1, b + 1);
        Console.WriteLine("░");

        Console.SetCursorPosition(a, b + 2);
        Console.WriteLine("░");
        Console.SetCursorPosition(a, b + 3);
        Console.WriteLine("░");
    }
    public void addCact2(int a, int b)
    {

        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(a + 1, b);
        Console.WriteLine("░");
       
        Console.SetCursorPosition(a - 1, b + 1);
        Console.WriteLine("░");
        Console.SetCursorPosition(a + 1, b + 1);
        Console.WriteLine("░");

        Console.SetCursorPosition(a, b + 2);
        Console.WriteLine("░");
        Console.SetCursorPosition(a, b + 3);
        Console.WriteLine("░");
    }
    public void addCact3(int a, int b)
    {

        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Green;
    
        Console.SetCursorPosition(a , b + 1);
        Console.WriteLine("░");

        Console.SetCursorPosition(a, b + 2);
        Console.WriteLine("░");
        Console.SetCursorPosition(a, b + 3);
        Console.WriteLine("░");
    }
    public void addGrass(int a, int b)
    {

        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Blue;

        Console.SetCursorPosition(a, b + 1);
        Console.WriteLine("wWw");
       
    }
    public void ClearConsole()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.SetCursorPosition(0, 27);
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.ResetColor();
    }
    public void  ShowMoveOrc(ref Orc orc, ref Elf elf, ref ElfBase elfbase)
    {
        if(orc.Helth >0)
        {
            int temp = elf.pos1 - orc.pos1;

            if (temp > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(0, 27);
                Console.WriteLine("              <- A     D ->");
                Console.SetCursorPosition(0, 28);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                   " + orc.name);
                Console.ResetColor();
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'd':
                        orc.pos1 += 5;
                        

                        WMPLib.WindowsMediaPlayer axMusicPlayer = new WMPLib.WindowsMediaPlayer();
                       
                            string path = Path.GetFullPath(@"\run2.mp3");//////////////////
                            axMusicPlayer.URL = path;
                            axMusicPlayer.settings.setMode("loop", false);
                            axMusicPlayer.controls.play();
                        
                          


                        break;
                    case 'a':
                        if (orc.pos1 >15)
                        {
                            orc.pos1 -= 5;

                            WMPLib.WindowsMediaPlayer axMusicPlayer2 = new WMPLib.WindowsMediaPlayer();

                            string path2 = Path.GetFullPath(@"\run2.mp3");//////////////////
                            axMusicPlayer2.URL = path2;
                            axMusicPlayer2.settings.setMode("loop", false);
                            axMusicPlayer2.controls.play();
                            int Heal = new Random().Next(1, 100);
                            if (Heal <= 33)
                            {


                                string path3 = Path.GetFullPath(@"\heal.mp3");//////////////////
                                axMusicPlayer2.URL = path3;
                                axMusicPlayer2.settings.setMode("loop", false);
                                axMusicPlayer2.controls.play();
                                Thread.Sleep(1000);
                                int HealRand = new Random().Next(20, 55);
                                orc.Helth += HealRand;
                            }


                            
                        }
                        break;
                }
            }
            if (temp <= 10)
            {
                Console.SetCursorPosition(0, 27);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("              <- A       Attack (S)");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 28);
                Console.WriteLine("                     " + orc.name);
                Console.ResetColor();

                switch (Console.ReadKey(true).KeyChar)
                {

                    case 'a':
                        if (orc.pos1 > 15)
                        {
                            orc.pos1 -= 5;
                            WMPLib.WindowsMediaPlayer axMusicPlayer2 = new WMPLib.WindowsMediaPlayer();

                            string path2 = Path.GetFullPath(@"\run2.mp3");//////////////////
                            axMusicPlayer2.URL = path2;
                            axMusicPlayer2.settings.setMode("loop", false);
                            axMusicPlayer2.controls.play();
                            int Heal = new Random().Next(1, 100);
                            if (Heal <= 33)
                            {


                                string path3 = Path.GetFullPath(@"\heal.mp3");//////////////////
                                axMusicPlayer2.URL = path3;
                                axMusicPlayer2.settings.setMode("loop", false);
                                axMusicPlayer2.controls.play();
                                Thread.Sleep(1000);
                                int HealRand = new Random().Next(20, 55);
                                orc.Helth += HealRand;
                            }
                        }
                            
                        break;
                    case 's':

                        if(orc.pos1 == 100)
                        {
                            int Damage = new Random().Next(1, 55);
                            elfbase.HP -= Damage;
                            elfbase.ShowBase();/////////////////////
                            int Rnd = new Random().Next(1, 100);

                            WMPLib.WindowsMediaPlayer axMusicPlayer = new WMPLib.WindowsMediaPlayer();
                            if (Rnd <= 33)
                            {
                                string path = Path.GetFullPath(@"\base.mp3");//////////////////
                                axMusicPlayer.URL = path;
                                axMusicPlayer.settings.setMode("loop", false);
                                axMusicPlayer.controls.play();
                            }
                            if (Rnd > 33 & Rnd <=66)
                            {
                                string path = Path.GetFullPath(@"\base.mp3");//////////////////
                                axMusicPlayer.URL = path;
                                axMusicPlayer.settings.setMode("loop", false);
                                axMusicPlayer.controls.play();
                            }
                            if (Rnd > 66)
                            {
                                string path = Path.GetFullPath(@"\base.mp3");//////////////////
                                axMusicPlayer.URL = path;
                                axMusicPlayer.settings.setMode("loop", false);
                                axMusicPlayer.controls.play();
                            }

                            

                        }
                        else
                        {
                            int Damage = new Random().Next(1, 55);
                            elf.Helth -= Damage;
                            elf.ShowPlayer();
                            int Rnd = new Random().Next(1, 100);

                            WMPLib.WindowsMediaPlayer axMusicPlayer = new WMPLib.WindowsMediaPlayer();
                            if (Rnd <= 33)
                            {
                                string path = Path.GetFullPath(@"\strike1.mp3");//////////////////
                                axMusicPlayer.URL = path;
                                axMusicPlayer.settings.setMode("loop", false);
                                axMusicPlayer.controls.play();
                            }
                            if (Rnd > 33 & Rnd <= 66)
                            {
                                string path = Path.GetFullPath(@"\strike2.mp3");//////////////////
                                axMusicPlayer.URL = path;
                                axMusicPlayer.settings.setMode("loop", false);
                                axMusicPlayer.controls.play();
                            }
                            if (Rnd > 66)
                            {
                                string path = Path.GetFullPath(@"\strike3.mp3");//////////////////
                                axMusicPlayer.URL = path;
                                axMusicPlayer.settings.setMode("loop", false);
                                axMusicPlayer.controls.play();
                            }
                        }
                        break;
                }
            }
        }

       
       
    }
    public void ShowMoveElf(ref Elf elf, ref Orc orc, ref OrcBase orcbase)
    {
        if (elf.Helth > 0)
        {
            int temp = elf.pos1 - orc.pos1;

            if (temp > 10)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(0, 27);
                Console.WriteLine("                                                                                               <- A     D ->");
                Console.SetCursorPosition(0, 28);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                                                                                                   " + elf.name);
                Console.ResetColor();
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'd':
                        if (elf.pos1 < 100)
                        {
                            elf.pos1 += 5;

                            WMPLib.WindowsMediaPlayer axMusicPlayer = new WMPLib.WindowsMediaPlayer();

                            string path = Path.GetFullPath(@"\run.mp3");//////////////////
                            axMusicPlayer.URL = path;
                            axMusicPlayer.settings.setMode("loop", false);
                            axMusicPlayer.controls.play();
                            int Heal = new Random().Next(1, 100);
                            if (Heal <= 33)
                            {


                                string path3 = Path.GetFullPath(@"\heal.mp3");//////////////////
                                axMusicPlayer.URL = path3;
                                axMusicPlayer.settings.setMode("loop", false);
                                axMusicPlayer.controls.play();
                                Thread.Sleep(1000);
                                int HealRand = new Random().Next(20, 55);
                                elf.Helth += HealRand;
                            }
                        }
                            

                        break;
                    case 'a':
                        elf.pos1 -= 5;
                       
                        
                        WMPLib.WindowsMediaPlayer axMusicPlayer2 = new WMPLib.WindowsMediaPlayer();
                        
                            string path2 = Path.GetFullPath(@"\run.mp3");//////////////////
                            axMusicPlayer2.URL = path2;
                            axMusicPlayer2.settings.setMode("loop", false);
                            axMusicPlayer2.controls.play();
                       

                       

                        break;
                }

            }
            if (temp <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(0, 27);
                Console.WriteLine("                                                                                      Attack (S)    D ->");
                Console.SetCursorPosition(0, 28);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                                                                                            " + elf.name);
                Console.ResetColor();
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'd':
                        if(elf.pos1<100)
                        {
                            elf.pos1 += 5;

                            WMPLib.WindowsMediaPlayer axMusicPlayer2 = new WMPLib.WindowsMediaPlayer();

                            string path2 = Path.GetFullPath(@"\run.mp3");//////////////////
                            axMusicPlayer2.URL = path2;
                            axMusicPlayer2.settings.setMode("loop", false);
                            axMusicPlayer2.controls.play();
                            int Heal = new Random().Next(1, 100);
                            if (Heal <= 33)
                            {


                                string path3 = Path.GetFullPath(@"\heal.mp3");//////////////////
                                axMusicPlayer2.URL = path3;
                                axMusicPlayer2.settings.setMode("loop", false);
                                axMusicPlayer2.controls.play();
                                Thread.Sleep(1000);
                                int HealRand = new Random().Next(20, 55);
                                elf.Helth += HealRand;
                            }
                        }
                        
                        break;
                    case 's':
                        if(elf.pos1 == 15)
                        {
                            
                                int Damagee = new Random().Next(1, 55);
                                orcbase.HP -= Damagee;
                            orcbase.ShowBase();/////////////////////
                            int Rnd = new Random().Next(1, 100);

                            WMPLib.WindowsMediaPlayer axMusicPlayer = new WMPLib.WindowsMediaPlayer();
                            if (Rnd <= 33)
                            {
                                string path = Path.GetFullPath(@"\base.mp3");//////////////////
                                axMusicPlayer.URL = path;
                                axMusicPlayer.settings.setMode("loop", false);
                                axMusicPlayer.controls.play();
                            }
                            if (Rnd > 33 & Rnd <= 66)
                            {
                                string path = Path.GetFullPath(@"\base.mp3");//////////////////
                                axMusicPlayer.URL = path;
                                axMusicPlayer.settings.setMode("loop", false);
                                axMusicPlayer.controls.play();
                            }
                            if (Rnd > 66)
                            {
                                string path = Path.GetFullPath(@"\base.mp3");//////////////////
                                axMusicPlayer.URL = path;
                                axMusicPlayer.settings.setMode("loop", false);
                                axMusicPlayer.controls.play();
                            }
                            break;
                        }
                        else
                        {
                            int Damage = new Random().Next(1, 55);
                            orc.Helth -= Damage;
                            orc.ShowPlayer();
                            int Rnd = new Random().Next(1, 100);

                            WMPLib.WindowsMediaPlayer axMusicPlayer = new WMPLib.WindowsMediaPlayer();
                            if (Rnd <= 33)
                            {
                                string path = Path.GetFullPath(@"\strike1.mp3");//////////////////
                                axMusicPlayer.URL = path;
                                axMusicPlayer.settings.setMode("loop", false);
                                axMusicPlayer.controls.play();
                            }
                            if (Rnd > 33 & Rnd <= 66)
                            {
                                string path = Path.GetFullPath(@"\strike2.mp3");//////////////////
                                axMusicPlayer.URL = path;
                                axMusicPlayer.settings.setMode("loop", false);
                                axMusicPlayer.controls.play();
                            }
                            if (Rnd > 66)
                            {
                                string path = Path.GetFullPath(@"\strike3.mp3");//////////////////
                                axMusicPlayer.URL = path;
                                axMusicPlayer.settings.setMode("loop", false);
                                axMusicPlayer.controls.play();
                            }
                            break;
                        }
                        
                }
            }

        }


    }
}
