using Silk.Net.Vulkan;
using Xunit;

namespace PrototypeStructChaining.Test;

public class TestChains
{
    [Fact]
    public unsafe void TestCreateNext()
    {
        PhysicalDeviceFeatures2
            // The Chain method, is a convenient static, to provide a consistent syntax.
            .Chain(out var features2)
            // CreateNext will create an empty struct, with the correct SType (as well as ensuring the
            // caller SType is coerced correctly.
            .CreateNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
            .CreateNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);

        // Ensure all pointers set correctly
        Assert.Equal((nint) (&indexingFeatures), (nint) features2.PNext);
        Assert.Equal((nint) (&accelerationStructureFeaturesKhr), (nint) indexingFeatures.PNext);
        Assert.Equal((nint) 0, (nint) accelerationStructureFeaturesKhr.PNext);

        // Ensure all STypes set correctly
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
            // SetNext accepts an existing struct, note, it will coerce the SType and blank the PNext
            .SetNext(ref indexingFeatures)
            .SetNext(ref accelerationStructureFeaturesKhr);

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

    [Fact]
    public unsafe void TestWithoutChain()
    {
        // We don't have to use the Chain() pattern, as we can start with an existing struct
        var createInfo = new DeviceCreateInfo
        {
            Flags = 1U
        };
        // However, note that CreateNext will still coerce the SType of createInfo.
        createInfo.CreateNext(out PhysicalDeviceFeatures2 features2);
        Assert.Equal((nint) (&features2), (nint) createInfo.PNext);
        Assert.Equal((nint) 0, (nint) features2.PNext);

        // Note, even though we didn't use chain, we have still coerced the SType
        Assert.Equal(StructureType.DeviceCreateInfo, createInfo.SType);
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, features2.SType);
        
        Assert.Equal(1U, createInfo.Flags);
    }
}