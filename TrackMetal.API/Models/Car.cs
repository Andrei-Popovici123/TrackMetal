using System.ComponentModel.DataAnnotations;

namespace TrackMetal.API.Models;

public class Car
{
    [Key] public int Id { get; set; }
}