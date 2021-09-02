using System;
using System.Collections.Generic;
using System.Text;

namespace VMASharp
{
    [Flags]
    public enum AllocatorCreateFlags
    {
        /// <summary>
        /// Tells the allocator to not use any internal locking, not currently respected
        /// </summary>
        ExternallySyncronized = 0x00000001,

        //KhrDedicatedAllocation = 0x00000002,

        //KhrBindMemory2 = 0x00000004,

        /// <summary>
        /// Enables usage of the VK_EXT_memory_budget extension.
        /// 
        /// You may set this flag only if you found out that this device extension is supported,
        /// enabled it on the device passed through <see cref="VulkanMemoryAllocatorCreateInfo.LogicalDevice"/>,
        /// and you want it to be used internally by this library.
        /// </summary>
        ExtMemoryBudget = 0x00000008,

        AMDDeviceCoherentMemory = 0x00000010,

        BufferDeviceAddress = 0x00000020
    }

    public enum MemoryUsage
    {
        /// <summary>
        /// No Intended memory usage specified
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Memory will be used on device only, so fast access from the device is preferred.
        /// It usually means device-local GPU (video) memory.
        /// No need to be mappable on host.
        /// It is roughly equivalent of `D3D12_HEAP_TYPE_DEFAULT`.
        /// </summary>
        /// <remarks>
        /// Usage:
        ///     - Resources written and read by device, e.g. images used as attachments.
        ///     - Resources transferred from host once (immutable) or infrequently and read by
        ///       device multiple times, e.g. textures to be sampled, vertex buffers, uniform
        ///       (constant) buffers, and majority of other types of resources used on GPU.
        /// 
        /// Allocation may still end up in `HOST_VISIBLE` memory on some implementations.
        /// In such case, you are free to map it.
        /// You can use #VMA_ALLOCATION_CREATE_MAPPED_BIT with this usage type.
        /// </remarks>
        GPU_Only,

        /// <summary>
        /// Memory will be mappable on host.
        /// It usually means CPU (system) memory.
        /// Guarantees to be `HOST_VISIBLE` and `HOST_COHERENT`.
        /// CPU access is typically uncached. Writes may be write-combined.
        /// Resources created in this pool may still be accessible to the device, but access to them can be slow.
        /// It is roughly equivalent of `D3D12_HEAP_TYPE_UPLOAD`.
        /// </summary>
        /// <remarks>
        /// Usage: Staging copy of resources used as transfer source.
        /// </remarks>
        CPU_Only,

        /// <summary>
        /// Memory that is mappable on host (guarantees to be `HOST_VISIBLE`) and preferably fast to access by GPU.
        /// CPU access is typically uncached. Writes may be write-combined.
        /// </summary>
        /// <remarks>
        /// Usage: Resources written frequently by host (dynamic), read by device. E.g. textures, vertex buffers, uniform buffers updated every frame or every draw call.
        /// </remarks>
        CPU_To_GPU,

        /// <summary>
        /// Memory mappable on host (guarantees to be `HOST_VISIBLE`) and cached.
        /// It is roughly equivalent of `D3D12_HEAP_TYPE_READBACK`.
        /// </summary>
        /// <remarks>
        /// Usage:
        ///     - Resources written by device, read by host - results of some computations, e.g. screen capture, average scene luminance for HDR tone mapping.
        ///     - Any resources read or accessed randomly on host, e.g. CPU-side copy of vertex buffer used as source of transfer, but also used for collision detection.
        /// </remarks>
        GPU_To_CPU,

        /// <summary>
        /// CPU memory - memory that is preferably not `DEVICE_LOCAL`, but also not guaranteed to be `HOST_VISIBLE`.
        /// </summary>
        /// <remarks>
        /// Usage: Staging copy of resources moved from GPU memory to CPU memory as part
        /// of custom paging/residency mechanism, to be moved back to GPU memory when needed.
        /// </remarks>
        CPU_Copy,

        /// <summary>
        /// Lazily allocated GPU memory having `VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT`.
        /// Exists mostly on mobile platforms. Using it on desktop PC or other GPUs with no such memory type present will fail the allocation.
        /// Allocations with this usage are always created as dedicated - it implies #VMA_ALLOCATION_CREATE_DEDICATED_MEMORY_BIT.
        /// </summary>
        /// <remarks>
        /// Usage: Memory for transient attachment images (color attachments, depth attachments etc.), created with `VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT`.
        /// </remarks>
        GPU_LazilyAllocated
    }

    [Flags]
    public enum AllocationCreateFlags
    {
        DedicatedMemory = 0x0001,
        NeverAllocate = 0x0002,
        Mapped = 0x0004,
        CanBecomeLost = 0x0008,
        CanMakeOtherLost = 0x0010,
        UpperAddress = 0x0040,
        DontBind = 0x0080,
        WithinBudget = 0x0100
    }

    [Flags]
    public enum AllocationStrategyFlags
    {
        BestFit = 0x1,
        WorstFit = 0x2,
        FirstFit = 0x4,
        MinMemory = BestFit,
        MinTime = FirstFit,
        MinFragmentation = WorstFit
    }

    [Flags]
    public enum PoolCreateFlags
    {
        IgnoreBufferImageGranularity = 0x0001,
        LinearAlgorithm = 0x0010,
        BuddyAlgorithm = 0x0020
    }

    public enum DefragmentationFlags
    {
        Incremental = 0x1
    }

    public enum SuballocationType
    {
        Free = 0,
        Unknown,
        Buffer,
        Image_Unknown,
        Image_Linear,
        Image_Optimal
    }

    public enum AllocationRequestType
    {
        Normal,
        UpperAddress,
        EndOfList1,
        EndOfList2
    }

    internal enum CacheOperation
    {
        Flush,
        Invalidate
    }
}
