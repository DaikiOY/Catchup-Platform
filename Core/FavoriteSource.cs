namespace CatchupPlatform.Core.Entities
{
    public class FavoriteSource
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Url { get; set; } 
        public DateTime DateAdded { get; set; } 
        public FavoriteSource(string name, string url)
        {
            Name = name;
            Url = url;
            DateAdded = DateTime.Now;
        }

        public void Update(string newName, string newUrl)
        {
            Name = newName;
            Url = newUrl;
        }
    }
}
