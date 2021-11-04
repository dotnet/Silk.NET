using Silk.Net.Vulkan;
using Xunit;

namespace PrototypeStructChaining.Test;

public class UnitTestChains
{
    [Fact]
    public unsafe void TestCreateNext()
    {
        PhysicalDeviceFeatures2
            .Chain(out var features2)
            .CreateNext<PhysicalDeviceDescriptorIndexingFeatures>(out var indexingFeatures)
            .CreateNext<PhysicalDeviceAccelerationStructureFeaturesKHR>(out var accelerationStructureFeaturesKhr)
            .End();

        Assert.Equal((nint) (&indexingFeatures), (nint) features2.PNext);
        Assert.Equal((nint) (&accelerationStructureFeaturesKhr), (nint) indexingFeatures.PNext);
        Assert.Equal((nint) 0, (nint) accelerationStructureFeaturesKhr.PNext);

        Assert.Equal(StructureType.PhysicalDeviceFeatures2, features2.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures.SType);
        Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr,
            accelerationStructureFeaturesKhr.SType);
    }

    [Fact]
    public unsafe void TestSetNext()
    {
        var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
        {
            ShaderInputAttachmentArrayDynamicIndexing = true
        };
        var accelerationStructureFeaturesKhr = new PhysicalDeviceAccelerationStructureFeaturesKHR
        {
            AccelerationStructure = true
        };
        
        PhysicalDeviceFeatures2
            .Chain(out var features2)
            .SetNext<PhysicalDeviceDescriptorIndexingFeatures>(ref indexingFeatures)
            .SetNext<PhysicalDeviceAccelerationStructureFeaturesKHR>(ref accelerationStructureFeaturesKhr)
            .End();

        Assert.Equal((nint) (&indexingFeatures), (nint) features2.PNext);
        Assert.Equal((nint) (&accelerationStructureFeaturesKhr), (nint) indexingFeatures.PNext);
        Assert.Equal((nint) 0, (nint) accelerationStructureFeaturesKhr.PNext);

        Assert.Equal(StructureType.PhysicalDeviceFeatures2, features2.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures.SType);
        Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr,
            accelerationStructureFeaturesKhr.SType);
        
        Assert.True(indexingFeatures.ShaderInputAttachmentArrayDynamicIndexing);
        Assert.True(accelerationStructureFeaturesKhr.AccelerationStructure);
    }
}