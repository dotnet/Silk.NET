// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Input;

// ReSharper disable StaticMemberInGenericType
// ^ that's the point
internal static class EnumInfo<T> where T : unmanaged, Enum
{
    public static readonly T[] Values = Enum.GetValues<T>();
    public static readonly int Count = Values.Length;
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
            GetMinMaxValues<T, int>(out MinValue, out MaxValue);
        }
        else if (underlyingType == typeof(uint))
        {
            GetMinMaxValues<T, uint>(out MinValue, out MaxValue);
        }
        else if (underlyingType == typeof(byte))
        {
            GetMinMaxValues<T, byte>(out MinValue, out MaxValue);
        }
        else if (underlyingType == typeof(sbyte))
        {
            GetMinMaxValues<T, sbyte>(out MinValue, out MaxValue);
        }
        else if (underlyingType == typeof(short))
        {
            GetMinMaxValues<T, short>(out MinValue, out MaxValue);
        }
        else if (underlyingType == typeof(ushort))
        {
            GetMinMaxValues<T, ushort>(out MinValue, out MaxValue);
        }
        else if (underlyingType == typeof(long))
        {
            GetMinMaxValues<T, long>(out MinValue, out MaxValue);
        }
        else if (underlyingType == typeof(ulong))
        {
            GetMinMaxValues<T, ulong>(out MinValue, out MaxValue);
        }
        else
        {
            throw new InvalidOperationException("Enum provided uses an unknown numeric base??");
        }
    }

    private static unsafe void GetMinMaxValues<TEnum, TNumber>(out TEnum minT, out TEnum maxT)
        where TEnum : unmanaged, Enum
        where TNumber : unmanaged, IMinMaxValue<TNumber>, INumber<TNumber>
    {
#if DEBUG
        if (typeof(TEnum).GetEnumUnderlyingType() != typeof(TNumber))
        {
            throw new InvalidOperationException("Type mismatch");
        }
#endif

        var maxValue = TNumber.MinValue;
        var minValue = TNumber.MaxValue;
        for (int i = 0; i < Values.Length; i++)
        {
            var value = Values[i];
            var asNumber = *(TNumber*)&value;
            maxValue = asNumber > maxValue ? asNumber : maxValue;
            minValue = asNumber < minValue ? asNumber : minValue;
        }

        maxT = *(TEnum*)&maxValue;
        minT = *(TEnum*)&minValue;
    }
}
