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
    public static IReadOnlyList<T> All => _all;

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

    private static readonly T[] _all;
    private static readonly string[] _names;
    private static readonly Dictionary<T, int> _numericallyDistinctValues;
    private static readonly ulong[] _allEnumValuesRaw;
    private static bool _unnamedAreIndexable;

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


        var names = new string[all.Length];
        for (var index = 0; index < all.Length; index++)
        {
            names[index] = all[index].ToString(); // todo: readable name attributes?
        }

        var dict = new Dictionary<T, int>(vals.Length);
        for (var i = 0; i < vals.Length; i++)
        {
            var enumVal = vals[i];
            dict.Add(enumVal, i);
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
    private static int NameIndexOf(T value) => Array.IndexOf(_all, value);

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
    /// <returns>The index of the sorted enum numerical value, or -1 if not a named enum member.</returns>
    /// <exception cref="InvalidOperationException"></exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ValueIndexOf(T value) => !_unnamedAreIndexable
        ? ValueOf<T, int>(value)
        : _numericallyDistinctValues.GetValueOrDefault(value, -1);

    /// <summary>
    /// Gets the ordered index of the unnamed enum value provided. This index is calculated by:
    /// (the number of named members in this enum type) + (the raw value of the number if unnamed)
    ///
    /// Negative values or values that are above the lowest enum value will return -1, as they cannot be used for indexing
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int ValueIndexOfUnnamed(T value)
    {
        if (!_unnamedAreIndexable)
        {
            return ValueOf<T, int>(value);
        }

        if(_numericallyDistinctValues.TryGetValue(value, out var index))
        {
            return index;
        }

        var rawValue = ValueOf<T, int>(value);

        // todo - don't rely on joystickButton's unknown - find the MinValue
        if (rawValue <= 0 || rawValue >= ValueOf<ulong, int>(_allEnumValuesRaw[0]))
        {
            return -1;
        }

        return  _all.Length + rawValue;
    }

    /// <summary>
    /// Returns the numerical value of the enum value provided in a type-safe way
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <typeparam name="TNumber"></typeparam>
    /// <returns></returns>
    private static unsafe TNumber ValueOf<TValue, TNumber>(TValue value) where TNumber : unmanaged where TValue : unmanaged
    {
        if (sizeof(T) == sizeof(TNumber))
        {
            return Unsafe.Read<TNumber>(&value);
        }

        var minSize = Math.Min(sizeof(TNumber), sizeof(T));

        var originalValuePtr = (byte*)&value;

        var valuePtr = &originalValuePtr[Math.Abs(minSize - sizeof(T))]; // does this assume little-endianness?
        var numberPtr = stackalloc byte[sizeof(TNumber)];

        // ensure block is initialized (as it isnt guaranteed?) so any missing bytes of the output will stay 0
        // if type TNumber is a larger size than type T
        Unsafe.InitBlock(numberPtr, 0, (uint)sizeof(TNumber));

        var copyToPtr = &numberPtr[Math.Abs(minSize - sizeof(TNumber))];
        Buffer.MemoryCopy(valuePtr, copyToPtr, sizeof(TNumber), minSize);
        return *(TNumber*)numberPtr;
    }

    private static T[] OrderedValues<TNumber>(bool byNumericValue)
        where TNumber : unmanaged, IComparable<TNumber>
    {
        // numerically distinct numbers
        var allValues = Enum.GetValues<T>();

        if (byNumericValue)
        {
            allValues = allValues.DistinctBy(ValueOf<T, TNumber>).ToArray();
        }

        // sort by increasing order
        Array.Sort(allValues, (a, b) => {
            var aNumber = ValueOf<T, TNumber>(a);
            var bNumber = ValueOf<T, TNumber>(b);
            return aNumber.CompareTo(bNumber);
        });

        return allValues;
    }

    public static unsafe bool HasValue(int value) => _allEnumValuesRaw.Contains(*(uint*)&value);
}

[AttributeUsage(AttributeTargets.Enum)]
internal class OrderedIndexUsageAttribute : Attribute;
