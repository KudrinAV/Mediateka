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
   
        public Player(Mediateka playList)
        {
            foreach (IMediaItem item in playList)
            {
                if (item.AmITrack) { ItsSong(item); }
                else { ItsPicture(item); }

            }
        }

        private void ItsSong(IMediaItem item)
        {
            int switchCase = 0;
            Console.Clear();
            Console.WriteLine("1. Запуск проигрывания");
            Console.WriteLine("2. Остановка проигрывания");
            Console.WriteLine("3. Cлудующая песня");
            Console.WriteLine(item.Name);
            //soundPlayer.Stream = item.MediaStream;
            while (switchCase != 3)
            {
                switchCase = Int32.Parse(Console.ReadLine());
                switch (switchCase)
                {
                    case 1: PlayMusic(); break;
                    case 2: StopMusic(); break;
                    case 3: NextElement(); break;
                    default: break;
                }
            }
        }

        private void ItsPicture(IMediaItem item)
        {
            int switchCase = 0;
            Console.Clear();
            Console.WriteLine("1. Картинка");
            Console.WriteLine("2. Cлудующий элемент");
            Console.WriteLine(item.Name);
            //soundPlayer.Stream = item.MediaStream;
            while (switchCase != 2)
            {
                switchCase = Int32.Parse(Console.ReadLine());
                switch (switchCase)
                {
                    case 1: ShowPicture(); break;
                    case 2: NextElement(); break;
                    default: break;
                }
            }
        }


        private void ShowPicture()
        {
            Console.WriteLine("Picture is displaying");
        }

        private void PlayMusic()
        {
            Console.WriteLine("Music is playing");
        }

        private void StopMusic()
        {
            Console.WriteLine("Music is stopped");
        }

        public void NextElement()
        {
            Console.WriteLine("Next element is playing");
            Console.ReadLine();
        }


    }
}
