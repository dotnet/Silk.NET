namespace Silk.NET.Vulkan;

public partial interface IVk
{
    public InstanceTHandle CurrentInstance { get; set; }

    public DeviceTHandle CurrentDevice { get; set; }

    public IVk Clone();
}
