using Silk.NET.Vulkan;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using VMASharp;

namespace VMASharp
{
    internal class DedicatedAllocation : Allocation
    {
        internal DeviceMemory memory;
        internal IntPtr mappedData;

        public DedicatedAllocation(VulkanMemoryAllocator allocator, int memTypeIndex, DeviceMemory memory, SuballocationType suballocType, IntPtr mappedData, long size) : base(allocator, 0)
        {
            this.memory = memory;
            this.mappedData = mappedData;
            this.memoryTypeIndex = memTypeIndex;
        }

        public override DeviceMemory DeviceMemory => this.memory;

        public override long Offset { get => 0; internal set => throw new InvalidOperationException(); }

        public override IntPtr MappedData => this.mapCount != 0 ? this.mappedData : default;

        internal override bool CanBecomeLost => false;

        internal unsafe Result DedicatedAllocMap(out IntPtr pData)
        {
            if (this.mapCount != 0)
            {
                if ((this.mapCount & int.MaxValue) < int.MaxValue)
                {
                    Debug.Assert(this.mappedData != default);

                    pData = this.mappedData;
                    this.mapCount += 1;

                    return Result.Success;
                }
                else
                {
                    throw new InvalidOperationException("Dedicated allocation mapped too many times simultaneously");
                }
            }
            else
            {
                pData = default;

                IntPtr tmp;
                var res = VkApi.MapMemory(this.Allocator.Device, this.memory, 0, Vk.WholeSize, 0, (void**)&tmp);

                if (res == Result.Success)
                {
                    this.mappedData = tmp;
                    this.mapCount = 1;
                    pData = tmp;
                }

                return res;
            }
        }

        internal void DedicatedAllocUnmap()
        {
            if ((this.mapCount & int.MaxValue) != 0)
            {
                this.mapCount -= 1;

                if (this.mapCount == 0)
                {
                    this.mappedData = default;
                    VkApi.UnmapMemory(this.Allocator.Device, this.memory);
                }
            }
            else
            {
                throw new InvalidOperationException("Unmapping dedicated allocation not previously mapped");
            }
        }

        public void CalcStatsInfo(out StatInfo stats)
        {
            StatInfo.Init(out stats);
            stats.BlockCount = 1;
            stats.AllocationCount = 1;
            stats.UsedBytes = this.Size;
            stats.AllocationSizeMin = stats.AllocationSizeMax = this.Size;
        }

        public override IntPtr Map()
        {
            var res = DedicatedAllocMap(out var pData);

            if (res != Result.Success)
            {
                throw new MapMemoryException(res);
            }

            return pData;
        }

        public override void Unmap()
        {
            DedicatedAllocUnmap();
        }
    }
}
