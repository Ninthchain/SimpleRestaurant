namespace MyRestaurant.Client.Objects.RegisterObjects;



public sealed class RegisterSlot
{
    private uint _maxCash;

    public RegisterSlot(ushort index, uint maxCash)
    {
        _maxCash = maxCash;
    }

    public uint GetMax() => _maxCash;
}