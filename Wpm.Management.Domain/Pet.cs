namespace Wpm.Management.Domain;

public class Pet : IEquatable<Pet>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Notes { get; set; }

    public bool Equals(Pet? other)
    {
        return other?.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
