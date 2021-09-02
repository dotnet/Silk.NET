using Silk.NET.Vulkan;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using VMASharp;

namespace VMASharp
{
    public sealed class BlockAllocation : Allocation
    {
        internal VulkanMemoryBlock Block;
        internal long offset;
        internal SuballocationType suballocationType;
        internal bool canBecomeLost;

        internal BlockAllocation(VulkanMemoryAllocator allocator, int currentFrameIndex) : base(allocator, currentFrameIndex)
        {
        }

        public override DeviceMemory DeviceMemory
        {
            get => this.Block.DeviceMemory;
        }

        public override long Offset
        {
            get => this.offset;
            internal set => this.offset = value;
        }

        public override IntPtr MappedData
        {
            get
            {
                if (this.mapCount != 0)
                {
                    IntPtr mapdata = this.Block.MappedData;

                    Debug.Assert(mapdata != default);

                    return new IntPtr(mapdata.ToInt64() + this.offset);
                }
                else
                {
                    return default;
                }
            }
        }

        internal override bool CanBecomeLost => this.canBecomeLost;

        internal void InitBlockAllocation(VulkanMemoryBlock block, long offset, long alignment, long size, int memoryTypeIndex, SuballocationType subType, bool mapped, bool canBecomeLost)
        {
            this.Block = block;
            this.offset = offset;
            this.alignment = alignment;
            this.size = size;
            this.memoryTypeIndex = memoryTypeIndex;
            this.mapCount = mapped ? int.MinValue : 0;
            this.suballocationType = subType;
            this.canBecomeLost = canBecomeLost;
        }

        internal void ChangeAllocation(VulkanMemoryBlock block, long offset)
        {
            Debug.Assert(block != null && offset >= 0);

            if (!object.ReferenceEquals(block, this.Block))
            {
                int mapRefCount = this.mapCount & int.MaxValue;

                if (this.IsPersistantMapped)
                {
                    mapRefCount += 1;
                }

                this.Block.Unmap(mapRefCount);
                block.Map(mapRefCount);

                this.Block = block;
            }

            this.Offset = offset;
        }

        private void BlockAllocMap()
        {
            if ((this.mapCount & int.MaxValue) < int.MaxValue)
            {
                this.mapCount += 1;
            }
            else
            {
                throw new InvalidOperationException("Allocation mapped too many times simultaniously");
            }
        }

        private void BlockAllocUnmap()
        {
            if ((this.mapCount & int.MaxValue) > 0)
            {
                this.mapCount -= 1;
            }
            else
            {
                throw new InvalidOperationException("Unmapping allocation not previously mapped");
            }
        }

        public override IntPtr Map()
        {
            if (this.CanBecomeLost)
            {
                throw new InvalidOperationException("Cannot map an allocation that can become lost");
            }

            var data = this.Block.Map(1);

            data = new IntPtr(data.ToInt64() + this.Offset);

            this.BlockAllocMap();

            return data;
        }

        public override void Unmap()
        {
            this.BlockAllocUnmap();
            this.Block.Unmap(1);
        }
    }
}
