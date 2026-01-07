using System.ComponentModel.DataAnnotations;

namespace TrackMetal.API.Models
{
    public class Corner
    {
        public int CornerId { get; set; }
        
        public int Sector { get; set; }
            
        public string Name { get; set; } = string.Empty;

        public string OfficialName { get; set; } = string.Empty;
        
        public string Type { get; set; } = string.Empty;

        public virtual Track Track { get; set; } = null!;
        public int TrackId { get; set; }


    }
}
