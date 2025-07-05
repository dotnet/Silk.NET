// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace Silk.NET.Input;

// ReSharper disable StaticMemberInGenericType
// ^ that's the point
/// <summary>
/// A helper class for quickly converting enum values into indexes
/// </summary>
/// <typeparam name="T"></typeparam>
internal static class EnumInfo<T> where T : unmanaged, Enum
{
    public static IReadOnlyList<T> Values => _values;
    public static int NameCount => _values.Length;
    public static int ValueCount => _numericallyDistinctValues.Count;

    public static readonly T MaxValue;
    public static readonly T MinValue;

    private static readonly T[] _values;
    private static readonly Dictionary<T, int> _numericallyDistinctValues;

    public static readonly Type UnderlyingType = typeof(T).GetEnumUnderlyingType();

    static EnumInfo()
    {
        if (typeof(T).CustomAttributes.Any(x => x.AttributeType == typeof(FlagsAttribute)))
        {
            throw new InvalidOperationException("Flags enums are not supported.");
        }

        var underlyingType = UnderlyingType;
        T[] vals;
        if (underlyingType == typeof(int))
        {
            _values = OrderedValues<int>(false);
            vals = OrderedValues<uint>(true);
        }
        else if (underlyingType == typeof(uint))
        {
            _values = OrderedValues<uint>(false);
            vals = OrderedValues<uint>(true);
        }
        else if (underlyingType == typeof(byte))
        {
            _values = OrderedValues<byte>(false);
            vals = OrderedValues<byte>(true);
        }
        else if (underlyingType == typeof(sbyte))
        {
            _values = OrderedValues<sbyte>(false);
            vals = OrderedValues<sbyte>(true);
        }
        else if (underlyingType == typeof(short))
        {
            _values = OrderedValues<short>(false);
            vals = OrderedValues<short>(true);
        }
        else if (underlyingType == typeof(ushort))
        {
            _values = OrderedValues<ushort>(false);
            vals = OrderedValues<ushort>(true);
        }
        else if (underlyingType == typeof(long))
        {
            _values = OrderedValues<long>(false);
            vals = OrderedValues<long>(true);
        }
        else if (underlyingType == typeof(ulong))
        {
            _values = OrderedValues<ulong>(false);
            vals = OrderedValues<ulong>(true);
        }
        else
        {
            throw new InvalidOperationException("Enum provided uses an unknown numeric base??");
        }

        var dict = new Dictionary<T, int>(vals.Length);
        for (int i = 0; i < vals.Length; i++)
        {
            dict.Add(vals[i], i);
        }

        _numericallyDistinctValues = dict;
        MinValue = Values[0];
        MaxValue = Values[^1];
    }

    /// <summary>
    /// Get the ordered index of the value provided.
    /// Values with the same numerical value will *not* return the same index, and are not guaranteed to be
    /// stably sorted across application runs.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>The index of the sorted enum value</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int NameIndexOf(T value) => Array.IndexOf(_values, value);

    /// <summary>
    /// Get the ordered index of the value provided.
    /// Values with the same numerical value will return the same index
    /// </summary>
    /// <param name="value"></param>
    /// <returns>The index of the sorted enum numerical value</returns>
    /// <exception cref="InvalidOperationException"></exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ValueIndexOf(T value) => _numericallyDistinctValues[value];

    private static unsafe T[] OrderedValues<TNumber>(bool byNumericValue)
        where TNumber : unmanaged, IComparable<TNumber>
    {
        // numerically distinct numbers
        var allValues = Enum.GetValues<T>();

        if (byNumericValue)
        {
            allValues = allValues.DistinctBy(x => *(TNumber*)&x).ToArray();
        }

        // sort by increasing order
        Array.Sort(allValues, (a, b) => {
            var aNumber = *(TNumber*)&a;
            var bNumber = *(TNumber*)&b;
            return aNumber.CompareTo(bNumber);
        });

        return allValues;
    }
}
