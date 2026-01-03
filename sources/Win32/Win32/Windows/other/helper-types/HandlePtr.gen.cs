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

public readonly unsafe partial struct HandlePtr
    : IComparable,
        IComparable<HandlePtr>,
        IEquatable<HandlePtr>,
        IFormattable
{
    public readonly void* Value;

    public HandlePtr(void* value)
    {
        Value = value;
    }

    public static HandlePtr NULL => new HandlePtr(null);

    public static bool operator ==(HandlePtr left, HandlePtr right) => left.Value == right.Value;

    public static bool operator !=(HandlePtr left, HandlePtr right) => left.Value != right.Value;

    public static bool operator <(HandlePtr left, HandlePtr right) => left.Value < right.Value;

    public static bool operator <=(HandlePtr left, HandlePtr right) => left.Value <= right.Value;

    public static bool operator >(HandlePtr left, HandlePtr right) => left.Value > right.Value;

    public static bool operator >=(HandlePtr left, HandlePtr right) => left.Value >= right.Value;

    public static explicit operator HandlePtr(void* value) => new HandlePtr(value);

    public static implicit operator void*(HandlePtr value) => value.Value;

    public static explicit operator HandlePtr(byte value) =>
        new HandlePtr(unchecked((void*)(value)));

    public static explicit operator byte(HandlePtr value) => (byte)(value.Value);

    public static explicit operator HandlePtr(short value) =>
        new HandlePtr(unchecked((void*)(value)));

    public static explicit operator short(HandlePtr value) => (short)(value.Value);

    public static explicit operator HandlePtr(int value) =>
        new HandlePtr(unchecked((void*)(value)));

    public static explicit operator int(HandlePtr value) => (int)(value.Value);

    public static explicit operator HandlePtr(long value) =>
        new HandlePtr(unchecked((void*)(value)));

    public static explicit operator long(HandlePtr value) => (long)(value.Value);

    public static explicit operator HandlePtr(nint value) =>
        new HandlePtr(unchecked((void*)(value)));

    public static implicit operator nint(HandlePtr value) => (nint)(value.Value);

    public static explicit operator HandlePtr(sbyte value) =>
        new HandlePtr(unchecked((void*)(value)));

    public static explicit operator sbyte(HandlePtr value) => (sbyte)(value.Value);

    public static explicit operator HandlePtr(ushort value) =>
        new HandlePtr(unchecked((void*)(value)));

    public static explicit operator ushort(HandlePtr value) => (ushort)(value.Value);

    public static explicit operator HandlePtr(uint value) =>
        new HandlePtr(unchecked((void*)(value)));

    public static explicit operator uint(HandlePtr value) => (uint)(value.Value);

    public static explicit operator HandlePtr(ulong value) =>
        new HandlePtr(unchecked((void*)(value)));

    public static explicit operator ulong(HandlePtr value) => (ulong)(value.Value);

    public static explicit operator HandlePtr(nuint value) =>
        new HandlePtr(unchecked((void*)(value)));

    public static implicit operator nuint(HandlePtr value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HandlePtr other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HANDLE_PTR.");
    }

    public int CompareTo(HandlePtr other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HandlePtr other) && Equals(other);

    public bool Equals(HandlePtr other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
