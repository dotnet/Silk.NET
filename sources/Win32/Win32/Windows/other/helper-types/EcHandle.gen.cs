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

public readonly unsafe partial struct EcHandle
    : IComparable,
        IComparable<EcHandle>,
        IEquatable<EcHandle>,
        IFormattable
{
    public readonly void* Value;

    public EcHandle(void* value)
    {
        Value = value;
    }

    public static EcHandle INVALID_VALUE => new EcHandle((void*)(-1));
    public static EcHandle NULL => new EcHandle(null);

    public static bool operator ==(EcHandle left, EcHandle right) => left.Value == right.Value;

    public static bool operator !=(EcHandle left, EcHandle right) => left.Value != right.Value;

    public static bool operator <(EcHandle left, EcHandle right) => left.Value < right.Value;

    public static bool operator <=(EcHandle left, EcHandle right) => left.Value <= right.Value;

    public static bool operator >(EcHandle left, EcHandle right) => left.Value > right.Value;

    public static bool operator >=(EcHandle left, EcHandle right) => left.Value >= right.Value;

    public static explicit operator EcHandle(void* value) => new EcHandle(value);

    public static implicit operator void*(EcHandle value) => value.Value;

    public static explicit operator EcHandle(Handle value) => new EcHandle(value);

    public static implicit operator Handle(EcHandle value) => new Handle(value.Value);

    public static explicit operator EcHandle(byte value) => new EcHandle(unchecked((void*)(value)));

    public static explicit operator byte(EcHandle value) => (byte)(value.Value);

    public static explicit operator EcHandle(short value) =>
        new EcHandle(unchecked((void*)(value)));

    public static explicit operator short(EcHandle value) => (short)(value.Value);

    public static explicit operator EcHandle(int value) => new EcHandle(unchecked((void*)(value)));

    public static explicit operator int(EcHandle value) => (int)(value.Value);

    public static explicit operator EcHandle(long value) => new EcHandle(unchecked((void*)(value)));

    public static explicit operator long(EcHandle value) => (long)(value.Value);

    public static explicit operator EcHandle(nint value) => new EcHandle(unchecked((void*)(value)));

    public static implicit operator nint(EcHandle value) => (nint)(value.Value);

    public static explicit operator EcHandle(sbyte value) =>
        new EcHandle(unchecked((void*)(value)));

    public static explicit operator sbyte(EcHandle value) => (sbyte)(value.Value);

    public static explicit operator EcHandle(ushort value) =>
        new EcHandle(unchecked((void*)(value)));

    public static explicit operator ushort(EcHandle value) => (ushort)(value.Value);

    public static explicit operator EcHandle(uint value) => new EcHandle(unchecked((void*)(value)));

    public static explicit operator uint(EcHandle value) => (uint)(value.Value);

    public static explicit operator EcHandle(ulong value) =>
        new EcHandle(unchecked((void*)(value)));

    public static explicit operator ulong(EcHandle value) => (ulong)(value.Value);

    public static explicit operator EcHandle(nuint value) =>
        new EcHandle(unchecked((void*)(value)));

    public static implicit operator nuint(EcHandle value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is EcHandle other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of EC_HANDLE.");
    }

    public int CompareTo(EcHandle other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is EcHandle other) && Equals(other);

    public bool Equals(EcHandle other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
