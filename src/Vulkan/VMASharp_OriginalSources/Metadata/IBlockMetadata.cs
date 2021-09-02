namespace VMASharp.Metadata
{
    /// <summary>
    /// Allocation book-keeping for individual Device Memory Blocks. 
    /// </summary>
    public interface IBlockMetadata
    {
        /// <summary>
        /// Must return the total block size
        /// </summary>
        long Size { get; }

        /// <summary>
        /// Number of allocations held in this block
        /// </summary>
        int AllocationCount { get; }

        /// <summary>
        /// Total free bytes in this block
        /// </summary>
        long SumFreeSize { get; }

        /// <summary>
        /// 
        /// </summary>
        long UnusedRangeSizeMax { get; }

        /// <summary>
        /// Does this block have 0 allocations?
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        /// Validates all data structures inside this object. Throws an exception if validation fails.
        /// Only called in Debug builds of VMASharp
        /// </summary>
        void Validate();

        void CalcAllocationStatInfo(out StatInfo outInfo);

        void AddPoolStats(ref PoolStats stats);

        /// <summary>
        /// Tries to find a place for suballocation with given parameters inside this block.
        /// If succeeded, fills pAllocationRequest and returns true.
        /// If failed, returns false.
        /// </summary>
        /// <param name="context">Contextual information for this allocation request</param>
        /// <param name="request"></param>
        /// <returns>Returns whether the method succeeds</returns>
        bool TryCreateAllocationRequest(in AllocationContext context, out AllocationRequest request);

        bool MakeRequestedAllocationsLost(int currentFrame, int frameInUseCount, ref AllocationRequest request);

        int MakeAllocationsLost(int currentFrame, int frameInUseCount);

        void CheckCorruption(nuint blockDataPointer);

        void Alloc(in AllocationRequest request, SuballocationType type, long allocSize, BlockAllocation allocation);

        void Free(BlockAllocation allocation);

        void FreeAtOffset(long offset);
    }
}
