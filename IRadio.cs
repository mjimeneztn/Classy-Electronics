using Systems.Collections.Generic;
namespace exersice
{
   public interface IRadio{
       double CurrentFrequency {get; set;}

       List<double> FavoriteStations {get;set;}
       bool isRadioOn {get; set;}
       void AddFavorite(double station);



   void removeFavotite(double station);
  void TurnRadioOn();

    void TurnRadioOFf();
}