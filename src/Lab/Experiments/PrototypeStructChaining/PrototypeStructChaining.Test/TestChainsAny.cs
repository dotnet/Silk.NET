using Silk.NET.Vulkan;
using Xunit;

namespace PrototypeStructChaining.Test;

public class TestChainsAny
{
    [Fact]
    public unsafe void TestAddNextUnchecked()
    {
        var geometryInstancesData = new AccelerationStructureGeometryInstancesDataKHR();
        geometryInstancesData
            .AddNextAny(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
            .AddNextAny(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);

        // Ensure all pointers set correctly
        Assert.Equal((nint) (&indexingFeatures), (nint) geometryInstancesData.PNext);
        Assert.Equal((nint) (&accelerationStructureFeaturesKhr), (nint) indexingFeatures.PNext);
        Assert.Equal(0, (nint) accelerationStructureFeaturesKhr.PNext);

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.AccelerationStructureGeometryInstancesDataKhr, geometryInstancesData.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures.SType);
        Assert.Equal
        (
            StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr,
            accelerationStructureFeaturesKhr.SType
        );

        // Check indices
        Assert.Equal(1, geometryInstancesData.IndexOfAny(ref indexingFeatures));
        Assert.Equal(2, geometryInstancesData.IndexOfAny(ref accelerationStructureFeaturesKhr));
    }
}
