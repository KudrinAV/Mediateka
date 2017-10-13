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
            int switchCase = 0;
            foreach (IMediaItem item in playList)
            {
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
                        case 3: NextTrack(); break;
                        default: break;
                    }
                }
            }
        }

        private void PlayMusic()
        {
            Console.WriteLine("Music is playing");
        }

        private void StopMusic()
        {
            Console.WriteLine("Music is stopped");
        }

        public void NextTrack()
        {
            Console.WriteLine("Next track is playing");
        }


    }
}
