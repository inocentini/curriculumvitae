namespace CV.API.Models;

public class ResumeData
{
    public PersonalInfo? PersonalInfo { get; set; }
    public List<Experience> Experiences { get; set; } = new();
    public List<Education> Education { get; set; } = new();
    public List<SkillCategory> Skills { get; set; } = new();
    public List<Certification> Certifications { get; set; } = new();
    public List<Language> Languages { get; set; } = new();
}

public class PersonalInfo
{
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty; // "Engenheiro de Software..."
    public string Location { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string LinkedIn { get; set; } = string.Empty;
    public string GitHub { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty; // "Sobre" content
    public string PhotoUrl { get; set; } = string.Empty;
}

public class Experience
{
    public string Role { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string Period { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public List<string> DescriptionPoints { get; set; } = new();
}

public class Education
{
    public string Institution { get; set; } = string.Empty;
    public string Degree { get; set; } = string.Empty;
    public string Period { get; set; } = string.Empty;
}

public class SkillCategory
{
    public string CategoryName { get; set; } = string.Empty; // e.g., "Habilidades técnicas"
    public List<string> Items { get; set; } = new();
}

public class Certification
{
    public string Name { get; set; } = string.Empty;
}

public class Language
{
    public string Name { get; set; } = string.Empty;
    public string Level { get; set; } = string.Empty;
}
