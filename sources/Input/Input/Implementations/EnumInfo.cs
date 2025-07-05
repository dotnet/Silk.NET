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
    /// <summary>
    /// All enum values sorted in increasing order (unstable sort)
    /// </summary>
    public static IReadOnlyList<T> All => _all;

    /// <summary>
    /// All enum values with distinct numerical values sorted in increasing order.
    /// In the case of multiple enum entries with the same numerical value, this makes no guarantees about
    /// which version ends up here.
    /// </summary>
    public static IReadOnlyList<T> UniqueValues;


    /// <summary>
    /// The value with the highest numerical value
    /// </summary>
    public static readonly T MaxValue;

    /// <summary>
    /// The value with the lowest numerical value
    /// </summary>
    public static readonly T MinValue;

    /// <summary>
    /// The numerical type of the enum
    /// </summary>
    public static readonly Type UnderlyingType = typeof(T).GetEnumUnderlyingType();

    private static readonly T[] _all;
    private static readonly string[] _names;
    private static readonly Dictionary<T, int> _numericallyDistinctValues;


    static EnumInfo()
    {
        if (typeof(T).CustomAttributes.Any(x => x.AttributeType == typeof(FlagsAttribute)))
        {
            throw new InvalidOperationException("Flags enums are not supported.");
        }

        var underlyingType = UnderlyingType;
        T[] vals;
        T[] all;
        if (underlyingType == typeof(int))
        {
            all = OrderedValues<int>(false);
            vals = OrderedValues<int>(true);
        }
        else if (underlyingType == typeof(uint))
        {
            all = OrderedValues<uint>(false);
            vals = OrderedValues<uint>(true);
        }
        else if (underlyingType == typeof(byte))
        {
            all = OrderedValues<byte>(false);
            vals = OrderedValues<byte>(true);
        }
        else if (underlyingType == typeof(sbyte))
        {
            all = OrderedValues<sbyte>(false);
            vals = OrderedValues<sbyte>(true);
        }
        else if (underlyingType == typeof(short))
        {
            all = OrderedValues<short>(false);
            vals = OrderedValues<short>(true);
        }
        else if (underlyingType == typeof(ushort))
        {
            all = OrderedValues<ushort>(false);
            vals = OrderedValues<ushort>(true);
        }
        else if (underlyingType == typeof(long))
        {
            all = OrderedValues<long>(false);
            vals = OrderedValues<long>(true);
        }
        else if (underlyingType == typeof(ulong))
        {
            all = OrderedValues<ulong>(false);
            vals = OrderedValues<ulong>(true);
        }
        else
        {
            throw new InvalidOperationException("Enum provided uses an unknown numeric base??");
        }


        var names = new string[all.Length];
        for (var index = 0; index < all.Length; index++)
        {
            names[index] = all[index].ToString(); // todo: readable name attributes?
        }

        var dict = new Dictionary<T, int>(vals.Length);
        for (var i = 0; i < vals.Length; i++)
        {
            dict.Add(vals[i], i);
        }

        _names = names;
        _all = all;
        UniqueValues = vals;
        _numericallyDistinctValues = dict;
        MinValue = All[0];
        MaxValue = All[^1];
    }

    /// <summary>
    /// Get the ordered index of the value provided.
    /// Values with the same numerical value will *not* return the same index, and are not guaranteed to be
    /// stably sorted across application runs.
    /// The index provided
    /// </summary>
    /// <param name="value"></param>
    /// <returns>The index of the sorted enum value</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int NameIndexOf(T value) => Array.IndexOf(_all, value);

    /// <inheritdoc cref="_names"/>

    /// <summary>
    /// Returns the names of an enum value, pre-allocated
    /// </summary>
    public static string NameOf(T value) => _names[NameIndexOf(value)];

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
