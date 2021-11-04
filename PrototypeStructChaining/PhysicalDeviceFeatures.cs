namespace Silk.Net.Vulkan;

public struct PhysicalDeviceFeatures
{
    /// <summary></summary>
    public bool RobustBufferAccess;

    // NOTE Truncated for example

    public PhysicalDeviceFeatures(
        bool? robustBufferAccess = null)
        : this()
    {
        if (robustBufferAccess.HasValue)
            RobustBufferAccess = robustBufferAccess.Value;

        // NOTE Truncated for example
    }
}