using Systems.Collections.Generic;
namespace exercise
{

    public interface ITurnTable
    {
         double CurrentSpeed {get; set;}
         bool isPlaying {get; set;}
         void Play();
         void Stop();

    }
}
