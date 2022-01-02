using Xunit;

namespace Silk.NET.Vulkan.Tests;

public class TestChainExtensions
{
    [Fact]
    public unsafe void TestAddNext()
    {
        PhysicalDeviceFeatures2
            // The BaseInStructure method, is a convenient static, to provide a consistent syntax.
            .Chain(out var features2)
            // AddNext will create an empty struct, with the correct SType (as well as ensuring the
            // chain's SType is coerced correctly.
            .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
            .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);

        // Ensure all pointers set correctly
        Assert.Equal((nint) (&indexingFeatures), (nint) features2.PNext);
        Assert.Equal((nint) (&accelerationStructureFeaturesKhr), (nint) indexingFeatures.PNext);
        Assert.Equal(0, (nint) accelerationStructureFeaturesKhr.PNext);

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, features2.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures.SType);
        Assert.Equal
        (
            StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr,
            accelerationStructureFeaturesKhr.SType
        );

        // Check indices
        Assert.Equal(1, features2.IndexOf(ref indexingFeatures));
        Assert.Equal(2, features2.IndexOf(ref accelerationStructureFeaturesKhr));
    }

    [Fact]
    public unsafe void TestTryAddNext()
    {
        PhysicalDeviceFeatures2
            // The BaseInStructure method, is a convenient static, to provide a consistent syntax.
            .Chain(out var features2)
            // AddNext will create an empty struct, with the correct SType (as well as ensuring the
            // chain's SType is coerced correctly.
            .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures);

        // Ensure all pointers set correctly
        Assert.Equal((nint) (&indexingFeatures), (nint) features2.PNext);

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, features2.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures.SType);

        features2.TryAddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures2, out var added);
        Assert.False(added);
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
        Assert.Equal(0, (nint) accelerationStructureFeaturesKhr.PNext);

        Assert.Equal(StructureType.PhysicalDeviceFeatures2, features2.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures.SType);
        Assert.Equal
        (
            StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr,
            accelerationStructureFeaturesKhr.SType
        );

        Assert.True(indexingFeatures.ShaderInputAttachmentArrayDynamicIndexing);
        Assert.True(accelerationStructureFeaturesKhr.AccelerationStructure);
    }

    [Fact]
    public unsafe void TestSetNextUpdates()
    {
        var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
        {
            ShaderInputAttachmentArrayDynamicIndexing = true
        };

        PhysicalDeviceFeatures2
            .Chain(out var features2)
            // SetNext accepts an existing struct, note, it will coerce the SType and blank the PNext
            .SetNext(ref indexingFeatures);

        Assert.Equal((nint) (&indexingFeatures), (nint) features2.PNext);
        Assert.Equal(0, (nint) indexingFeatures.PNext);

        Assert.Equal(StructureType.PhysicalDeviceFeatures2, features2.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures.SType);

        // Update indexing features
        var indexingFeatures2 = new PhysicalDeviceDescriptorIndexingFeatures
        {
            ShaderInputAttachmentArrayDynamicIndexing = false
        };
        features2.SetNext(ref indexingFeatures2);

        Assert.Equal((nint) (&indexingFeatures2), (nint) features2.PNext);
        Assert.Equal(0, (nint) indexingFeatures2.PNext);

        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures2.SType);

        Assert.Equal(1, features2.IndexOf(ref indexingFeatures2));
        Assert.True(features2.IndexOf(ref indexingFeatures) < 0);
    }

    [Fact]
    public unsafe void TestSetNextAlwaysAdd()
    {
        var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
        {
            ShaderInputAttachmentArrayDynamicIndexing = true
        };

        PhysicalDeviceFeatures2
            .Chain(out var features2)
            // SetNext accepts an existing struct, note, it will coerce the SType and blank the PNext
            .SetNext(ref indexingFeatures);

        Assert.Equal((nint) (&indexingFeatures), (nint) features2.PNext);
        Assert.Equal(0, (nint) indexingFeatures.PNext);

        Assert.Equal(StructureType.PhysicalDeviceFeatures2, features2.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures.SType);

        // Update indexing features
        var indexingFeatures2 = new PhysicalDeviceDescriptorIndexingFeatures
        {
            ShaderInputAttachmentArrayDynamicIndexing = false
        };
        features2.SetNext(ref indexingFeatures2, true);

        Assert.Equal((nint) (&indexingFeatures), (nint) features2.PNext);
        Assert.Equal((nint) (&indexingFeatures2), (nint) indexingFeatures.PNext);
        Assert.Equal(0, (nint) indexingFeatures2.PNext);

        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures2.SType);

        Assert.Equal(1, features2.IndexOf(ref indexingFeatures));
        Assert.Equal(2, features2.IndexOf(ref indexingFeatures2));
    }

    [Fact]
    public unsafe void TestWithoutChain()
    {
        // We don't have to use the BaseInStructure() pattern, as we can start with an existing struct
        var createInfo = new DeviceCreateInfo
        {
            Flags = 1U
        };
        // However, note that AddNext will still coerce the SType of createInfo.
        createInfo.AddNext(out PhysicalDeviceFeatures2 features2);
        Assert.Equal((nint) (&features2), (nint) createInfo.PNext);
        Assert.Equal(0, (nint) features2.PNext);

        // Note, even though we didn't use chain, we have still coerced the SType
        Assert.Equal(StructureType.DeviceCreateInfo, createInfo.SType);
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, features2.SType);

        Assert.Equal(1U, createInfo.Flags);
    }
}
