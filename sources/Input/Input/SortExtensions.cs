// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// ReSharper disable SwapViaDeconstruction
namespace Silk.NET.Input;

internal static class SortExtensions
{
    extension<T>(Span<T> span) where T : struct
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
                InsertionSort(in span, comparison);
                return;
            }

            var mid = span.Length >> 1;
            var left = span[..mid];
            var right = span[mid..];

            left.StableSort(comparison);
            right.StableSort(comparison);
            Merge(in span, mid, comparison);

            return;

            static void InsertionSort(ref readonly Span<T> span, Comparison<T> comparison)
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

            static void Merge(ref readonly Span<T> span, int mid, Comparison<T> comparison)
            {
                if (mid <= 0 || mid >= span.Length)
                {
                    return;
                }

                if (comparison(span[mid - 1], span[mid]) <= 0)
                {
                    return;
                }

                MergeRange(in span, 0, mid, span.Length, comparison);
                return;

                static void MergeRange(ref readonly Span<T> span, int start, int mid, int end, Comparison<T> comparison)
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

                            Rotate(in span, firstCut, mid, secondCut);
                            MergeRange(in span, start, firstCut, newMid, comparison);
                            start = newMid;
                            mid = secondCut;
                        }
                        else
                        {
                            var secondCut = mid + (rightLen >> 1);
                            var firstCut = UpperBound(span, start, mid, span[secondCut], comparison);
                            var newMid = firstCut + (secondCut - mid);

                            Rotate(in span, firstCut, mid, secondCut);
                            MergeRange(in span, start, firstCut, newMid, comparison);
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


                        static void Rotate(ref readonly Span<T> span, int first, int middle, int last)
                        {
                            Reverse(in span, first, middle);
                            Reverse(in span, middle, last);
                            Reverse(in span, first, last);

                            return;

                            static void Reverse(ref readonly Span<T> span, int start, int end)
                            {
                                for (int i = start, j = end - 1; i < j; i++, j--)
                                {
                                    Swap(in span, i, j);
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    private static void Swap<T>(ref readonly Span<T> values, int i, int j)
    {
        ref var key1 = ref values[i];
        ref var key2 = ref values[j];
        var tempKey = key1;
        key1 = key2;
        key2 = tempKey;
    }
}
