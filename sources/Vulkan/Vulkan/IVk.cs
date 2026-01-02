namespace Silk.NET.Vulkan;

public partial interface IVk
{
    public InstanceHandle CurrentInstance { get; set; }

    public DeviceHandle CurrentDevice { get; set; }

    public IVk Clone();
}
