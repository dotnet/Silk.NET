using System;
using System.Collections.Generic;
using System.Text;

using Silk.NET.Vulkan;

namespace VMASharp.Defragmentation
{
    internal class BlockListDefragmentationContext
    {
        public Result Result;
        public bool MutexLocked;

        public readonly List<BlockDefragmentationContext> blockContexts = new List<BlockDefragmentationContext>();
        public readonly List<DefragmentationMove> DefragMoves = new List<DefragmentationMove>();

        public int DefragMovesProcessed, DefragMovedCommitted;
        public bool HasDefragmentationPlanned;


        public BlockListDefragmentationContext(VulkanMemoryAllocator allocator, VulkanMemoryPool? customPool, BlockList list, uint currentFrame)
        {

        }

        public VulkanMemoryPool? CustomPool { get; }

        public BlockList BlockList { get; }

        public DefragmentationAlgorithm Algorithm { get; }

    }
}
