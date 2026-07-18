// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System.Runtime.CompilerServices;

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
    public static readonly IReadOnlyList<T> UniqueNamedValues;

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
    private static readonly ulong[] _allEnumValuesDistinctRaw;
    private static readonly bool _unnamedAreIndexable;
#pragma warning disable CS0414 // Field is assigned but its value is never used
    // QUESTION - do we want this information? can this speed up or improve conversion methods?
    private static readonly bool _isSignedBackingType;
#pragma warning restore CS0414 // Field is assigned but its value is never used

    private const int _maxCapacity = 256;

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
        var all = Enum.GetValues<T>().Where(x => !IsIgnored(x)).ToArray();
        var numericallyDistinct = all.DistinctBy(UnsafeNumericValueExtensions.ConvertBitwiseUnsafe<T, ulong>).ToArray();
        if (underlyingType == typeof(int))
        {
            SortValues<int>(numericallyDistinct);
            _allEnumValuesDistinctRaw = numericallyDistinct.Select(x => (ulong)*(uint*)&x).ToArray();
            SortValues<int>(all);
            _isSignedBackingType = true;
        }
        else if (underlyingType == typeof(uint))
        {
            SortValues<uint>(numericallyDistinct);
            _allEnumValuesDistinctRaw = numericallyDistinct.Select(x => (ulong)*(uint*)&x).ToArray();
            SortValues<uint>(all);
        }
        else if (underlyingType == typeof(sbyte))
        {
            SortValues<sbyte>(numericallyDistinct);
            _allEnumValuesDistinctRaw = numericallyDistinct.Select(x => (ulong)*(byte*)&x).ToArray();
            SortValues<sbyte>(all);
            _isSignedBackingType = true;
        }
        else if (underlyingType == typeof(byte))
        {
            SortValues<byte>(numericallyDistinct);
            _allEnumValuesDistinctRaw = numericallyDistinct.Select(x => (ulong)*(byte*)&x).ToArray();
            SortValues<byte>(all);
        }
        else if (underlyingType == typeof(short))
        {
            SortValues<short>(numericallyDistinct);
            _allEnumValuesDistinctRaw = numericallyDistinct.Select(x => (ulong)*(ushort*)&x).ToArray();
            SortValues<short>(all);
            _isSignedBackingType = true;
        }
        else if (underlyingType == typeof(ushort))
        {
            SortValues<ushort>(numericallyDistinct);
            _allEnumValuesDistinctRaw = numericallyDistinct.Select(x => (ulong)*(ushort*)&x).ToArray();
            SortValues<ushort>(all);
        }
        else if (underlyingType == typeof(long))
        {
            SortValues<long>(numericallyDistinct);
            _allEnumValuesDistinctRaw = numericallyDistinct.Select(x => *(ulong*)&x).ToArray();
            SortValues<long>(all);
            _isSignedBackingType = true;
        }
        else if (underlyingType == typeof(ulong))
        {
            SortValues<ulong>(numericallyDistinct);
            _allEnumValuesDistinctRaw = numericallyDistinct.Select(x => *(ulong*)&x).ToArray();
            SortValues<ulong>(all);
        }
        else
        {
            throw new InvalidOperationException("Enum provided uses an unknown numeric base??");
        }

        var dict = new Dictionary<T, int>(numericallyDistinct.Length);
        for (var index = 0; index < numericallyDistinct.Length; index++)
        {
            var enumVal = numericallyDistinct[index];

            // get attribute and check for ignore

            dict.Add(enumVal, index);
        }

        _allValuesOrdered = all;
        UniqueNamedValues = numericallyDistinct;
        _numericallyDistinctIndices = dict;
        MinValue = AllValuesOrdered[0];
        MaxValue = AllValuesOrdered[^1];

        return;

        static bool IsIgnored(T value)
        {
            var field = value.GetType().GetField(value.ToString());
            return field is not null &&
                   System.Reflection.CustomAttributeExtensions.GetCustomAttribute<OrderedIndexIgnoreAttribute>(field) is not
                       null;
        }

        // sort by increasing order
        static void SortValues<TNumber>(T[] allValues) where TNumber : unmanaged, IComparable<TNumber> =>
            allValues.StableSort((a, b) => {
                var aNumber = a.ConvertBitwiseUnsafe<T, TNumber>();
                var bNumber = b.ConvertBitwiseUnsafe<T, TNumber>();
                return aNumber.CompareTo(bNumber);
            });
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

        var rawValue = value.ConvertBitwiseUnsafe<T, int>();

        var minKnownVal = _allEnumValuesDistinctRaw[0].ConvertBitwiseUnsafe<ulong, int>();
        if (rawValue < 0 || rawValue >= minKnownVal)
        {
            return -1;
        }

        var idx = _allValuesOrdered.Length + rawValue;
        if (_numericallyDistinctIndices.Count < _maxCapacity)
        {
#if DEBUG
            System.Diagnostics.Debug.Assert(_numericallyDistinctIndices.TryAdd(value, idx));
#else
            _ = _numericallyDistinctIndices.TryAdd(value, idx);
#endif
        }

        return idx;
    }


#pragma warning restore ST0006 ST0007 ST0008 ST0009

    public static unsafe T ValueOfIndex(int index)
    {
        var value = _allEnumValuesDistinctRaw[index];
        return *(T*)&value;
    }

    public static bool HasValue(int button)
    {
        var asUint = Unsafe.As<int, uint>(ref button);
        return _allEnumValuesDistinctRaw.Contains(asUint);
    }
}
