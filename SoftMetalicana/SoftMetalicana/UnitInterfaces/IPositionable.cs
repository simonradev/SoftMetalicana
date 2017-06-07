namespace SoftMetalicana.UnitInterfaces
{
    using SoftMetalicana.Positioning;
    
    public interface IPositionable
    {
        Position[] Positions { get; set; }
    }
}
