using System;
using System.Linq;
using Xunit;

namespace Silk.NET.Vulkan.Tests;

public class TestChains
{
    [Fact]
    public unsafe void TestChain()
    {
        using var chain = Chain.Create
        (
            default(PhysicalDeviceFeatures2),
            default(PhysicalDeviceDescriptorIndexingFeatures),
            default(PhysicalDeviceAccelerationStructureFeaturesKHR)
        );

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);
        Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, chain.Item2.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
        Assert.Equal(0, (nint) chain.Item2.PNext);
    }

    [Fact]
    public unsafe void TestChainReplaceHead()
    {
        using var chain =
            Chain.Create
            (
                default(DeviceCreateInfo),
                default(PhysicalDeviceFeatures2),
                default(PhysicalDeviceDescriptorIndexingFeatures)
            );

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.DeviceCreateInfo, chain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Item1.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item2.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
        Assert.Equal(0, (nint) chain.Item2.PNext);

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
    public unsafe void TestChainReplaceMiddle()
    {
        using var chain = Chain.Create<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
            PhysicalDeviceAccelerationStructureFeaturesKHR>
        (
            item1: new PhysicalDeviceDescriptorIndexingFeatures
            {
                // We can set any non-default values, note we do not need to set SType or PNext
                // indeed they will be overwritten.
                ShaderInputAttachmentArrayDynamicIndexing = true
            }
        );

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);
        Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, chain.Item2.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
        Assert.Equal(0, (nint) chain.Item2.PNext);

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
        Assert.Equal(0, (nint) chain.Item2.PNext);

        // As is the SType
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);
        chain.Dispose();
    }

    [Fact]
    public unsafe void TestChainDuplicate()
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

        using var newChain = chain.Duplicate();

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal(0, (nint) chain.Item1.PNext);

        // Check flag set
        Assert.True(chain.Item1.ShaderInputAttachmentArrayDynamicIndexing);

        // Check we have new copies
        Assert.NotEqual((nint) chain.HeadPtr, (nint) newChain.HeadPtr);
        Assert.NotEqual((nint) chain.Item1Ptr, (nint) newChain.Item1Ptr);

        // Test equality
        Assert.Equal(chain.Head with {PNext = null}, newChain.Head with {PNext = null});
        Assert.Equal(chain.Item1, newChain.Item1);
        Assert.Equal((nint)chain.Head.PNext, (nint)chain.Item1Ptr);
        Assert.True(chain == newChain);

        // Modify second chain
        newChain.Item1 = default;

        // Test equality
        Assert.NotEqual(chain, newChain);
        Assert.False(chain == newChain);
    }

    [Fact]
    public unsafe void TestChainAdd()
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

        using var newChain = chain.Add(default(PhysicalDeviceAccelerationStructureFeaturesKHR));

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, newChain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, newChain.Item1.SType);
        Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, newChain.Item2.SType);

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
    public unsafe void TestChainTruncate()
    {
        using var chain =
            Chain.Create<
                PhysicalDeviceFeatures2,
                PhysicalDeviceDescriptorIndexingFeatures,
                PhysicalDeviceAccelerationStructureFeaturesKHR>
            (
                item2: new PhysicalDeviceAccelerationStructureFeaturesKHR
                    {AccelerationStructure = true}
            );

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);
        Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, chain.Item2.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
        Assert.Equal(0, (nint) chain.Item2.PNext);

        // Check flag set
        Assert.True(chain.Item2.AccelerationStructure);

        using var newChain = chain.Truncate(out var accelerationStructure);

        Assert.Equal(2, newChain.Count);

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, newChain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, newChain.Item1.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) newChain.Item1Ptr, (nint) newChain.Head.PNext);
        Assert.Equal(0, (nint) newChain.Item1.PNext);

        // Check removed type flag
        Assert.True(accelerationStructure.AccelerationStructure);

        // Check we have new copies
        Assert.NotEqual((nint) chain.HeadPtr, (nint) newChain.HeadPtr);
        Assert.NotEqual((nint) chain.Item1Ptr, (nint) newChain.Item1Ptr);
    }

    [Fact]
    public unsafe void TestChainLoad()
    {
        // Load an unmanaged chain
        var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
        {
            ShaderInputAttachmentArrayDynamicIndexing = true
        };
        PhysicalDeviceFeatures2
            .Chain(out var unmanagedChain)
            .SetNext(ref indexingFeatures)
            .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);

        // Loads a new managed chain from an unmanaged chain
        using var managedChain =
            Chain.Load<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
                PhysicalDeviceAccelerationStructureFeaturesKHR>(out var errors, unmanagedChain);

        // Check we had no loading errors
        Assert.Equal("", errors);

        // Check the flag still set
        Assert.True(managedChain.Item1.ShaderInputAttachmentArrayDynamicIndexing);

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, managedChain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, managedChain.Item1.SType);
        Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, managedChain.Item2.SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) managedChain.Item1Ptr, (nint) managedChain.Head.PNext);
        Assert.Equal((nint) managedChain.Item2Ptr, (nint) managedChain.Item1.PNext);
        Assert.Equal(0, (nint) managedChain.Item2.PNext);
    }

    [Fact]
    public void TestChainLoadWithError()
    {
        var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
        {
            ShaderInputAttachmentArrayDynamicIndexing = true
        };
        // Load an unmanaged chain
        DeviceCreateInfo
            .Chain(out var unmanagedChain)
            .AddNext(out PhysicalDeviceFeatures2 features2)
            .SetNext(ref indexingFeatures)
            .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);

        // Loads a new managed chain from an unmanaged chain
        using var managedChain =
            Chain.Load<
                DeviceCreateInfo,
                // Note we are supplied a PhysicalDeviceFeatures2 here from the unmanaged chain
                PhysicalDeviceAccelerationStructureFeaturesKHR,
                PhysicalDeviceDescriptorIndexingFeatures,
                PhysicalDeviceAccelerationStructureFeaturesKHR,
                // Note that the unmanaged chain did not supply a 5th entry
                PhysicalDeviceFeatures2>(out var errors, unmanagedChain);

        // Check for errors
        var errorsArray = errors.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
        Assert.Equal(2, errorsArray.Length);
        Assert.Equal
        (
            "The unmanaged chain has a structure type PhysicalDeviceFeatures2 at position 2; expected PhysicalDeviceAccelerationStructureFeatures",
            // PATCH: Due to the way ToString() interacts with enum aliases, the structure types may end in Khr, so removing. 
            errorsArray[0].Replace("Khr", "")
        );
        Assert.Equal
        (
            "The unmanaged chain was length 4, expected length 5", errorsArray[1]
        );

        // Despite the errors indexing features was at the right location so was loaded
        Assert.True(managedChain.Item2.ShaderInputAttachmentArrayDynamicIndexing);
    }

    [Fact]
    public void TestChainLoadWithErrorTooLong()
    {
        var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
        {
            ShaderInputAttachmentArrayDynamicIndexing = true
        };
        // Load an unmanaged chain
        DeviceCreateInfo
            .Chain(out var unmanagedChain)
            .AddNext(out PhysicalDeviceFeatures2 features2)
            .SetNext(ref indexingFeatures)
            .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);

        // Try loading a shorter managed chain
        using var managedChain =
            Chain.Load<
                DeviceCreateInfo,
                PhysicalDeviceFeatures2,
                PhysicalDeviceDescriptorIndexingFeatures>(out var errors, unmanagedChain);

        // Check for errors
        Assert.Equal(@"The unmanaged chain was longer than the expected length 3", errors);

        // Despite the errors indexing features was at the right location so was loaded
        Assert.True(managedChain.Item2.ShaderInputAttachmentArrayDynamicIndexing);
    }

    [Fact]
    public void TestReadOnlyList()
    {
        using var chain = Chain.Create<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
            PhysicalDeviceAccelerationStructureFeaturesKHR>();

        Assert.Equal(3, chain.Count);

        // Ensure all STypes set correctly using indexer
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain[0].StructureType());
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain[1].StructureType());
        Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, chain[2].StructureType());

        Assert.Throws<IndexOutOfRangeException>(() => chain[3]);

        // Get array using IEnumerable implementation
        var structures = chain.ToArray();

        // Check concrete types
        Assert.IsType<PhysicalDeviceFeatures2>(structures[0]);
        Assert.IsType<PhysicalDeviceDescriptorIndexingFeatures>(structures[1]);
        Assert.IsType<PhysicalDeviceAccelerationStructureFeaturesKHR>(structures[2]);
    }

    [Fact]
    public void TestDeconstructor()
    {
        using var chain = Chain.Create<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
            PhysicalDeviceAccelerationStructureFeaturesKHR>();

        var (physicalDeviceFeatures2, indexingFeatures, accelerationStructureFeaturesKhr) = chain;

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, physicalDeviceFeatures2.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures.SType);
        Assert.Equal
            (StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, accelerationStructureFeaturesKhr.SType);
    }

    [Fact]
    public unsafe void TestChainGetHashCode()
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

        using var newChain = chain.Duplicate();

        // Ensure all STypes set correctly
        Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);

        Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1Ptr->SType);

        // Ensure pointers set correctly
        Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
        Assert.Equal(0, (nint) chain.Item1.PNext);

        // Check flag set
        Assert.True(chain.Item1.ShaderInputAttachmentArrayDynamicIndexing);

        // Check we have new copies
        Assert.NotEqual((nint) chain.HeadPtr, (nint) newChain.HeadPtr);
        Assert.NotEqual((nint) chain.Item1Ptr, (nint) newChain.Item1Ptr);

        // Test equality
        Assert.Equal(chain.Head with {PNext = null}, newChain.Head with {PNext = null});
        Assert.Equal(chain.Item1, newChain.Item1);
        Assert.Equal((nint)chain.Head.PNext, (nint)chain.Item1Ptr);
        Assert.True(chain == newChain);
        var hashCode = chain.GetHashCode();
        var newHashCode = newChain.GetHashCode();
        Assert.Equal(hashCode, newHashCode);

        // Modify second chain
        newChain.Item1 = default;

        // Test equality
        Assert.NotEqual(chain, newChain);
        Assert.False(chain == newChain);
        Assert.Equal(hashCode, chain.GetHashCode());
        var newHashCode2 = newChain.GetHashCode();
        Assert.NotEqual(hashCode, newHashCode2);
        Assert.NotEqual(newHashCode, newHashCode2);
    }

    [Fact]
    public void TestClear()
    {
        using var chain = Chain.Create
        (
            new PhysicalDeviceFeatures2 {Features = new PhysicalDeviceFeatures {AlphaToOne = true}},
            new PhysicalDeviceDescriptorIndexingFeatures {ShaderInputAttachmentArrayDynamicIndexing = true},
            new PhysicalDeviceAccelerationStructureFeaturesKHR {AccelerationStructure = true}
        );

        Assert.True(chain.Head.Features.AlphaToOne);
        Assert.True(chain.Item1.ShaderInputAttachmentArrayDynamicIndexing);
        Assert.True(chain.Item2.AccelerationStructure);

        // Don't clear the head
        chain.Clear(false);

        Assert.True(chain.Head.Features.AlphaToOne);
        Assert.False(chain.Item1.ShaderInputAttachmentArrayDynamicIndexing);
        Assert.False(chain.Item2.AccelerationStructure);

        // Clear the head
        chain.Clear();

        Assert.False(chain.Head.Features.AlphaToOne);
        Assert.False(chain.Item1.ShaderInputAttachmentArrayDynamicIndexing);
        Assert.False(chain.Item2.AccelerationStructure);
    }

    [Fact]
    public unsafe void TestImplicitCastsToPointers()
    {
        using var chain = Chain.Create<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
            PhysicalDeviceAccelerationStructureFeaturesKHR>();

        PhysicalDeviceFeatures2* p = chain;
        Assert.Equal((nint)p, (nint)chain.HeadPtr);
        
        BaseInStructure* b = chain;
        Assert.Equal((nint)b, (nint)chain.HeadPtr);
        
        void* v = chain;
        Assert.Equal((nint)v, (nint)chain.HeadPtr);

        nint n = chain;
        Assert.Equal(n, (nint)chain.HeadPtr);
    }
}
