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
    public static int ValueCount => _numericallyDistinctValues.Length;

    public static readonly T MaxValue;
    public static readonly T MinValue;

    private static readonly T[] _values;
    private static readonly T[] _numericallyDistinctValues;

    private static readonly int _elementSize = Unsafe.SizeOf<T>();

    public static readonly Type UnderlyingType = typeof(T).GetEnumUnderlyingType();

    static EnumInfo()
    {
        if (typeof(T).CustomAttributes.Any(x => x.AttributeType == typeof(FlagsAttribute)))
        {
            throw new InvalidOperationException("Flags enums are not supported.");
        }
#if DEBUG
        if (_elementSize != 1 || _elementSize != 2 || _elementSize != 4 || _elementSize != 8)
        {
            throw new Exception("Enum provided uses an unknown numeric base??");
        }
#endif
        var underlyingType = UnderlyingType;
        if (underlyingType == typeof(int))
        {
            _values = OrderedValues<int>(false);
            _numericallyDistinctValues = OrderedValues<int>(true);
        }
        else if (underlyingType == typeof(uint))
        {
            _values = OrderedValues<uint>(false);
            _numericallyDistinctValues = OrderedValues<uint>(true);
        }
        else if (underlyingType == typeof(byte))
        {
            _values = OrderedValues<byte>(false);
            _numericallyDistinctValues = OrderedValues<byte>(true);
        }
        else if (underlyingType == typeof(sbyte))
        {
            _values = OrderedValues<sbyte>(false);
            _numericallyDistinctValues = OrderedValues<sbyte>(true);
        }
        else if (underlyingType == typeof(short))
        {
            _values = OrderedValues<short>(false);
            _numericallyDistinctValues = OrderedValues<short>(true);
        }
        else if (underlyingType == typeof(ushort))
        {
            _values = OrderedValues<ushort>(false);
            _numericallyDistinctValues = OrderedValues<ushort>(true);
        }
        else if (underlyingType == typeof(long))
        {
            _values = OrderedValues<long>(false);
            _numericallyDistinctValues = OrderedValues<long>(true);
        }
        else if (underlyingType == typeof(ulong))
        {
            _values = OrderedValues<ulong>(false);
            _numericallyDistinctValues = OrderedValues<ulong>(true);
        }
        else
        {
            throw new InvalidOperationException("Enum provided uses an unknown numeric base??");
        }

        MinValue = Values[0];
        MaxValue = Values[^1];
    }

    /// <summary>
    /// Get the ordered index of the value provided.
    /// Values with the same numerical value will *not* return the same index, and are not guaranteed to be
    /// stably sorted across application runs.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int NameIndexOf(T value) => Array.IndexOf(_values, value);

    /// <summary>
    /// Get the ordered index of the value provided.
    /// Values with the same numerical value will return the same index
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static unsafe int ValueIndexOf(T value)
    {
        switch (_elementSize)
        {
            case 1:
            {
                var values = Unsafe.As<byte[]>(_numericallyDistinctValues);
                return Array.IndexOf(values, *(byte*)&value);
            }
            case 2:
            {
                var values = Unsafe.As<ushort[]>(_numericallyDistinctValues);
                return Array.IndexOf(values, *(ushort*)&value);
            }
            case 4:
            {
                var values = Unsafe.As<uint[]>(_numericallyDistinctValues);
                return Array.IndexOf(values, *(uint*)&value);
            }
            case 8:
            {
                var values = Unsafe.As<ulong[]>(_numericallyDistinctValues);
                return Array.IndexOf(values, *(ulong*)&value);
            }
            default:
                throw new InvalidOperationException("Enum provided uses an unknown numeric base??");
        }
    }

    private static unsafe T[] OrderedValues<TNumber>(bool byNumericValue)
        where TNumber : unmanaged, IComparable<TNumber>
    {
        // numerically distinct numbers
        var allValues = Enum.GetValues<T>();

        if (byNumericValue)
        {
            allValues = allValues.DistinctBy(x => *(TNumber*)&x).ToArray();
        }

        // sort with a lambda expression
        Array.Sort(allValues, (a, b) => {
            var aNumber = *(TNumber*)&a;
            var bNumber = *(TNumber*)&b;
            return aNumber.CompareTo(bNumber);
        });

        return allValues;
    }
}
