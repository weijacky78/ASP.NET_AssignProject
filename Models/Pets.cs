using System.ComponentModel.DataAnnotations;

public class Pet
{
    public uint PetId { get; set; }
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public uint Age { get; set; }
    public string SexGenre { get; set; } = "";

    [DataType(DataType.Date)]
    public DateTime Birthday { get; set; } = DateTime.Today;
    public string PhotoFileName { get; set; } = "";
}