// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// ReSharper disable SwapViaDeconstruction
namespace Silk.NET.Input;

internal static class SortExtensions
{
    extension<T>(Span<T> span) where T : unmanaged
    {
        /// <summary>
        /// Sorts the given span of items using the given comparison, using merge sort.
        /// </summary>
        /// <param name="comparison"></param>
        public void StableSort(Comparison<T> comparison)
        {
            if (span.Length < 2)
            {
                return;
            }

            const int insertionSortThreshold = 16;

            if (span.Length <= insertionSortThreshold)
            {
                InsertionSort(span, comparison);
                return;
            }

            var mid = span.Length >> 1;
            var left = span[..mid];
            var right = span[mid..];

            left.StableSort(comparison);
            right.StableSort(comparison);
            Merge(span, mid, comparison);

            return;

            static void InsertionSort(in Span<T> span, Comparison<T> comparison)
            {
                for (var i = 1; i < span.Length; i++)
                {
                    var value = span[i];
                    var j = i - 1;

                    while (j >= 0 && comparison(span[j], value) > 0)
                    {
                        span[j + 1] = span[j];
                        j--;
                    }

                    span[j + 1] = value;
                }
            }

            static void Merge(in Span<T> span, int mid, Comparison<T> comparison)
            {
                if (mid <= 0 || mid >= span.Length)
                {
                    return;
                }

                if (comparison(span[mid - 1], span[mid]) <= 0)
                {
                    return;
                }

                MergeRange(span, 0, mid, span.Length, comparison);
                return;

                static void MergeRange(in Span<T> span, int start, int mid, int end, Comparison<T> comparison)
                {
                    while (true)
                    {
                        if (start >= mid || mid >= end)
                        {
                            return;
                        }

                        if (end - start == 2)
                        {
                            if (comparison(span[mid], span[start]) < 0)
                            {
                                (span[start], span[mid]) = (span[mid], span[start]);
                            }

                            return;
                        }

                        var leftLen = mid - start;
                        var rightLen = end - mid;

                        if (leftLen > rightLen)
                        {
                            var firstCut = start + (leftLen >> 1);
                            var secondCut = LowerBound(span, mid, end, span[firstCut], comparison);
                            var newMid = firstCut + (secondCut - mid);

                            Rotate(span, firstCut, mid, secondCut);
                            MergeRange(span, start, firstCut, newMid, comparison);
                            start = newMid;
                            mid = secondCut;
                        }
                        else
                        {
                            var secondCut = mid + (rightLen >> 1);
                            var firstCut = UpperBound(span, start, mid, span[secondCut], comparison);
                            var newMid = firstCut + (secondCut - mid);

                            Rotate(span, firstCut, mid, secondCut);
                            MergeRange(span, start, firstCut, newMid, comparison);
                            start = newMid;
                            mid = secondCut;
                        }

                        continue;


                        static int LowerBound(in Span<T> span, int start, int end, in T value, Comparison<T> comparison)
                        {
                            while (start < end)
                            {
                                var mid = start + ((end - start) >> 1);
                                if (comparison(span[mid], value) < 0)
                                {
                                    start = mid + 1;
                                }
                                else
                                {
                                    end = mid;
                                }
                            }

                            return start;
                        }

                        static int UpperBound(in Span<T> span, int start, int end, in T value, Comparison<T> comparison)
                        {
                            while (start < end)
                            {
                                var mid = start + ((end - start) >> 1);
                                if (comparison(span[mid], value) <= 0)
                                {
                                    start = mid + 1;
                                }
                                else
                                {
                                    end = mid;
                                }
                            }

                            return start;
                        }


                        static void Rotate(in Span<T> span, int first, int middle, int last)
                        {
                            Reverse(span, first, middle);
                            Reverse(span, middle, last);
                            Reverse(span, first, last);

                            return;

                            static void Reverse(in Span<T> span, int start, int end)
                            {
                                for (int i = start, j = end - 1; i < j; i++, j--)
                                {
                                    (span[i], span[j]) = (span[j], span[i]);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Sorts the given spans of keys and values by comparing the keys. It is expected
        /// that keys[1] is directly associated with values[1], etc - representing pairs of keys and values.
        /// Uses merge sort.
        /// </summary>
        public unsafe void StableSortWith<TValue>(in NativeMemory<TValue>.UnsafeView values, Comparison<T> comparison)
            where TValue : struct
        {
            if (span.Length != values.Length)
            {
                throw new ArgumentException("Keys and values must have the same length.");
            }

            if (span.Length < 2)
            {
                return;
            }

            const int insertionSortThreshold = 16;
            if (span.Length <= insertionSortThreshold)
            {
                InsertionSort(span, values, comparison);
                return;
            }

            var mid = span.Length >> 1;
            var leftKeys = span[..mid];
            var rightKeys = span[mid..];
            var leftValues = new NativeMemory<TValue>.UnsafeView(values.Ptr, 0, mid);
            var rightValues = new NativeMemory<TValue>.UnsafeView(values.Ptr, mid, values.Length - mid);

            leftKeys.StableSortWith(leftValues, comparison);
            rightKeys.StableSortWith(rightValues, comparison);
            Merge(span, values, mid, comparison);
            return;

            static void InsertionSort(in Span<T> keys, in NativeMemory<TValue>.UnsafeView valueView,
                Comparison<T> comparison)
            {
                var values = valueView.Ptr;
                for (var i = 1; i < keys.Length; i++)
                {
                    var key = keys[i];
                    var value = values[i];
                    var j = i - 1;

                    while (j >= 0 && comparison(keys[j], key) > 0)
                    {
                        keys[j + 1] = keys[j];
                        values[j + 1] = values[j];
                        j--;
                    }

                    keys[j + 1] = key;
                    values[j + 1] = value;
                }
            }

            static void Merge(in Span<T> keys, in NativeMemory<TValue>.UnsafeView values, int mid, Comparison<T> comparison)
            {
                if (mid <= 0 || mid >= keys.Length)
                {
                    return;
                }

                if (comparison(keys[mid - 1], keys[mid]) <= 0)
                {
                    return;
                }

                MergeRange(keys, values, 0, mid, keys.Length, comparison);
                return;

                static void MergeRange(in Span<T> keys, in NativeMemory<TValue>.UnsafeView values,
                    int start, int mid, int end,
                    Comparison<T> comparison)
                {
                    while (true)
                    {
                        if (start >= mid || mid >= end)
                        {
                            return;
                        }

                        if (end - start == 2)
                        {
                            ref var midKey = ref keys[mid];
                            ref var startKey = ref keys[start];
                            if (comparison(midKey, startKey) < 0)
                            {
                                Swap(keys, mid, start);
                                Swap(values, mid, start);
                            }

                            return;
                        }

                        var leftLen = mid - start;
                        var rightLen = end - mid;

                        if (leftLen > rightLen)
                        {
                            var firstCut = start + (leftLen >> 1);
                            var secondCut = LowerBound(keys, mid, end, keys[firstCut], comparison);
                            var newMid = firstCut + (secondCut - mid);

                            Rotate(keys, values, firstCut, mid, secondCut);
                            MergeRange(keys, values, start, firstCut, newMid, comparison);
                            start = newMid;
                            mid = secondCut;
                        }
                        else
                        {
                            var secondCut = mid + (rightLen >> 1);
                            var firstCut = UpperBound(keys, start, mid, keys[secondCut], comparison);
                            var newMid = firstCut + (secondCut - mid);

                            Rotate(keys, values, firstCut, mid, secondCut);
                            MergeRange(keys, values, start, firstCut, newMid, comparison);
                            start = newMid;
                            mid = secondCut;
                        }

                        continue;

                        static int LowerBound(in Span<T> keys, int start, int end, in T value, Comparison<T> comparison)
                        {
                            while (start < end)
                            {
                                var mid = start + ((end - start) >> 1);
                                if (comparison(keys[mid], value) < 0)
                                {
                                    start = mid + 1;
                                }
                                else
                                {
                                    end = mid;
                                }
                            }

                            return start;
                        }

                        static int UpperBound(in Span<T> keys, int start, int end, in T value, Comparison<T> comparison)
                        {
                            while (start < end)
                            {
                                var mid = start + ((end - start) >> 1);
                                if (comparison(keys[mid], value) <= 0)
                                {
                                    start = mid + 1;
                                }
                                else
                                {
                                    end = mid;
                                }
                            }

                            return start;
                        }

                        static void Rotate(in Span<T> keys, in NativeMemory<TValue>.UnsafeView values,
                            int first, int middle, int last)
                        {
                            Reverse(keys, values, first, middle);
                            Reverse(keys, values, middle, last);
                            Reverse(keys, values, first, last);

                            return;

                            static void Reverse(in Span<T> keys, in NativeMemory<TValue>.UnsafeView values,
                                int start, int end)
                            {
                                for (int i = start, j = end - 1; i < j; i++, j--)
                                {
                                    Swap(keys, i, j);
                                    Swap(values, i, j);
                                }
                            }
                        }
                    }
                }
            }

        }
    }

    private static void Swap<T>(in NativeMemory<T>.UnsafeView values, int i, int j) where T : struct
    {
        ref var key1 = ref values[i];
        ref var key2 = ref values[j];
        var tempKey = key1;
        key1 = key2;
        key2 = tempKey;
    }

    private static void Swap<T>(in Span<T> keys, int i, int j)
    {
        ref var key1 = ref keys[i];
        ref var key2 = ref keys[j];
        var tempKey = key1;
        key1 = key2;
        key2 = tempKey;
    }
}
