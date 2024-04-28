namespace Profile.Dto;

public class Project
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Banner { get; set; }
    public string[]? Images { get; set; }
    public string? Repository { get; set; }
    public string[]? TechBadges { get; set; }
}