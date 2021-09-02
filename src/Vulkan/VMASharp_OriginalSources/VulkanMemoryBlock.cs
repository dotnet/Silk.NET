using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using Silk.NET.Vulkan;
using Buffer = Silk.NET.Vulkan.Buffer;

namespace VMASharp
{
    using Metadata;

    internal class VulkanMemoryBlock : IDisposable
    {
        private Vk VkApi => Allocator.VkApi;

        private readonly VulkanMemoryAllocator Allocator;
        internal readonly IBlockMetadata MetaData;
        private readonly object SyncLock = new object();
        private int mapCount;


        public VulkanMemoryBlock(VulkanMemoryAllocator allocator, VulkanMemoryPool? pool, int memoryTypeIndex, DeviceMemory memory, uint id, IBlockMetadata metaObject)
        {
            Allocator = allocator;
            ParentPool = pool;
            MemoryTypeIndex = memoryTypeIndex;
            DeviceMemory = memory;
            ID = id;

            MetaData = metaObject;
        }

        public VulkanMemoryPool? ParentPool { get; }

        public DeviceMemory DeviceMemory { get; }

        public int MemoryTypeIndex { get; }

        public uint ID { get; }

        public IntPtr MappedData { get; private set; }

        public void Dispose()
        {
            if (!this.MetaData.IsEmpty)
            {
                throw new InvalidOperationException("Some allocations were not freed before destruction of this memory block!");
            }

            Debug.Assert(this.DeviceMemory.Handle != default);

            this.Allocator.FreeVulkanMemory(this.MemoryTypeIndex, this.MetaData.Size, this.DeviceMemory);
        }

        [Conditional("DEBUG")]
        public void Validate()
        {
            Helpers.Validate(this.DeviceMemory.Handle != default && this.MetaData.Size > 0);

            MetaData.Validate();
        }

        public void CheckCorruption(VulkanMemoryAllocator allocator)
        {
            var data = this.Map(1);

            try
            {
                this.MetaData.CheckCorruption((nuint)(nint)data);
            }
            finally
            {
                this.Unmap(1);
            }
        }

        public unsafe IntPtr Map(int count)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            lock (this.SyncLock)
            {
                Debug.Assert(this.mapCount >= 0);

                if (this.mapCount > 0)
                {
                    Debug.Assert(this.MappedData != default);

                    this.mapCount += count;
                    return this.MappedData;
                }
                else
                {
                    if (count == 0)
                    {
                        return default;
                    }

                    IntPtr pData;
                    var res = VkApi.MapMemory(this.Allocator.Device, this.DeviceMemory, 0, Vk.WholeSize, 0, (void**)&pData);

                    if (res != Result.Success)
                    {
                        throw new MapMemoryException(res);
                    }

                    this.mapCount = count;
                    this.MappedData = pData;

                    return pData;
                }
            }
        }

        public void Unmap(int count)
        {
            if (count == 0)
            {
                return;
            }

            lock (this.SyncLock)
            {
                int newCount = this.mapCount - count;

                if (newCount < 0)
                {
                    throw new InvalidOperationException("Memory block is being unmapped while it was not previously mapped");
                }

                this.mapCount = newCount;
                
                if (newCount == 0)
                {
                    this.MappedData = default;
                    VkApi.UnmapMemory(this.Allocator.Device, this.DeviceMemory);
                }
            }
        }

        public unsafe Result BindBufferMemory(Allocation allocation, long allocationLocalOffset, Buffer buffer, void* pNext)
        {
            Debug.Assert(allocation is BlockAllocation blockAlloc && blockAlloc.Block == this);

            Debug.Assert((ulong)allocationLocalOffset < (ulong)allocation.Size, "Invalid allocationLocalOffset. Did you forget that this offset is relative to the beginning of the allocation, not the whole memory block?");

            long memoryOffset = allocationLocalOffset + allocation.Offset;

            lock (SyncLock)
            {
                return this.Allocator.BindVulkanBuffer(buffer, this.DeviceMemory, memoryOffset, pNext);
            }
        }

        public unsafe Result BindImageMemory(Allocation allocation, long allocationLocalOffset, Image image, void* pNext)
        {
            Debug.Assert(allocation is BlockAllocation blockAlloc && blockAlloc.Block == this);

            Debug.Assert((ulong)allocationLocalOffset < (ulong)allocation.Size, "Invalid allocationLocalOffset. Did you forget that this offset is relative to the beginning of the allocation, not the whole memory block?");

            long memoryOffset = allocationLocalOffset + allocation.Offset;

            lock (this.SyncLock)
            {
                return this.Allocator.BindVulkanImage(image, this.DeviceMemory, memoryOffset, pNext);
            }
        }
    }
}
