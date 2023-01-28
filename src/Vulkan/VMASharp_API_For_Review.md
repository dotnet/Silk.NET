```cs
namespace VMASharp.Metadata
{
  public interface IBlockMetadata
  {
    long Size { get; }
    int AllocationCount { get; }
    long SumFreeSize { get; }
    long UnusedRangeSizeMax { get; }
    bool IsEmpty { get; }
    void Validate();
    void CalcAllocationStatInfo(out StatInfo outInfo);
    void AddPoolStats(ref PoolStats stats);
    bool TryCreateAllocationRequest(in AllocationContext context, out AllocationRequest request);
    bool MakeRequestedAllocationsLost(
      int currentFrame,
      int frameInUseCount,
      ref AllocationRequest request);
    int MakeAllocationsLost(int currentFrame, int frameInUseCount);
    void CheckCorruption(nuint blockDataPointer);
    void Alloc(
      in AllocationRequest request,
      SuballocationType type,
      long allocSize,
      BlockAllocation allocation);
    void Free(BlockAllocation allocation);
    void FreeAtOffset(long offset);
  }
}
namespace VMASharp
{
  public abstract class Allocation : IDisposable
  {
    public long Size { get; }
    public int MemoryTypeIndex { get; }
    public abstract DeviceMemory DeviceMemory { get; }
    public abstract long Offset { get; internal set; }
    public object? UserData { get; set; }
    public abstract nint MappedData { get; }
    public void Dispose();
    public Result BindBufferMemory(Buffer buffer);
    public Result BindBufferMemory(Buffer buffer, long allocationLocalOffset, nint pNext);
    public Result BindBufferMemory(Buffer buffer, long allocationLocalOffset, void* pNext = null);
    public Result BindImageMemory(Image image);
    public Result BindImageMemory(Image image, long allocationLocalOffset, nint pNext);
    public Result BindImageMemory(Image image, long allocationLocalOffset, void* pNext = null);
    public bool TouchAllocation();
    public Result Flush(long offset, long size);
    public Result Invalidate(long offset, long size);
    public abstract nint Map();
    public abstract void Unmap();
    public bool TryGetMemory<T>(out Memory<T> memory) where T : unmanaged;
    public bool TryGetSpan<T>(out Span<T> span) where T : unmanaged;
  }
  public struct AllocationBudget
  {
    public long BlockBytes;
    public long AllocationBytes;
    public long Usage;
    public long Budget;
    public AllocationBudget(long blockBytes, long allocationBytes, long usage, long budget);
  }
  public struct AllocationContext
  {
    public int CurrentFrame;
    public int FrameInUseCount;
    public long BufferImageGranularity;
    public long AllocationSize;
    public long AllocationAlignment;
    public AllocationStrategyFlags Strategy;
    public SuballocationType SuballocationType;
    public bool CanMakeOtherLost;
    public AllocationContext(
      int currentFrame,
      int framesInUse,
      long bufferImageGranularity,
      long allocationSize,
      long allocationAlignment,
      AllocationStrategyFlags strategy,
      SuballocationType suballocType,
      bool canMakeOtherLost);
  }
  [Flags]
  public enum AllocationCreateFlags
  {
    DedicatedMemory = 1,
    NeverAllocate = 2,
    Mapped = 4,
    CanBecomeLost = 8,
    CanMakeOtherLost = 16, // 0x00000010
    UpperAddress = 64, // 0x00000040
    DontBind = 128, // 0x00000080
    WithinBudget = 256, // 0x00000100
  }
  public struct AllocationCreateInfo
  {
    public AllocationCreateFlags Flags;
    public AllocationStrategyFlags Strategy;
    public MemoryUsage Usage;
    public MemoryPropertyFlags? RequiredFlags;
    public MemoryPropertyFlags? PreferredFlags;
    public uint MemoryTypeBits;
    public VulkanMemoryPool? Pool;
    public object? UserData;
    public AllocationCreateInfo(
      AllocationCreateFlags flags = (AllocationCreateFlags) 0,
      AllocationStrategyFlags strategy = (AllocationStrategyFlags) 0,
      MemoryUsage usage = MemoryUsage.Unknown,
      MemoryPropertyFlags? requiredFlags = 0,
      MemoryPropertyFlags? preferredFlags = 0,
      uint memoryTypeBits = 0,
      VulkanMemoryPool? pool = null,
      object? userData = null);
  }
  public class AllocationException : VulkanResultException
  {
    public AllocationException(string message);
    public AllocationException(string message, Exception? innerException);
    public AllocationException(Result res);
    public AllocationException(string message, Result res);
  }
  public struct AllocationPoolCreateInfo
  {
    public int MemoryTypeIndex;
    public PoolCreateFlags Flags;
    public long BlockSize;
    public int MinBlockCount;
    public int MaxBlockCount;
    public int FrameInUseCount;
    public Func<long, IBlockMetadata>? AllocationAlgorithmCreate;
    public AllocationPoolCreateInfo(
      int memoryTypeIndex,
      PoolCreateFlags flags = (PoolCreateFlags) 0,
      long blockSize = 0,
      int minBlockCount = 0,
      int maxBlockCount = 0,
      int frameInUseCount = 0,
      Func<long, IBlockMetadata>? allocationAlgorithemCreate = null);
  }
  public struct AllocationRequest
  {
    public const long LostAllocationCost = 1048576;
    public long Offset;
    public long SumFreeSize;
    public long SumItemSize;
    public long ItemsToMakeLostCount;
    public object Item;
    public object CustomData;
    public AllocationRequestType Type;
    public readonly long CalcCost();
  }
  public enum AllocationRequestType
  {
    Normal,
    UpperAddress
  }
  [Flags]
  public enum AllocationStrategyFlags
  {
    BestFit = 1,
    WorstFit = 2,
    FirstFit = 4,
    MinMemory = BestFit, // 0x00000001
    MinTime = FirstFit, // 0x00000004
    MinFragmentation = WorstFit, // 0x00000002
  }
  [Flags]
  public enum AllocatorCreateFlags
  {
    ExternallySyncronized = 1,
    ExtMemoryBudget = 8,
    AMDDeviceCoherentMemory = 16, // 0x00000010
    BufferDeviceAddress = 32, // 0x00000020
  }
  public sealed class BlockAllocation : Allocation
  {
    public override DeviceMemory DeviceMemory { get; }
    public override long Offset { get; internal set; }
    public override nint MappedData { get; }
    public override nint Map();
    public override void Unmap();
  }
  public class MapMemoryException : VulkanResultException
  {
    public MapMemoryException(string message);
    public MapMemoryException(Result res);
    public MapMemoryException(string message, Result res);
  }
  public enum MemoryUsage
  {
    Unknown,
    GPU_Only,
    CPU_Only,
    CPU_To_GPU,
    GPU_To_CPU,
    CPU_Copy,
    GPU_LazilyAllocated,
  }
  [Flags]
  public enum PoolCreateFlags
  {
    IgnoreBufferImageGranularity = 1,
    LinearAlgorithm = 16, // 0x00000010
    BuddyAlgorithm = 32, // 0x00000020
  }
  public struct PoolStats
  {
    public long Size;
    public long UnusedSize;
    public int AllocationCount;
    public int UnusedRangeCount;
    public long UnusedRangeSizeMax;
    public int BlockCount;
  }
  public struct StatInfo
  {
    public int BlockCount;
    public int AllocationCount;
    public int UnusedRangeCount;
    public long UsedBytes;
    public long UnusedBytes;
    public long AllocationSizeMin;
    public long AllocationSizeAvg;
    public long AllocationSizeMax;
    public long UnusedRangeSizeMin;
    public long UnusedRangeSizeAvg;
    public long UnusedRangeSizeMax;
  }
  public class Stats
  {
    public readonly StatInfo[] MemoryType;
    public readonly StatInfo[] MemoryHeap;
    public StatInfo Total;
  }
  public enum SuballocationType
  {
    Free,
    Unknown,
    Buffer,
    Image_Unknown,
    Image_Linear,
    Image_Optimal,
  }
  public class ValidationFailedException : ApplicationException
  {
  }
  public sealed class VulkanMemoryAllocator : IDisposable
  {
    public Device Device { get; }
    public VulkanMemoryAllocator(in VulkanMemoryAllocatorCreateInfo createInfo);
    public int CurrentFrameIndex { get; set; }
    public void Dispose();
    public ref readonly Silk.NET.Vulkan.PhysicalDeviceProperties PhysicalDeviceProperties { get; }
    public ref readonly PhysicalDeviceMemoryProperties MemoryProperties { get; }
    public MemoryPropertyFlags GetMemoryTypeProperties(int memoryTypeIndex);
    public int? FindMemoryTypeIndex(uint memoryTypeBits, in AllocationCreateInfo allocInfo);
    public int? FindMemoryTypeIndexForBufferInfo(
      in BufferCreateInfo bufferInfo,
      in AllocationCreateInfo allocInfo);
    public int? FindMemoryTypeIndexForImageInfo(
      in ImageCreateInfo imageInfo,
      in AllocationCreateInfo allocInfo);
    public Allocation AllocateMemory(
      in MemoryRequirements requirements,
      in AllocationCreateInfo createInfo);
    public Allocation AllocateMemoryForBuffer(
      Buffer buffer,
      in AllocationCreateInfo createInfo,
      bool BindToBuffer = false);
    public Allocation AllocateMemoryForImage(
      Image image,
      in AllocationCreateInfo createInfo,
      bool BindToImage = false);
    public Result CheckCorruption(uint memoryTypeBits);
    public Buffer CreateBuffer(
      in BufferCreateInfo bufferInfo,
      in AllocationCreateInfo allocInfo,
      out Allocation allocation);
    public Image CreateImage(
      in ImageCreateInfo imageInfo,
      in AllocationCreateInfo allocInfo,
      out Allocation allocation);
    public void FreeMemory(Allocation allocation);
    public Stats CalculateStats();
    public VulkanMemoryPool CreatePool(in AllocationPoolCreateInfo createInfo);
  }
  public sealed class VulkanMemoryPool : IDisposable
  {
    public VulkanMemoryAllocator Allocator { get; }
    public string Name { get; set; }
    public void Dispose();
    public int MakeAllocationsLost();
    public Result CheckForCorruption();
    public void GetPoolStats(out PoolStats stats);
  }
  public class VulkanResultException : ApplicationException
  {
    public readonly Silk.NET.Vulkan.Result? Result;
    public VulkanResultException(string message);
    public VulkanResultException(string message, Exception? innerException);
    public VulkanResultException(Silk.NET.Vulkan.Result res);
    public VulkanResultException(string message, Silk.NET.Vulkan.Result res);
  }
}
```
