#pragma warning disable CA1063

using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;

using Silk.NET.Vulkan;
using Buffer = Silk.NET.Vulkan.Buffer;
using System.Buffers;

namespace VMASharp
{
    /// <summary>
    /// The object containing details on a suballocation of Vulkan Memory
    /// </summary>
    public unsafe abstract class Allocation : IDisposable
    {
        internal VulkanMemoryAllocator Allocator { get; }

        protected Vk VkApi => Allocator.VkApi;

        protected long size;
        protected long alignment;
        private int lastUseFrameIndex;
        protected int memoryTypeIndex;
        protected int mapCount;
        private bool LostOrDisposed = false;

        /// <summary>
        /// Size of this allocation, in bytes.
        /// Value never changes, unless allocation is lost.
        /// </summary>
        public long Size
        {
            get
            {
                if (LostOrDisposed || lastUseFrameIndex == Helpers.FrameIndexLost)
                {
                    return 0;
                }

                return size;
            }
        }

        /// <summary>
        /// Memory type index that this allocation is from. Value does not change.
        /// </summary>
        public int MemoryTypeIndex { get => memoryTypeIndex; }

        /// <summary>
        /// Handle to Vulkan memory object.
        /// Same memory object can be shared by multiple allocations.
        /// It can change after call to vmaDefragment() if this allocation is passed to the function, or if allocation is lost.
        /// If the allocation is lost, it is equal to `VK_NULL_HANDLE`.
        /// </summary>
        public abstract DeviceMemory DeviceMemory { get; }

        /// <summary>
        /// Offset into deviceMemory object to the beginning of this allocation, in bytes. (deviceMemory, offset) pair is unique to this allocation.
        /// It can change after call to vmaDefragment() if this allocation is passed to the function, or if allocation is lost.
        /// </summary>
        public abstract long Offset { get; internal set; }

        internal abstract bool CanBecomeLost { get; }


        internal bool IsPersistantMapped
        {
            get => this.mapCount < 0;
        }

        internal int LastUseFrameIndex
        {
            get
            {
                return this.lastUseFrameIndex;
            }
        }

        internal long Alignment => this.alignment;

        public object? UserData { get; set; }

        internal Allocation(VulkanMemoryAllocator allocator, int currentFrameIndex)
        {
            this.Allocator = allocator;
            this.lastUseFrameIndex = currentFrameIndex;
        }

        /// <summary>
        /// If this allocation is mapped, returns a pointer to the mapped memory region. Returns Null otherwise.
        /// </summary>
        public abstract IntPtr MappedData { get; }

        public void Dispose()
        {
            if (!this.LostOrDisposed)
            {
                this.Allocator.FreeMemory(this);
                LostOrDisposed = true;
            }
        }

        public Result BindBufferMemory(Buffer buffer)
        {
            Debug.Assert(this.Offset >= 0);

            return this.Allocator.BindVulkanBuffer(buffer, this.DeviceMemory, this.Offset, null);
        }

        public unsafe Result BindBufferMemory(Buffer buffer, long allocationLocalOffset, IntPtr pNext)
        {
            return this.BindBufferMemory(buffer, allocationLocalOffset, (void*)pNext);
        }

        public unsafe Result BindBufferMemory(Buffer buffer, long allocationLocalOffset, void* pNext = null)
        {
            if ((ulong)allocationLocalOffset >= (ulong)this.Size)
            {
                throw new ArgumentOutOfRangeException(nameof(allocationLocalOffset));
            }

            return this.Allocator.BindVulkanBuffer(buffer, this.DeviceMemory, this.Offset + allocationLocalOffset, pNext);
        }

        public unsafe Result BindImageMemory(Image image)
        {
            return this.Allocator.BindVulkanImage(image, this.DeviceMemory, this.Offset, null);
        }

        public unsafe Result BindImageMemory(Image image, long allocationLocalOffset, IntPtr pNext)
        {
            return this.BindImageMemory(image, allocationLocalOffset, (void*)pNext);
        }

        public unsafe Result BindImageMemory(Image image, long allocationLocalOffset, void* pNext = null)
        {
            if ((ulong)allocationLocalOffset >= (ulong)this.Size)
            {
                throw new ArgumentOutOfRangeException(nameof(allocationLocalOffset));
            }

            return this.Allocator.BindVulkanImage(image, this.DeviceMemory, this.Offset + allocationLocalOffset, pNext);
        }

        internal bool MakeLost(int currentFrame, int frameInUseCount)
        {
            if (!this.CanBecomeLost)
            {
                throw new InvalidOperationException("Internal Exception, tried to make an allocation lost that cannot become lost.");
            }

            int localLastUseFrameIndex = this.lastUseFrameIndex;

            while (true)
            {
                if (localLastUseFrameIndex == Helpers.FrameIndexLost)
                {
                    Debug.Assert(false);
                    return false;
                }
                else if (localLastUseFrameIndex + frameInUseCount >= currentFrame)
                {
                    return false;
                }
                else
                {
                    var tmp = Interlocked.CompareExchange(ref this.lastUseFrameIndex, Helpers.FrameIndexLost, localLastUseFrameIndex);

                    if (tmp == localLastUseFrameIndex)
                    {
                        this.LostOrDisposed = true;
                        return true;
                    }

                    localLastUseFrameIndex = tmp;
                }
            }
        }

        public bool TouchAllocation()
        {
            if (this.LostOrDisposed)
            {
                return false;
            }

            int currFrameIndexLoc = this.Allocator.CurrentFrameIndex;
            int lastUseFrameIndexLoc = this.lastUseFrameIndex;

            if (this.CanBecomeLost)
            {
                while (true)
                {
                    if (lastUseFrameIndexLoc == Helpers.FrameIndexLost)
                    {
                        return false;
                    }
                    else if (lastUseFrameIndexLoc == currFrameIndexLoc)
                    {
                        return true;
                    }

                    lastUseFrameIndexLoc = Interlocked.CompareExchange(ref this.lastUseFrameIndex, currFrameIndexLoc, lastUseFrameIndexLoc);
                }
            }
            else
            {
                while (true)
                {
                    Debug.Assert(lastUseFrameIndexLoc != Helpers.FrameIndexLost);

                    if (lastUseFrameIndexLoc == currFrameIndexLoc)
                        break;

                    lastUseFrameIndexLoc = Interlocked.CompareExchange(ref this.lastUseFrameIndex, currFrameIndexLoc, lastUseFrameIndexLoc);
                }

                return true;
            }
        }

        /// <summary>
        /// Flushes a specified region of memory
        /// </summary>
        /// <param name="offset">Offset in this allocation</param>
        /// <param name="size">Size of region to flush</param>
        /// <returns>The result of the operation</returns>
        public Result Flush(long offset, long size)
        {
            return Allocator.FlushOrInvalidateAllocation(this, offset, size, CacheOperation.Flush);
        }

        /// <summary>
        /// Invalidates a specified region of memory
        /// </summary>
        /// <param name="offset">Offset in this allocation</param>
        /// <param name="size">Size of region to Invalidate</param>
        /// <returns>The result of the operation</returns>
        public Result Invalidate(long offset, long size)
        {
            return Allocator.FlushOrInvalidateAllocation(this, offset, size, CacheOperation.Invalidate);
        }

        public abstract IntPtr Map();

        public abstract void Unmap();

        public bool TryGetMemory<T>(out Memory<T> memory) where T: unmanaged
        {
            if (mapCount != 0)
            {
                int size = checked((int)this.Size);

                if (size >= sizeof(T))
                {
                    memory = new UnmanagedMemoryManager<T>((byte*)MappedData, size / sizeof(T)).Memory;

                    return true;
                }
            }

            memory = Memory<T>.Empty;
            return false;
        }

        public bool TryGetSpan<T>(out Span<T> span) where T: unmanaged
        {
            if (mapCount != 0)
            {
                int size = checked((int)this.Size);

                if (size >= sizeof(T))
                {
                    span = new Span<T>((void*)MappedData, size / sizeof(T));

                    return true;
                }
            }

            span = Span<T>.Empty;
            return false;
        }

        private unsafe sealed class UnmanagedMemoryManager<T> : MemoryManager<T> where T: unmanaged
        {
            private readonly T* Pointer;
            private readonly int ElementCount;

            public UnmanagedMemoryManager(void* ptr, int elemCount)
            {
                Pointer = (T*)ptr;
                ElementCount = elemCount;
            }

            protected override void Dispose(bool disposing)
            {
            }

            public override Span<T> GetSpan()
            {
                return new Span<T>(Pointer, ElementCount);
            }

            public override MemoryHandle Pin(int elementIndex = 0)
            {
                return new MemoryHandle(Pointer + elementIndex);
            }

            public override void Unpin()
            {
            }
        }
    }
}
