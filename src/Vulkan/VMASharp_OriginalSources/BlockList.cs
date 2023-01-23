using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Linq;

using Silk.NET.Vulkan;

namespace VMASharp
{
    using Metadata;

    internal class BlockList : IDisposable
    {
        private const int AllocationTryCount = 32;

        private readonly List<VulkanMemoryBlock> blocks = new List<VulkanMemoryBlock>();
        private readonly ReaderWriterLockSlim mutex = new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);

        private readonly int minBlockCount, maxBlockCount;
        private readonly bool explicitBlockSize;

        private readonly Func<long, IBlockMetadata> metaObjectCreate;

        private bool hasEmptyBlock;
        private uint nextBlockID;

        public BlockList(VulkanMemoryAllocator allocator, VulkanMemoryPool? pool, int memoryTypeIndex,
            long preferredBlockSize, int minBlockCount, int maxBlockCount, long bufferImageGranularity,
            int frameInUseCount, bool explicitBlockSize, Func<long, IBlockMetadata> algorithm)
        {
            this.Allocator = allocator;
            this.ParentPool = pool;
            this.MemoryTypeIndex = memoryTypeIndex;
            this.PreferredBlockSize = preferredBlockSize;
            this.minBlockCount = minBlockCount;
            this.maxBlockCount = maxBlockCount;
            this.BufferImageGranularity = bufferImageGranularity;
            this.FrameInUseCount = frameInUseCount;
            this.explicitBlockSize = explicitBlockSize;

            metaObjectCreate = algorithm;
        }

        public void Dispose()
        {
            foreach (var block in this.blocks)
            {
                block.Dispose();
            }
        }

        public VulkanMemoryAllocator Allocator { get; }

        public VulkanMemoryPool? ParentPool { get; }

        public bool IsCustomPool { get => this.ParentPool != null; }

        public int MemoryTypeIndex { get; }

        public long PreferredBlockSize { get; }

        public long BufferImageGranularity { get; }

        public int FrameInUseCount { get; }

        public bool IsEmpty
        {
            get
            {
                this.mutex.EnterReadLock();

                try
                {
                    return this.blocks.Count == 0;
                }
                finally
                {
                    this.mutex.ExitReadLock();
                }
            }
        }

        public bool IsCorruptedDetectionEnabled { get => false; }

        public int BlockCount { get => blocks.Count; }

        public VulkanMemoryBlock this[int index]
        {
            get => blocks[index];
        }

        private IEnumerable<VulkanMemoryBlock> BlocksInReverse //Just gonna take advantage of C#...
        {
            get
            {
                List<VulkanMemoryBlock> localList = this.blocks;

                for (int index = localList.Count - 1; index >= 0; --index)
                {
                    yield return localList[index];
                }
            }
        }

        public void CreateMinBlocks()
        {
            if (this.blocks.Count > 0)
            {
                throw new InvalidOperationException("Block list not empty");
            }

            for (int i = 0; i < this.minBlockCount; ++i)
            {
                var res = this.CreateBlock(this.PreferredBlockSize, out _);

                if (res != Result.Success)
                {
                    throw new AllocationException("Unable to allocate device memory block", res);
                }
            }
        }

        public void GetPoolStats(out PoolStats stats)
        {
            this.mutex.EnterReadLock();

            try
            {
                stats = new PoolStats();
                stats.BlockCount = this.blocks.Count;

                foreach (var block in this.blocks)
                {
                    Debug.Assert(block != null);

                    block.Validate();

                    block.MetaData.AddPoolStats(ref stats);
                }
            }
            finally
            {
                this.mutex.ExitReadLock();
            }
        }

        public Allocation Allocate(int currentFrame, long size, long alignment, in AllocationCreateInfo allocInfo, SuballocationType suballocType)
        {
            this.mutex.EnterWriteLock();

            try
            {
                return this.AllocatePage(currentFrame, size, alignment, allocInfo, suballocType);
            }
            finally
            {
                this.mutex.ExitWriteLock();
            }
        }

        public void Free(Allocation allocation)
        {
            VulkanMemoryBlock? blockToDelete = null;

            bool budgetExceeded = false;
            {
                int heapIndex = this.Allocator.MemoryTypeIndexToHeapIndex(this.MemoryTypeIndex);
                this.Allocator.GetBudget(heapIndex, out var budget);
                budgetExceeded = budget.Usage >= budget.Budget;
            }

            this.mutex.EnterWriteLock();

            try
            {
                var blockAlloc = (BlockAllocation)allocation;

                VulkanMemoryBlock block = blockAlloc.Block;

                //Corruption Detection TODO

                if (allocation.IsPersistantMapped)
                {
                    block.Unmap(1);
                }

                block.MetaData.Free(blockAlloc);

                block.Validate();

                bool canDeleteBlock = this.blocks.Count > this.minBlockCount;

                if (block.MetaData.IsEmpty)
                {
                    if ((this.hasEmptyBlock || budgetExceeded) && canDeleteBlock)
                    {
                        blockToDelete = block;
                        this.Remove(block);
                    }
                }
                else if (this.hasEmptyBlock && canDeleteBlock)
                {
                    block = this.blocks[^1];

                    if (block.MetaData.IsEmpty)
                    {
                        blockToDelete = block;
                        this.blocks.RemoveAt(this.blocks.Count - 1);
                    }
                }

                this.UpdateHasEmptyBlock();
                this.IncrementallySortBlocks();
            }
            finally
            {
                this.mutex.ExitWriteLock();
            }

            if (blockToDelete != null)
            {
                blockToDelete.Dispose();
            }
        }

        public void AddStats(Stats stats)
        {
            var memTypeIndex = this.MemoryTypeIndex;
            var memHeapIndex = this.Allocator.MemoryTypeIndexToHeapIndex(memTypeIndex);

            this.mutex.EnterReadLock();

            try
            {
                foreach (var block in this.blocks)
                {
                    Debug.Assert(block != null);
                    block.Validate();

                    block.MetaData.CalcAllocationStatInfo(out var info);
                    StatInfo.Add(ref stats.Total, info);
                    StatInfo.Add(ref stats.MemoryType[memTypeIndex], info);
                    StatInfo.Add(ref stats.MemoryHeap[memHeapIndex], info);
                }
            }
            finally
            {
                this.mutex.ExitReadLock();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentFrame"></param>
        /// <returns>
        /// Lost Allocation Count
        /// </returns>
        public int MakePoolAllocationsLost(int currentFrame)
        {
            this.mutex.EnterWriteLock();

            try
            {
                int lostAllocationCount = 0;

                foreach (var block in this.blocks)
                {
                    Debug.Assert(block != null);

                    lostAllocationCount += block.MetaData.MakeAllocationsLost(currentFrame, this.FrameInUseCount);
                }

                return lostAllocationCount;
            }
            finally
            {
                this.mutex.ExitWriteLock();
            }
        }

        public Result CheckCorruption()
        {
            throw new NotImplementedException();
        }

        public int CalcAllocationCount()
        {
            int res = 0;

            foreach (var block in blocks)
            {
                res += block.MetaData.AllocationCount;
            }

            return res;
        }

        public bool IsBufferImageGranularityConflictPossible()
        {
            if (BufferImageGranularity == 1)
                return false;

            SuballocationType lastSuballocType = SuballocationType.Free;

            foreach (var block in blocks)
            {
                var metadata = block.MetaData as BlockMetadata_Generic;
                Debug.Assert(metadata != null);

                if (metadata.IsBufferImageGranularityConflictPossible(this.BufferImageGranularity, ref lastSuballocType))
                {
                    return true;
                }
            }

            return false;
        }

        private long CalcMaxBlockSize()
        {
            long result = 0;

            for (int i = this.blocks.Count - 1; i >= 0; --i)
            {
                var blockSize = this.blocks[i].MetaData.Size;

                if (result < blockSize)
                {
                    result = blockSize;
                }

                if (result >= this.PreferredBlockSize)
                {
                    break;
                }
            }

            return result;
        }

        [SkipLocalsInit]
        private Allocation AllocatePage(int currentFrame, long size, long alignment, in AllocationCreateInfo createInfo, SuballocationType suballocType)
        {
            bool canMakeOtherLost = (createInfo.Flags & AllocationCreateFlags.CanMakeOtherLost) != 0;
            bool mapped = (createInfo.Flags & AllocationCreateFlags.Mapped) != 0;

            long freeMemory;

            {
                int heapIndex = this.Allocator.MemoryTypeIndexToHeapIndex(this.MemoryTypeIndex);

                this.Allocator.GetBudget(heapIndex, out AllocationBudget heapBudget);

                freeMemory = (heapBudget.Usage < heapBudget.Budget) ? (heapBudget.Budget - heapBudget.Usage) : 0;
            }

            bool canFallbackToDedicated = !this.IsCustomPool;
            bool canCreateNewBlock = ((createInfo.Flags & AllocationCreateFlags.NeverAllocate) == 0) && (this.blocks.Count < this.maxBlockCount) && (freeMemory >= size || !canFallbackToDedicated);

            var strategy = createInfo.Strategy;

            //if (this.algorithm == (uint)PoolCreateFlags.LinearAlgorithm && this.maxBlockCount > 1)
            //{
            //    canMakeOtherLost = false;
            //}

            //if (isUpperAddress && (this.algorithm != (uint)PoolCreateFlags.LinearAlgorithm || this.maxBlockCount > 1))
            //{
            //    throw new AllocationException("Upper address allocation unavailable", Result.ErrorFeatureNotPresent);
            //}

            switch (strategy)
            {
                case 0:
                    strategy = AllocationStrategyFlags.BestFit;
                    break;
                case AllocationStrategyFlags.BestFit:
                case AllocationStrategyFlags.WorstFit:
                case AllocationStrategyFlags.FirstFit:
                    break;
                default:
                    throw new AllocationException("Invalid allocation strategy", Result.ErrorFeatureNotPresent);
            }

            if (size + 2 * Helpers.DebugMargin > this.PreferredBlockSize)
            {
                throw new AllocationException("Allocation size larger than block size", Result.ErrorOutOfDeviceMemory);
            }

            AllocationContext context = new AllocationContext(
                currentFrame,
                this.FrameInUseCount,
                this.BufferImageGranularity,
                size,
                alignment,
                strategy,
                suballocType,
                canMakeOtherLost);

            Allocation? alloc;

            if (!canMakeOtherLost || canCreateNewBlock)
            {
                AllocationCreateFlags allocFlagsCopy = createInfo.Flags & ~AllocationCreateFlags.CanMakeOtherLost;

                if (strategy == AllocationStrategyFlags.BestFit)
                {
                    foreach (var block in this.blocks)
                    {
                        alloc = this.AllocateFromBlock(block, in context, allocFlagsCopy, createInfo.UserData);

                        if (alloc != null)
                        {
                            //Possibly Log here
                            return alloc;
                        }
                    }
                }
                else
                {
                    foreach (var curBlock in this.BlocksInReverse)
                    {
                        alloc = this.AllocateFromBlock(curBlock, in context, allocFlagsCopy, createInfo.UserData);

                        if (alloc != null)
                        {
                            //Possibly Log here
                            return alloc;
                        }
                    }
                }
            }

            if (canCreateNewBlock)
            {
                AllocationCreateFlags allocFlagsCopy = createInfo.Flags & ~AllocationCreateFlags.CanMakeOtherLost;

                long newBlockSize = this.PreferredBlockSize;
                int newBlockSizeShift = 0;
                const int NewBlockSizeShiftMax = 3;

                if (!this.explicitBlockSize)
                {
                    long maxExistingBlockSize = this.CalcMaxBlockSize();

                    for (int i = 0; i < NewBlockSizeShiftMax; ++i)
                    {
                        long smallerNewBlockSize = newBlockSize / 2;
                        if (smallerNewBlockSize > maxExistingBlockSize && smallerNewBlockSize >= size * 2)
                        {
                            newBlockSize = smallerNewBlockSize;
                            newBlockSizeShift += 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                int newBlockIndex = 0;

                var res = (newBlockSize <= freeMemory || !canFallbackToDedicated) ? this.CreateBlock(newBlockSize, out newBlockIndex) : Result.ErrorOutOfDeviceMemory;

                if (!this.explicitBlockSize)
                {
                    while (res < 0 && newBlockSizeShift < NewBlockSizeShiftMax)
                    {
                        long smallerNewBlockSize = newBlockSize / 2;

                        if (smallerNewBlockSize >= size)
                        {
                            newBlockSize = smallerNewBlockSize;
                            newBlockSizeShift += 1;
                            res = (newBlockSize <= freeMemory || !canFallbackToDedicated) ? this.CreateBlock(newBlockSize, out newBlockIndex) : Result.ErrorOutOfDeviceMemory;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if (res == Result.Success)
                {
                    var block = this.blocks[newBlockIndex];

                    alloc = this.AllocateFromBlock(block, in context, allocFlagsCopy, createInfo.UserData);

                    if (alloc != null)
                    {
                        //Possibly Log here
                        return alloc;
                    }
                }
            }

            if (canMakeOtherLost)
            {
                int tryIndex = 0;

                for (; tryIndex < AllocationTryCount; ++tryIndex)
                {
                    VulkanMemoryBlock? bestRequestBlock = null;

                    Unsafe.SkipInit(out AllocationRequest bestAllocRequest);

                    long bestRequestCost = long.MaxValue;

                    if (strategy == AllocationStrategyFlags.BestFit)
                    {
                        foreach (var curBlock in this.blocks)
                        {
                            if (curBlock.MetaData.TryCreateAllocationRequest(in context, out var request))
                            {
                                long currRequestCost = request.CalcCost();

                                if (bestRequestBlock == null || currRequestCost < bestRequestCost)
                                {
                                    bestRequestBlock = curBlock;
                                    bestAllocRequest = request;
                                    bestRequestCost = currRequestCost;

                                    if (bestRequestCost == 0)
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var curBlock in this.BlocksInReverse)
                        {
                            if (curBlock.MetaData.TryCreateAllocationRequest(in context, out var request))
                            {
                                long curRequestCost = request.CalcCost();

                                if (bestRequestBlock == null || curRequestCost < bestRequestCost || strategy == AllocationStrategyFlags.FirstFit)
                                {
                                    bestRequestBlock = curBlock;
                                    bestRequestCost = curRequestCost;
                                    bestAllocRequest = request;

                                    if (bestRequestCost == 0 || strategy == AllocationStrategyFlags.FirstFit)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    if (bestRequestBlock != null)
                    {
                        if (mapped)
                        {
                            bestRequestBlock.Map(1);
                        }

                        if (bestRequestBlock.MetaData.MakeRequestedAllocationsLost(currentFrame, this.FrameInUseCount, ref bestAllocRequest))
                        {
                            var talloc = new BlockAllocation(this.Allocator, this.Allocator.CurrentFrameIndex);

                            bestRequestBlock.MetaData.Alloc(in bestAllocRequest, suballocType, size, talloc);

                            this.UpdateHasEmptyBlock();

                            //(allocation as BlockAllocation).InitBlockAllocation();

                            try
                            {
                                bestRequestBlock.Validate(); //Won't be called in release builds
                            }
                            catch
                            {
                                talloc.Dispose();
                                throw;
                            }

                            talloc.UserData = createInfo.UserData;

                            this.Allocator.Budget.AddAllocation(this.Allocator.MemoryTypeIndexToHeapIndex(this.MemoryTypeIndex), size);

                            //Maybe put memory init and corruption detection here

                            return talloc;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (tryIndex == AllocationTryCount)
                {
                    throw new AllocationException("", Result.ErrorTooManyObjects);
                }
            }

            throw new AllocationException("Unable to allocate memory");
        }

        private Allocation? AllocateFromBlock(VulkanMemoryBlock block, in AllocationContext context, AllocationCreateFlags flags, object? userData)
        {
            Debug.Assert((flags & AllocationCreateFlags.CanMakeOtherLost) == 0);
            bool mapped = (flags & AllocationCreateFlags.Mapped) != 0;

            if (block.MetaData.TryCreateAllocationRequest(in context, out var request))
            {
                Debug.Assert(request.ItemsToMakeLostCount == 0);

                if (mapped)
                {
                    block.Map(1);
                }

                var allocation = new BlockAllocation(this.Allocator, this.Allocator.CurrentFrameIndex);
                
                block.MetaData.Alloc(in request, context.SuballocationType, context.AllocationSize, allocation);

                allocation.InitBlockAllocation(block, request.Offset, context.AllocationAlignment, context.AllocationSize, this.MemoryTypeIndex,
                                               context.SuballocationType, mapped, (flags & AllocationCreateFlags.CanBecomeLost) != 0);
                
                this.UpdateHasEmptyBlock();

                block.Validate();

                allocation.UserData = userData;

                this.Allocator.Budget.AddAllocation(this.Allocator.MemoryTypeIndexToHeapIndex(this.MemoryTypeIndex), context.AllocationSize);

                return allocation;
            }

            return null;
        }

        private unsafe Result CreateBlock(long blockSize, out int newBlockIndex)
        {
            newBlockIndex = -1;

            MemoryAllocateInfo info = new MemoryAllocateInfo
            {
                SType = StructureType.MemoryAllocateInfo,
                MemoryTypeIndex = (uint)this.MemoryTypeIndex,
                AllocationSize = (ulong)blockSize
            };

            // Every standalone block can potentially contain a buffer with BufferUsageFlags.BufferUsageShaderDeviceAddressBitKhr - always enable the feature
            MemoryAllocateFlagsInfoKHR allocFlagsInfo = new MemoryAllocateFlagsInfoKHR(StructureType.MemoryAllocateFlagsInfoKhr);
            if (Allocator.UseKhrBufferDeviceAddress)
            {
                allocFlagsInfo.Flags = MemoryAllocateFlags.MemoryAllocateDeviceAddressBitKhr;
                info.PNext = &allocFlagsInfo;
            }

            var res = this.Allocator.AllocateVulkanMemory(in info, out DeviceMemory mem);

            if (res < 0)
            {
                return res;
            }

            var metaObject = this.metaObjectCreate(blockSize);

            if (metaObject.Size != blockSize)
            {
                throw new InvalidOperationException("Returned Metadata object reports incorrect block size");
            }

            var block = new VulkanMemoryBlock(this.Allocator, this.ParentPool, this.MemoryTypeIndex, mem, this.nextBlockID++, metaObject);

            this.blocks.Add(block);

            newBlockIndex = this.blocks.Count - 1;

            return Result.Success;
        }

        private void FreeEmptyBlocks(ref Defragmentation.DefragmentationStats stats)
        {
            for (int i = this.blocks.Count - 1; i >= 0; --i)
            {
                var block = this.blocks[i];

                if (block.MetaData.IsEmpty)
                {
                    if (this.blocks.Count > this.minBlockCount)
                    {
                        stats.DeviceMemoryBlocksFreed += 1;
                        stats.BytesFreed += block.MetaData.Size;

                        this.blocks.RemoveAt(i);
                        block.Dispose();
                    }
                    else
                    {
                        break;
                    }
                }
            }

            this.UpdateHasEmptyBlock();
        }

        private void UpdateHasEmptyBlock()
        {
            this.hasEmptyBlock = false;

            foreach (var block in blocks)
            {
                if (block.MetaData.IsEmpty)
                {
                    this.hasEmptyBlock = true;
                    break;
                }
            }
        }

        private void Remove(VulkanMemoryBlock block)
        {
            var res = blocks.Remove(block);
            Debug.Assert(res, "");
        }

        private void IncrementallySortBlocks()
        {
            if ((uint)this.blocks.Count > 1)
            {
                var prevBlock = this.blocks[0];
                int i = 1;

                do
                {
                    var curBlock = this.blocks[i];

                    if (prevBlock.MetaData.SumFreeSize > curBlock.MetaData.SumFreeSize)
                    {
                        this.blocks[i - 1] = curBlock;
                        this.blocks[i] = prevBlock;
                        return;
                    }

                    prevBlock = curBlock;
                    i += 1;
                }
                while (i < this.blocks.Count);
            }
        }

        public class DefragmentationContext
        {
            private readonly BlockList List;

            public DefragmentationContext(BlockList list)
            {
                this.List = list;
            }

            //public void Defragment(DefragmentationStats stats, DefragmentationFlags flags, ulong maxCpuBytesToMove, )

            //public void End(DefragmentationStats stats)

            //public uint ProcessDefragmentations(DefragmentationPassMoveInfo move, uint maxMoves)

            //public void CommitDefragmentations(DefragmentationStats stats)
        }


    }
}
