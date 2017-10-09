using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Classes;
using Mediateka.Interfaces;
using System.Media;

namespace Mediateka.Classes
{
    public class Player
    {
        SoundPlayer soundPlayer = new SoundPlayer();
   
        public Player(IPlayList playList)
        {
            Console.Clear();
            int switchCase = 2;
            foreach (IMediaItem item in playList.Items)
            {

                Console.WriteLine("1. Запуск проигрывания");
                Console.WriteLine("2. Остановка проигрывания");
                soundPlayer.Stream = item.MediaStream;
                while (switchCase != 3)
                {
                    switchCase = Int32.Parse(Console.ReadLine());
                    switch (switchCase)
                    {
                        case 1: soundPlayer.PlaySync(); break;
                        case 2: soundPlayer.Stop(); break;
                        case 3: break;
                        default: break;
                    }
                }
            }
        }

        public Player(Mediateka playList)
        {
            int switchCase = 1;
            foreach (IMediaItem item in playList)
            {
                Console.Clear();
                Console.WriteLine("1. Запуск проигрывания");
                Console.WriteLine("2. Остановка проигрывания");
                Console.WriteLine("3. Выход из текущей песни");
                Console.WriteLine(item.Name + item.Rating);
                soundPlayer.Stream = item.MediaStream;
                while (switchCase != 3)
                {
                    switchCase = Int32.Parse(Console.ReadLine());
                    switch (switchCase)
                    {
                        case 1: soundPlayer.PlaySync(); break;
                        case 2: soundPlayer.Stop(); break;
                        case 3: break;
                        default: break;
                    }
                }
            }
        }


    }
}
