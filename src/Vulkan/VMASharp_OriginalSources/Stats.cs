using System;
using Silk.NET.Vulkan;

namespace VMASharp
{
    public struct StatInfo
    {
        public int BlockCount, AllocationCount, UnusedRangeCount;
        public long UsedBytes, UnusedBytes;
        public long AllocationSizeMin, AllocationSizeAvg, AllocationSizeMax;
        public long UnusedRangeSizeMin, UnusedRangeSizeAvg, UnusedRangeSizeMax;

        internal static void Init(out StatInfo info)
        {
            info = default;
            info.AllocationSizeMin = long.MaxValue;
            info.UnusedRangeSizeMin = long.MaxValue;
        }

        internal static void Add(ref StatInfo info, in StatInfo other)
        {
            info.BlockCount += other.BlockCount;
            info.AllocationCount += other.AllocationCount;
            info.UnusedRangeCount += other.UnusedRangeCount;
            info.UsedBytes += other.UsedBytes;
            info.UnusedBytes += other.UnusedBytes;

            if (info.AllocationSizeMin > other.AllocationSizeMin)
            {
                info.AllocationSizeMin = other.AllocationSizeMin;
            }

            if (info.AllocationSizeMax < other.AllocationSizeMax)
            {
                info.AllocationSizeMax = other.AllocationSizeMax;
            }

            if (info.UnusedRangeSizeMin > other.UnusedRangeSizeMin)
            {
                info.UnusedRangeSizeMin = other.UnusedRangeSizeMin;
            }

            if (info.UnusedRangeSizeMax < other.UnusedRangeSizeMax)
            {
                info.UnusedRangeSizeMax = other.UnusedRangeSizeMax;
            }
        }

        internal static void PostProcessCalcStatInfo(ref StatInfo info)
        {
            info.AllocationSizeAvg = info.UsedBytes / info.AllocationCount;
            info.UnusedRangeSizeAvg = info.UnusedBytes / info.UnusedRangeCount;
        }
    }

    public class Stats
    {
        public readonly StatInfo[] MemoryType;
        public readonly StatInfo[] MemoryHeap;
        public StatInfo Total;

        internal Stats(StatInfo[] memoryTypes, StatInfo[] memoryHeaps, in StatInfo total)
        {
            MemoryType = memoryTypes;
            MemoryHeap = memoryHeaps;
            Total = total;
        }

        internal Stats()
        {
            StatInfo.Init(out StatInfo total);

            MemoryType = new StatInfo[Vk.MaxMemoryTypes];
            MemoryHeap = new StatInfo[Vk.MaxMemoryHeaps];

            for (int i = 0; i < Vk.MaxMemoryTypes; ++i)
                StatInfo.Init(out MemoryType[i]);

            for (int i = 0; i < Vk.MaxMemoryHeaps; ++i)
                StatInfo.Init(out MemoryHeap[i]);
        }

        internal void PostProcess()
        {
            StatInfo.PostProcessCalcStatInfo(ref this.Total);

            for (int i = 0; i < Vk.MaxMemoryTypes; ++i)
                StatInfo.PostProcessCalcStatInfo(ref this.MemoryType[i]);

            for (int i = 0; i < Vk.MaxMemoryHeaps; ++i)
                StatInfo.PostProcessCalcStatInfo(ref this.MemoryHeap[i]);
        }
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
}
