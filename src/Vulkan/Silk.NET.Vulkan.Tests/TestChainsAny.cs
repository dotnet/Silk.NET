using Xunit;

namespace Silk.NET.Vulkan.Tests;

public class TestChainsAny
{
    [Fact]
    public unsafe void TestChainAny()
    {
        using var chain = Chain.CreateAny
        (
            default(PhysicalDeviceFeatures2),
            default(PhysicalDeviceDescriptorIndexingFeatures),
            default(DeviceCreateInfo)
        );

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);
        Assert.Equal(StructureType.DeviceCreateInfo, chain.Item2.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
        Assert.Equal(0, (nint) chain.Item2.PNext);
    }

    [Fact]
    public unsafe void TestChainDuplicateAny()
    {
        using var chain = Chain.CreateAny<PhysicalDeviceFeatures2, DeviceCreateInfo>
        (
            item1: new DeviceCreateInfo {Flags = 1U}
        );

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
        Assert.Equal(StructureType.DeviceCreateInfo, chain.Item1.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal(0, (nint) chain.Item1.PNext);

        // Check flag set
        Assert.Equal(1U, chain.Item1.Flags);

        using var newChain = chain.Duplicate();

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
        Assert.Equal(StructureType.DeviceCreateInfo, chain.Item1.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal(0, (nint) chain.Item1.PNext);

        // Check flag set
        Assert.Equal(1U, chain.Item1.Flags);

        // Check we have new copies
        Assert.NotEqual((nint) chain.HeadPtr, (nint) newChain.HeadPtr);
        Assert.NotEqual((nint) chain.Item1Ptr, (nint) newChain.Item1Ptr);
        
        // Test equality
        Assert.Equal(chain.Head with {PNext = null}, newChain.Head with {PNext = null});
        Assert.Equal(chain.Item1, newChain.Item1);
        Assert.Equal((nint)chain.Head.PNext, (nint)chain.Item1Ptr);
        Assert.True(chain == newChain);
    }

    [Fact]
    public unsafe void TestChainAddAny()
    {
        using var chain = Chain.Create<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures>
        (
            item1: new PhysicalDeviceDescriptorIndexingFeatures {ShaderInputAttachmentArrayDynamicIndexing = true}
        );

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal(0, (nint) chain.Item1.PNext);

        // Check flag set
        Assert.True(chain.Item1.ShaderInputAttachmentArrayDynamicIndexing);

        using var newChain = chain.AddAny(default(DeviceCreateInfo));

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, newChain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, newChain.Item1.SType);
        Assert.Equal(StructureType.DeviceCreateInfo, newChain.Item2.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) newChain.Item1Ptr, (nint) newChain.Head.PNext);
        Assert.Equal((nint) newChain.Item2Ptr, (nint) newChain.Item1.PNext);
        Assert.Equal(0, (nint) newChain.Item2.PNext);

        // Check flag still set
        Assert.True(newChain.Item1.ShaderInputAttachmentArrayDynamicIndexing);

        // Check we have new copies
        Assert.NotEqual((nint) chain.HeadPtr, (nint) newChain.HeadPtr);
        Assert.NotEqual((nint) chain.Item1Ptr, (nint) newChain.Item1Ptr);
    }

    [Fact]
    public unsafe void TestChainTruncateAny()
    {
        using var chain =
            Chain.CreateAny<
                PhysicalDeviceFeatures2,
                PhysicalDeviceDescriptorIndexingFeatures,
                DeviceCreateInfo>
            (
                item2: new DeviceCreateInfo {Flags = 1U}
            );

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);
        Assert.Equal(StructureType.DeviceCreateInfo, chain.Item2.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
        Assert.Equal(0, (nint) chain.Item2.PNext);

        // Check flag set
        Assert.Equal(1U, chain.Item2.Flags);

        using var newChain = chain.TruncateAny(out var deviceCreateInfo);
        
        Assert.Equal(2, newChain.Count);
        
        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, newChain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, newChain.Item1.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) newChain.Item1Ptr, (nint) newChain.Head.PNext);
        Assert.Equal(0, (nint) newChain.Item1.PNext);

        // Check removed type flag
        Assert.Equal(1U, deviceCreateInfo.Flags);

        // Check we have new copies
        Assert.NotEqual((nint) chain.HeadPtr, (nint) newChain.HeadPtr);
        Assert.NotEqual((nint) chain.Item1Ptr, (nint) newChain.Item1Ptr);
        
        // NOTE: As the new chain is valid, we can use Truncate on it
        using var finalChain = newChain.Truncate(out var indexingFeatures);
    }

    [Fact]
    public unsafe void TestChainLoadAny()
    {
        // Load an unmanaged chain
        var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
        {
            ShaderInputAttachmentArrayDynamicIndexing = true
        };
        PhysicalDeviceFeatures2
            .Chain(out var unmanagedChain)
            .SetNext(ref indexingFeatures)
            .AddNextAny(out DeviceCreateInfo deviceCreateInfo);

        // Loads a new managed chain from an unmanaged chain
        using var managedChain =
            Chain.LoadAny<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
                DeviceCreateInfo>(out var errors, unmanagedChain);

        // Check we had no loading errors
        Assert.Equal("", errors);

        // Check the flag still set
        Assert.True(managedChain.Item1.ShaderInputAttachmentArrayDynamicIndexing);

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, managedChain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, managedChain.Item1.SType);
        Assert.Equal(StructureType.DeviceCreateInfo, managedChain.Item2.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) managedChain.Item1Ptr, (nint) managedChain.Head.PNext);
        Assert.Equal((nint) managedChain.Item2Ptr, (nint) managedChain.Item1.PNext);
        Assert.Equal(0, (nint) managedChain.Item2.PNext);
    }
}
