// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;

namespace Silk.NET.Input;

// ReSharper disable StaticMemberInGenericType
// ^ that's the point
/// <summary>
/// A helper class for quickly converting enum values into indexes, particularly
/// when there is a possibility of unknown/unnamed enum values. See <see cref="JoystickButton"/> for an example
/// of an appropriate implementation along with <see cref="ButtonReadOnlyList{JoystickButton}"/>
/// </summary>
/// <typeparam name="T"></typeparam>
internal static class EnumInfo<T> where T : unmanaged, Enum
{
    /// <summary>
    /// All enum values sorted in increasing order (unstable sort)
    /// </summary>
    public static IReadOnlyList<T> AllValuesOrdered => _allValuesOrdered;

    /// <summary>
    /// All enum values with distinct numerical values sorted in increasing order.
    /// In the case of multiple enum entries with the same numerical value, this makes no guarantees about
    /// which version ends up here.
    /// </summary>
    public static readonly IReadOnlyList<T> UniqueValues;

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

    private static readonly T[] _allValuesOrdered;
    private static readonly Dictionary<T, int> _numericallyDistinctIndices;
    private static readonly ulong[] _allEnumValuesRaw;
    private static readonly bool _unnamedAreIndexable;

    static unsafe EnumInfo()
    {
        var customAttributeDatas = typeof(T).CustomAttributes;
        var hasFlagsAttribute = false;
        foreach (var attr in customAttributeDatas)
        {
            if (attr.AttributeType == typeof(FlagsAttribute))
            {
                hasFlagsAttribute = true;
            }

            if (attr.AttributeType == typeof(OrderedIndexUsageAttribute))
            {
                _unnamedAreIndexable = true;
            }
        }

        if (hasFlagsAttribute)
        {
            throw new InvalidOperationException("Enums with the FlagsAttribute cannot be used with EnumInfo");
        }

        var underlyingType = UnderlyingType;
        T[] vals;
        T[] all;
        if (underlyingType == typeof(int))
        {
            all = OrderedValues<int>(false);
            vals = OrderedValues<int>(true);
            _allEnumValuesRaw = vals.Select(x => (ulong)*(uint*)&x).ToArray();
        }
        else if (underlyingType == typeof(uint))
        {
            all = OrderedValues<uint>(false);
            vals = OrderedValues<uint>(true);
            _allEnumValuesRaw = vals.Select(x => (ulong)*(uint*)&x).ToArray();
        }
        else if (underlyingType == typeof(byte))
        {
            all = OrderedValues<byte>(false);
            vals = OrderedValues<byte>(true);
            _allEnumValuesRaw = vals.Select(x => (ulong)*(byte*)&x).ToArray();
        }
        else if (underlyingType == typeof(sbyte))
        {
            all = OrderedValues<sbyte>(false);
            vals = OrderedValues<sbyte>(true);
            _allEnumValuesRaw = vals.Select(x => (ulong)*(byte*)&x).ToArray();
        }
        else if (underlyingType == typeof(short))
        {
            all = OrderedValues<short>(false);
            vals = OrderedValues<short>(true);
            _allEnumValuesRaw = vals.Select(x => (ulong)*(ushort*)&x).ToArray();
        }
        else if (underlyingType == typeof(ushort))
        {
            all = OrderedValues<ushort>(false);
            vals = OrderedValues<ushort>(true);
            _allEnumValuesRaw = vals.Select(x => (ulong)*(ushort*)&x).ToArray();
        }
        else if (underlyingType == typeof(long))
        {
            all = OrderedValues<long>(false);
            vals = OrderedValues<long>(true);
            _allEnumValuesRaw = vals.Select(x => *(ulong*)&x).ToArray();
        }
        else if (underlyingType == typeof(ulong))
        {
            all = OrderedValues<ulong>(false);
            vals = OrderedValues<ulong>(true);
            _allEnumValuesRaw = vals.Select(x => *(ulong*)&x).ToArray();
        }
        else
        {
            throw new InvalidOperationException("Enum provided uses an unknown numeric base??");
        }

        var dict = new Dictionary<T, int>(vals.Length);
        for (var index = 0; index < vals.Length; index++)
        {
            var enumVal = vals[index];

            // get attribute and check for ignore

            dict.Add(enumVal, index);
        }

        _allValuesOrdered = all;
        UniqueValues = vals;
        _numericallyDistinctIndices = dict;
        MinValue = AllValuesOrdered[0];
        MaxValue = AllValuesOrdered[^1];
    }

#pragma warning disable ST0006 ST0007 ST0008 ST0009
    /// <summary>
    /// Gets the ordered index of the unnamed enum value provided. This index is calculated by:
    /// (the number of named members in this enum type) + (the raw value of the number if unnamed)
    ///
    /// Negative values or values that are above the lowest enum value will return -1, as they cannot be used for indexing
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int ValueIndexOf(T value)
    {
        // happy path - it's a named value we've already computed
        if (_numericallyDistinctIndices.TryGetValue(value, out var index))
        {
            return index;
        }

        // unhappy path - it's an unnamed value we haven't computed yet
        if (!_unnamedAreIndexable)
        {
            // unnamed indexing is disabled
            return -1;
        }

        var rawValue = value.Convert<T, int>();

        // todo - don't rely on joystickButton's unknown - find the MinValue
        if (rawValue <= 0 || rawValue >= _allEnumValuesRaw[0].Convert<ulong, int>())
        {
            return -1;
        }

        return _allValuesOrdered.Length + rawValue;
    }


    private static T[] OrderedValues<TNumber>(bool byNumericValue)
        where TNumber : unmanaged, IComparable<TNumber>
    {
        // numerically distinct numbers
        var allValues = Enum.GetValues<T>().Where(x => !IsIgnored(x)).ToArray();

        if (byNumericValue)
        {
            allValues = allValues.DistinctBy(UnsafeNumericValueExtensions.Convert<T, TNumber>).ToArray();
        }

        // sort by increasing order
        allValues.AsSpan().StableSort((a, b) => {
            var aNumber = a.Convert<T, TNumber>();
            var bNumber = b.Convert<T, TNumber>();
            return aNumber.CompareTo(bNumber);
        });

        return allValues;
    }

#pragma warning restore ST0006 ST0007 ST0008 ST0009

    private static bool IsIgnored(T value)
    {
        var attr = value.GetType().GetField(value.ToString())?.GetCustomAttribute<OrderedIndexIgnoreAttribute>();
        return attr is not null;
    }

    public static unsafe bool HasValue(int value) => _allEnumValuesRaw.Contains(*(uint*)&value);

    public static unsafe T ValueOfIndex(int index)
    {
        var value = _allEnumValuesRaw[index];
        return *(T*)&value;
    }
}
