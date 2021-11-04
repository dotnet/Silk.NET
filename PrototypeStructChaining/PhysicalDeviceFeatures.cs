namespace Silk.Net.Vulkan;

public struct PhysicalDeviceFeatures
{
    /// <summary></summary>
    public Bool32 RobustBufferAccess;

    // NOTE Truncated for example

    public PhysicalDeviceFeatures(
        Bool32? robustBufferAccess = null)
        : this()
    {
        if (robustBufferAccess.HasValue)
            RobustBufferAccess = robustBufferAccess.Value;

        // NOTE Truncated for example
    }
}