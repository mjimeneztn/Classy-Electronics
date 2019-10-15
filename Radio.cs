using Systems.Collections.Generic;
namespace exercise
{
 public class Radio: IRadio, ISpeakeranator3001
{

    double CurrentFrequency {get; set;}
    public List<double> FavoriteStations {get; set;}

 public  bool isRadioOn{get; set;}
 public Int volume{get;set;}
public void AddFavorite(double station)
{
    FavoriteStations.AddFavorite(station)
}
public void TurnRadioOn(){
    isRadioOn= true;
}
public void TurnRadioOff(){
    isRadioOn= false;
}

    }
}