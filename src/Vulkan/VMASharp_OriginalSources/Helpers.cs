using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Silk.NET.Core;

namespace VMASharp
{
    internal static class Helpers
    {
        public const long MinFreeSuballocationSizeToRegister = 16;
        public const int FrameIndexLost = -1;
        public const uint CorruptionDetectionMagicValue = 0x7F84E666;

        public const byte AllocationFillPattern_Created = 0xDC;
        public const byte AllocationFillPattern_Destroyed = 0xEF;
        public const bool DebugInitializeAllocations = false;

        public const long DebugMargin = 0;
        public const long DebugAlignment = 1;
        public const long DebugMinBufferImageGranularity = 1;

        public const AllocationStrategyFlags InternalAllocationStrategy_MinOffset = (AllocationStrategyFlags)0x10000000u;

        internal static readonly Version32 VulkanAPIVersion_1_0 = new Version32(1, 0, 0);
        internal static readonly Version32 VulkanAPIVersion_1_1 = new Version32(1, 1, 0);

        public static readonly Comparison<LinkedListNode<Suballocation>> SuballocationNodeItemSizeLess = (first, second) => first.Value.Size.CompareTo(second.Value.Size);
        public static readonly Comparison<Suballocation> SuballocationItemSizeLess = (first, second) => first.Size.CompareTo(second.Size);

        public static readonly Func<long, Metadata.IBlockMetadata> DefaultMetaObjectCreate = size => new Metadata.BlockMetadata_Generic(size);

        public static bool IsPow2(int v)
        {
            return BitOperations.PopCount((uint)v) == 1;
        }

        public static bool IsPow2(long v)
        {
            return BitOperations.PopCount((ulong)v) == 1;
        }

        public static int NextPow2(int v)
        {
            if (IsPow2(v))
                return v;

            return 1 << (32 - BitOperations.LeadingZeroCount((uint)v));
        }

        public static long NextPow2(long v)
        {
            if (IsPow2(v))
                return v;

            return 1L << (64 - BitOperations.LeadingZeroCount((ulong)v));
        }

        public static int PrevPow(int v)
        {
            return 1 << (31 - BitOperations.LeadingZeroCount((uint)v));
        }

        public static long PrevPow(long v)
        {
            return 1L << (63 - BitOperations.LeadingZeroCount((ulong)v));
        }

        public static bool BlocksOnSamePage(long resourceAOffset, long resourceASize, long resourceBOffset, long pageSize)
        {
            Debug.Assert(resourceAOffset + resourceASize <= resourceBOffset && resourceASize > 0 && pageSize > 0);

            long resourceAEnd = resourceAOffset + resourceASize - 1;
            long resourceAEndPage = resourceAEnd & ~(pageSize - 1);
            long resourceBStart = resourceBOffset;
            long resourceBStartPage = resourceBStart & ~(pageSize - 1);
            return resourceAEndPage == resourceBStartPage;
        }

        public static bool IsBufferImageGranularityConflict(SuballocationType type1, SuballocationType type2)
        {
            if (type1 > type2)
            {
                //Swap
                var type3 = type1;
                type1 = type2;
                type2 = type3;
            }

            switch(type1)
            {
                case SuballocationType.Free:
                    return false;
                case SuballocationType.Unknown:
                    return true;
                case SuballocationType.Buffer:
                    return type2 == SuballocationType.Image_Unknown || type2 == SuballocationType.Image_Optimal;
                case SuballocationType.Image_Unknown:
                    return type2 == SuballocationType.Image_Unknown || type2 == SuballocationType.Image_Linear || type2 == SuballocationType.Image_Optimal;
                case SuballocationType.Image_Linear:
                    return type2 == SuballocationType.Image_Optimal;
                case SuballocationType.Image_Optimal:
                    return false;
                default:
                    Debug.Assert(false);
                    return true;
            }
        }

        public static long AlignUp(long value, long alignment)
        {
            return ((value + alignment - 1) / alignment) * alignment;
        }

        public static long AlignDown(long value, long alignment)
        {
            return (long)((ulong)value / (ulong)alignment * (ulong)alignment);
        }

        public interface IComparer_Single<T>
        {
            int Compare(T item);
        }

        public interface IComparer_Normal<T>
        {
            int Compare(T l, T r);
        }

        public static int BinarySearch<T, TComp>(this List<T> list, T value, TComp comp) where TComp : struct, IComparer_Normal<T>
        {
            int begin = 0, end = list.Count - 1;

            while (begin <= end)
            {
                int mid = (begin + end) / 2;

                int comparison = comp.Compare(list[mid], value);

                if (comparison == 0)
                {
                    return mid;
                }

                if (comparison < 0)
                {
                    begin = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return ~begin;
        }

        public static int BinarySearch<T, TState>(this List<T> list, TState state, Func<T, TState, int> SearchCompare)
        {
            int begin = 0, end = list.Count - 1;

            while (begin <= end)
            {
                int mid = (begin + end) / 2;

                int comparison = SearchCompare(list[mid], state);

                if (comparison == 0)
                {
                    return mid;
                }

                if (comparison < 0)
                {
                    begin = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return ~begin;
        }

        public static int BinarySearch<T>(this List<T> list, T value, Comparison<T> comparer)
        {
            int begin = 0, end = list.Count - 1;

            while (begin <= end)
            {
                int mid = (begin + end) / 2;

                int comparison = comparer(list[mid], value);

                if (comparison == 0)
                {
                    return mid;
                }

                if (comparison < 0)
                {
                    begin = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return ~begin;
        }

        public static int BinarySearch_Leftmost<T, TComp>(this List<T> list, TComp comp) where TComp : struct, IComparer_Single<T>
        {
            int begin = 0, end = list.Count, comparison = -1;

            while (begin < end)
            {
                int mid = (begin + end) / 2;

                comparison = comp.Compare(list[mid]);

                if (comparison < 0)
                {
                    begin = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }

            return (comparison == 0) ? begin : ~begin;
        }

        public static int BinarySearch_Leftmost<T>(this List<T> list, T value, Comparison<T> comparer)
        {
            int begin = 0, end = list.Count;

            while (begin < end)
            {
                int mid = (begin + end) / 2;

                int comparison = comparer(list[mid], value);

                if (comparison < 0)
                {
                    begin = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }

            return (comparer(list[begin], value) == 0) ? begin : ~begin;
        }

        public static int InsertSorted<T>(this List<T> list, T value)
        {
            int i = list.BinarySearch(value);

            if (i < 0)
            {
                i = ~i;
            }

            list.Insert(i, value);

            return i;
        }

        public static int InsertSorted<T>(this List<T> list, T value, Comparison<T> comparison)
        {
            int i = list.BinarySearch(value, comparison);

            if (i < 0)
            {
                i = ~i;
            }
            
            list.Insert(i, value);

            return i;
        }

        public static int FindIndex<T, TState>(this List<T> list, TState state, Func<T, TState, bool> predicate)
        {
            for (int i = 0; i < list.Count; ++i)
            {
                if (predicate(list[i], state))
                {
                    return i;
                }
            }

            return -1;
        }

        [Conditional("DEBUG")]
        public static void AssertNotNull<T>(this T instance) where T: class
        {
            Debug.Assert(instance != null);
        }

        [Conditional("DEBUG")]
        public static void AssertNotNull(this IntPtr ptr)
        {
            Debug.Assert(ptr != default);
        }

        public static void Validate([System.Diagnostics.CodeAnalysis.DoesNotReturnIf(false)] bool assertion)
        {
            if (!assertion)
            {
                throw new ValidationFailedException();
            }
        }
    }
}
