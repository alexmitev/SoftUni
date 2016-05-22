namespace Animal.Species
{
    public interface IAnimal : ISound
    {
        int Age { get; set; }
        Gender Gender { get; set; }
        string Name { get; set; }

        
    }
}