// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Input;

// ReSharper disable StaticMemberInGenericType
// ^ that's the point
internal static class EnumInfo<T> where T : unmanaged, Enum
{
    public static IReadOnlyList<T> Values => _values;
    public static readonly int Count;
    public static readonly T MaxValue;
    public static readonly T MinValue;
    private static readonly T[] _values;

    static EnumInfo()
    {
        if (typeof(T).CustomAttributes.Any(x => x.AttributeType == typeof(FlagsAttribute)))
        {
            throw new InvalidOperationException("Flags enums are not supported.");
        }

        var underlyingType = typeof(T).GetEnumUnderlyingType();
        if (underlyingType == typeof(int))
        {
            _values = OrderedValues<int>();
        }
        else if (underlyingType == typeof(uint))
        {
            _values = OrderedValues<uint>();
        }
        else if (underlyingType == typeof(byte))
        {
            _values = OrderedValues<byte>();
        }
        else if (underlyingType == typeof(sbyte))
        {
            _values = OrderedValues<sbyte>();
        }
        else if (underlyingType == typeof(short))
        {
            _values = OrderedValues<short>();
        }
        else if (underlyingType == typeof(ushort))
        {
            _values = OrderedValues<ushort>();
        }
        else if (underlyingType == typeof(long))
        {
            _values = OrderedValues<long>();
        }
        else if (underlyingType == typeof(ulong))
        {
            _values = OrderedValues<ulong>();
        }
        else
        {
            throw new InvalidOperationException("Enum provided uses an unknown numeric base??");
        }

        Count = Values.Count;
        MinValue = Values[0];
        MaxValue = Values[^1];
    }

    public static int IndexOf(T value) => Array.IndexOf(_values, value);

    private static unsafe T[] OrderedValues<TNumber>() where TNumber : unmanaged, IComparable<TNumber>
    {
        var allValues = Enum.GetValues<T>();
        // sort with a lambda expression
        Array.Sort(allValues, (a, b) => {
            var aNumber = *(TNumber*)&a;
            var bNumber = *(TNumber*)&b;
            return aNumber.CompareTo(bNumber);
        });
        return allValues;
    }
}
