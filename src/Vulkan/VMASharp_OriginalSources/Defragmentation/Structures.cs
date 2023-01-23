using System;
using System.Collections.Generic;
using System.Text;

using Silk.NET.Vulkan;
using VMASharp;
using Buffer = Silk.NET.Vulkan.Buffer;

namespace VMASharp.Defragmentation
{
    public struct DefragmentationInfo2
    {
        public DefragmentationFlags Flags;

        public Allocation[] Allocations;

        public bool[] AllocationsChanged;

        public VulkanMemoryPool[] Pools;

        public ulong MaxCPUBytesToMove;

        public int MaxCPUAllocationsToMove;

        public ulong MaxGPUBytesToMove;

        public int MaxGPUAllocationsToMove;

        public CommandBuffer CommandBuffer;
    }

    public struct DefragmentationPassMoveInfo
    {
        public Allocation Allocation;

        public DeviceMemory Memory;

        public ulong Offset;
    }

    public struct DefragmentationInfo
    {
        public ulong MaxBytesToMove;

        public int MaxAllocationsToMove;
    }

    public class DefragmentationStats
    {
        public long BytesMoved;

        public long BytesFreed;

        public int AllocationsMoved;

        public int DeviceMemoryBlocksFreed;
    }

    internal struct DefragmentationMove
    {
        public int SourceBlockIndex, DestinationBlockIndex;

        public ulong SourceOffset, DestinationOffset, Size;

        public Allocation Allocation;

        public VulkanMemoryBlock SourceBlock, DestinationBlock;
    }

    internal struct BlockDefragmentationContext
    { 
        public enum BlockFlags
        {
            Used = 0x01
        }

        public BlockFlags Flags;
        public Buffer Buffer;
    }
}
