using System;
using System.Collections.Generic;
using System.Text;

using Silk.NET.Vulkan;

namespace VMASharp.Defragmentation
{
    internal abstract class DefragmentationAlgorithm : IDisposable
    {
        protected readonly VulkanMemoryAllocator Allocator;
        protected readonly BlockList BlockList;
        protected readonly uint CurrentFrame;

        protected DefragmentationAlgorithm(VulkanMemoryAllocator allocator, BlockList list, uint currentFrame)
        {
            this.Allocator = allocator;
            this.BlockList = list;
            this.CurrentFrame = currentFrame;
        }

        public abstract ulong BytesMoved { get; }

        public abstract int AllocationsMoved { get; }

        public virtual void Dispose()
        {
        }

        public abstract void AddAllocation(Allocation alloc, out bool changed);

        public abstract void AddAll();

        public abstract Result Defragment(ulong maxBytesToMove, int maxAllocationsToMove, DefragmentationFlags flags, out DefragmentationMove[] moves);

        protected class AllocateInfo
        {
            public Allocation Allocation;
            public bool Changed;

            public AllocateInfo()
            { }

            public AllocateInfo(Allocation allocation)
            {
                this.Allocation = allocation;
            }
        }
    }
}
