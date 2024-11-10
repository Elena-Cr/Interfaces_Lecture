namespace lec09proj;

 public class FilmInfo  {
      public int YearOfRelease { get; set; }

      public int LengthInMinutes { get; set; }

      public string Title { get; set; }

      public string Subject { get; set; }

      public string Actor { get; set; }

      public string Actresses { get; set; }

      public string Director { get; set; }

      public int Popularity { get; set; }

      public bool AwardWon { get; set; }


      public override string ToString() {
         return $"Title: {Title}, Popularity: {Popularity}, Awarded: {AwardWon} Actors: {Actor}";
      }
 }