// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Input;

// ReSharper disable StaticMemberInGenericType
// ^ that's the point
internal static class EnumInfo<T> where T : unmanaged, Enum
{
    public static readonly IReadOnlyList<T> Values;
    public static readonly int Count;
    public static readonly T MaxValue;
    public static readonly T MinValue;

    static EnumInfo()
    {
        if (typeof(T).CustomAttributes.Any(x => x.AttributeType == typeof(FlagsAttribute)))
        {
            throw new InvalidOperationException("Flags enums are not supported.");
        }

        var underlyingType = typeof(T).GetEnumUnderlyingType();
        if (underlyingType == typeof(int))
        {
            Values = OrderedValues<int>();
        }
        else if (underlyingType == typeof(uint))
        {
            Values = OrderedValues<uint>();
        }
        else if (underlyingType == typeof(byte))
        {
            Values = OrderedValues<byte>();
        }
        else if (underlyingType == typeof(sbyte))
        {
            Values = OrderedValues<sbyte>();
        }
        else if (underlyingType == typeof(short))
        {
            Values = OrderedValues<short>();
        }
        else if (underlyingType == typeof(ushort))
        {
            Values = OrderedValues<ushort>();
        }
        else if (underlyingType == typeof(long))
        {
            Values = OrderedValues<long>();
        }
        else if (underlyingType == typeof(ulong))
        {
            Values = OrderedValues<ulong>();
        }
        else
        {
            throw new InvalidOperationException("Enum provided uses an unknown numeric base??");
        }

        Count = Values.Count;
        MinValue = Values[0];
        MaxValue = Values[^1];
    }

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
