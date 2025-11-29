// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct ROParamIIDHandle
    : IComparable,
        IComparable<ROParamIIDHandle>,
        IEquatable<ROParamIIDHandle>,
        IFormattable
{
    public readonly void* Value;

    public ROParamIIDHandle(void* value)
    {
        Value = value;
    }

    public static ROParamIIDHandle INVALID_VALUE => new ROParamIIDHandle((void*)(-1));
    public static ROParamIIDHandle NULL => new ROParamIIDHandle(null);

    public static bool operator ==(ROParamIIDHandle left, ROParamIIDHandle right) =>
        left.Value == right.Value;

    public static bool operator !=(ROParamIIDHandle left, ROParamIIDHandle right) =>
        left.Value != right.Value;

    public static bool operator <(ROParamIIDHandle left, ROParamIIDHandle right) =>
        left.Value < right.Value;

    public static bool operator <=(ROParamIIDHandle left, ROParamIIDHandle right) =>
        left.Value <= right.Value;

    public static bool operator >(ROParamIIDHandle left, ROParamIIDHandle right) =>
        left.Value > right.Value;

    public static bool operator >=(ROParamIIDHandle left, ROParamIIDHandle right) =>
        left.Value >= right.Value;

    public static explicit operator ROParamIIDHandle(void* value) => new ROParamIIDHandle(value);

    public static implicit operator void*(ROParamIIDHandle value) => value.Value;

    public static explicit operator ROParamIIDHandle(Handle value) => new ROParamIIDHandle(value);

    public static implicit operator Handle(ROParamIIDHandle value) => new Handle(value.Value);

    public static explicit operator ROParamIIDHandle(byte value) =>
        new ROParamIIDHandle(unchecked((void*)(value)));

    public static explicit operator byte(ROParamIIDHandle value) => (byte)(value.Value);

    public static explicit operator ROParamIIDHandle(short value) =>
        new ROParamIIDHandle(unchecked((void*)(value)));

    public static explicit operator short(ROParamIIDHandle value) => (short)(value.Value);

    public static explicit operator ROParamIIDHandle(int value) =>
        new ROParamIIDHandle(unchecked((void*)(value)));

    public static explicit operator int(ROParamIIDHandle value) => (int)(value.Value);

    public static explicit operator ROParamIIDHandle(long value) =>
        new ROParamIIDHandle(unchecked((void*)(value)));

    public static explicit operator long(ROParamIIDHandle value) => (long)(value.Value);

    public static explicit operator ROParamIIDHandle(nint value) =>
        new ROParamIIDHandle(unchecked((void*)(value)));

    public static implicit operator nint(ROParamIIDHandle value) => (nint)(value.Value);

    public static explicit operator ROParamIIDHandle(sbyte value) =>
        new ROParamIIDHandle(unchecked((void*)(value)));

    public static explicit operator sbyte(ROParamIIDHandle value) => (sbyte)(value.Value);

    public static explicit operator ROParamIIDHandle(ushort value) =>
        new ROParamIIDHandle(unchecked((void*)(value)));

    public static explicit operator ushort(ROParamIIDHandle value) => (ushort)(value.Value);

    public static explicit operator ROParamIIDHandle(uint value) =>
        new ROParamIIDHandle(unchecked((void*)(value)));

    public static explicit operator uint(ROParamIIDHandle value) => (uint)(value.Value);

    public static explicit operator ROParamIIDHandle(ulong value) =>
        new ROParamIIDHandle(unchecked((void*)(value)));

    public static explicit operator ulong(ROParamIIDHandle value) => (ulong)(value.Value);

    public static explicit operator ROParamIIDHandle(nuint value) =>
        new ROParamIIDHandle(unchecked((void*)(value)));

    public static implicit operator nuint(ROParamIIDHandle value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is ROParamIIDHandle other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of ROPARAMIIDHANDLE.");
    }

    public int CompareTo(ROParamIIDHandle other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is ROParamIIDHandle other) && Equals(other);

    public bool Equals(ROParamIIDHandle other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
