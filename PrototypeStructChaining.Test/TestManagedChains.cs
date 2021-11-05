using Silk.Net.Vulkan;
using Xunit;

namespace PrototypeStructChaining.Test;

public class TestManagedChains
{
    [Fact]
    public unsafe void TestManagedChain()
    {
        using var chain = new ManagedChain<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
            PhysicalDeviceAccelerationStructureFeaturesKHR>();

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);
        Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, chain.Item2.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
        Assert.Equal((nint) 0, (nint) chain.Item2.PNext);
    }

    [Fact]
    public unsafe void TestManagedChainReplaceHead()
    {
        using var chain =
            new ManagedChain<DeviceCreateInfo, PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures>();

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.DeviceCreateInfo, chain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Item1.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item2.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
        Assert.Equal((nint) 0, (nint) chain.Item2.PNext);

        Assert.Equal(0U, chain.Head.Flags);

        var headPtr = chain.HeadPtr;

        // Get the current head
        var head = chain.Head;
        // Update the flags
        head.Flags = 1U;
        // Update the chain
        chain.Head = head;

        Assert.Equal(1U, chain.Head.Flags);

        // The head ptr should not change, we overwrite it with the new value
        Assert.Equal((nint) headPtr, (nint) chain.HeadPtr);
        // But the next pointer should not change
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
    }

    [Fact]
    public unsafe void TestManagedChainReplaceMiddle()
    {
        using var chain = new ManagedChain<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
            PhysicalDeviceAccelerationStructureFeaturesKHR>(item1: new PhysicalDeviceDescriptorIndexingFeatures
        {
            // We can set any non-default values, note we do not need to set SType or PNext
            // indeed they will be overwritten.
            ShaderInputAttachmentArrayDynamicIndexing = true
        });

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);
        Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, chain.Item2.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
        Assert.Equal((nint) 0, (nint) chain.Item2.PNext);

        // Check our value was set
        Assert.True(chain.Item1.ShaderInputAttachmentArrayDynamicIndexing);

        var item1Ptr = chain.Item1Ptr;

        // Overwrite Item1
        chain.Item1 = new PhysicalDeviceDescriptorIndexingFeatures
        {
            // Again we do not need to set SType or PNext, which will be set to the correct values
            ShaderInputAttachmentArrayDynamicIndexing = false
        };

        // Check our value was cleared
        Assert.False(chain.Item1.ShaderInputAttachmentArrayDynamicIndexing);

        // Note all the pointers are still correct (and have not changed)
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
        Assert.Equal((nint) 0, (nint) chain.Item2.PNext);

        // As is the SType
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);
    }
    
    [Fact]
    public unsafe void TestManagedChainAppend()
    {
        using var chain = new ManagedChain<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures>(
            item1: new PhysicalDeviceDescriptorIndexingFeatures {ShaderInputAttachmentArrayDynamicIndexing = true});

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal((nint) 0, (nint) chain.Item1.PNext);
        
        // Check flag set
        Assert.True(chain.Item1.ShaderInputAttachmentArrayDynamicIndexing);

        using var newChain = chain.Append<PhysicalDeviceAccelerationStructureFeaturesKHR>();
        
        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, newChain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, newChain.Item1.SType);
        Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, newChain.Item2.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) newChain.Item1Ptr, (nint) newChain.Head.PNext);
        Assert.Equal((nint) newChain.Item2Ptr, (nint) newChain.Item1.PNext);
        Assert.Equal((nint) 0, (nint) newChain.Item2.PNext);
        
        // Check flag still set
        Assert.True(newChain.Item1.ShaderInputAttachmentArrayDynamicIndexing);
        
        // Check we have new copies
        Assert.NotEqual((nint) chain.HeadPtr, (nint) newChain.HeadPtr);
        Assert.NotEqual((nint) chain.Item1Ptr, (nint) newChain.Item1Ptr);
    }
}