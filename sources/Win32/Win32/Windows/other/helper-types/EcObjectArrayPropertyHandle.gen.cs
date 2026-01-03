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
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct EcObjectArrayPropertyHandle
    : IComparable,
        IComparable<EcObjectArrayPropertyHandle>,
        IEquatable<EcObjectArrayPropertyHandle>,
        IFormattable
{
    public readonly void* Value;

    public EcObjectArrayPropertyHandle(void* value)
    {
        Value = value;
    }

    public static EcObjectArrayPropertyHandle INVALID_VALUE =>
        new EcObjectArrayPropertyHandle((void*)(-1));
    public static EcObjectArrayPropertyHandle NULL => new EcObjectArrayPropertyHandle(null);

    public static bool operator ==(
        EcObjectArrayPropertyHandle left,
        EcObjectArrayPropertyHandle right
    ) => left.Value == right.Value;

    public static bool operator !=(
        EcObjectArrayPropertyHandle left,
        EcObjectArrayPropertyHandle right
    ) => left.Value != right.Value;

    public static bool operator <(
        EcObjectArrayPropertyHandle left,
        EcObjectArrayPropertyHandle right
    ) => left.Value < right.Value;

    public static bool operator <=(
        EcObjectArrayPropertyHandle left,
        EcObjectArrayPropertyHandle right
    ) => left.Value <= right.Value;

    public static bool operator >(
        EcObjectArrayPropertyHandle left,
        EcObjectArrayPropertyHandle right
    ) => left.Value > right.Value;

    public static bool operator >=(
        EcObjectArrayPropertyHandle left,
        EcObjectArrayPropertyHandle right
    ) => left.Value >= right.Value;

    public static explicit operator EcObjectArrayPropertyHandle(void* value) =>
        new EcObjectArrayPropertyHandle(value);

    public static implicit operator void*(EcObjectArrayPropertyHandle value) => value.Value;

    public static explicit operator EcObjectArrayPropertyHandle(Handle value) =>
        new EcObjectArrayPropertyHandle(value);

    public static implicit operator Handle(EcObjectArrayPropertyHandle value) =>
        new Handle(value.Value);

    public static explicit operator EcObjectArrayPropertyHandle(byte value) =>
        new EcObjectArrayPropertyHandle(unchecked((void*)(value)));

    public static explicit operator byte(EcObjectArrayPropertyHandle value) => (byte)(value.Value);

    public static explicit operator EcObjectArrayPropertyHandle(short value) =>
        new EcObjectArrayPropertyHandle(unchecked((void*)(value)));

    public static explicit operator short(EcObjectArrayPropertyHandle value) =>
        (short)(value.Value);

    public static explicit operator EcObjectArrayPropertyHandle(int value) =>
        new EcObjectArrayPropertyHandle(unchecked((void*)(value)));

    public static explicit operator int(EcObjectArrayPropertyHandle value) => (int)(value.Value);

    public static explicit operator EcObjectArrayPropertyHandle(long value) =>
        new EcObjectArrayPropertyHandle(unchecked((void*)(value)));

    public static explicit operator long(EcObjectArrayPropertyHandle value) => (long)(value.Value);

    public static explicit operator EcObjectArrayPropertyHandle(nint value) =>
        new EcObjectArrayPropertyHandle(unchecked((void*)(value)));

    public static implicit operator nint(EcObjectArrayPropertyHandle value) => (nint)(value.Value);

    public static explicit operator EcObjectArrayPropertyHandle(sbyte value) =>
        new EcObjectArrayPropertyHandle(unchecked((void*)(value)));

    public static explicit operator sbyte(EcObjectArrayPropertyHandle value) =>
        (sbyte)(value.Value);

    public static explicit operator EcObjectArrayPropertyHandle(ushort value) =>
        new EcObjectArrayPropertyHandle(unchecked((void*)(value)));

    public static explicit operator ushort(EcObjectArrayPropertyHandle value) =>
        (ushort)(value.Value);

    public static explicit operator EcObjectArrayPropertyHandle(uint value) =>
        new EcObjectArrayPropertyHandle(unchecked((void*)(value)));

    public static explicit operator uint(EcObjectArrayPropertyHandle value) => (uint)(value.Value);

    public static explicit operator EcObjectArrayPropertyHandle(ulong value) =>
        new EcObjectArrayPropertyHandle(unchecked((void*)(value)));

    public static explicit operator ulong(EcObjectArrayPropertyHandle value) =>
        (ulong)(value.Value);

    public static explicit operator EcObjectArrayPropertyHandle(nuint value) =>
        new EcObjectArrayPropertyHandle(unchecked((void*)(value)));

    public static implicit operator nuint(EcObjectArrayPropertyHandle value) =>
        (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is EcObjectArrayPropertyHandle other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException(
                "obj is not an instance of EC_OBJECT_ARRAY_PROPERTY_HANDLE."
            );
    }

    public int CompareTo(EcObjectArrayPropertyHandle other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is EcObjectArrayPropertyHandle other) && Equals(other);

    public bool Equals(EcObjectArrayPropertyHandle other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
