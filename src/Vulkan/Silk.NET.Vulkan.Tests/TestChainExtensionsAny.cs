using Xunit;

namespace Silk.NET.Vulkan.Tests;

public class TestChainExtensionsAny
{
    [Fact]
    public unsafe void TestAddNextUnchecked()
    {
        var accelerationStructureFeatures = new PhysicalDeviceAccelerationStructureFeaturesKHR();
        accelerationStructureFeatures
            .AddNextAny(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
            .AddNextAny(out DeviceCreateInfo deviceCreateInfo);

        // Ensure all pointers set correctly
        Assert.Equal((nint) (&indexingFeatures), (nint) accelerationStructureFeatures.PNext);
        Assert.Equal((nint) (&deviceCreateInfo), (nint) indexingFeatures.PNext);
        Assert.Equal(0, (nint) deviceCreateInfo.PNext);

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, accelerationStructureFeatures.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures.SType);
        Assert.Equal(StructureType.DeviceCreateInfo, deviceCreateInfo.SType);

        // Check indices
        Assert.Equal(1, accelerationStructureFeatures.IndexOfAny(ref indexingFeatures));
        Assert.Equal(2, accelerationStructureFeatures.IndexOfAny(ref deviceCreateInfo));
    }
}
