using Systems.Collections.Generic;
namespace exercise
{
 public class SN4001: ITurnTable, ISpeakeranator3001
{
    public int volume {get;set}
    double CurrentSpeed {get; set;}
    bool isPlaying {get; set;}
public void Stop()
{
    isPlaying= false;
}
public void volumeDown(){
    volume--;;
}
public void play(){
    isPlaying= true;
}
public void volumeUp(){
    volume++;
}
    }
}