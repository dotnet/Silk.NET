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

public readonly unsafe partial struct Hwineventhook
    : IComparable,
        IComparable<Hwineventhook>,
        IEquatable<Hwineventhook>,
        IFormattable
{
    public readonly void* Value;

    public Hwineventhook(void* value)
    {
        Value = value;
    }

    public static Hwineventhook INVALID_VALUE => new Hwineventhook((void*)(-1));
    public static Hwineventhook NULL => new Hwineventhook(null);

    public static bool operator ==(Hwineventhook left, Hwineventhook right) =>
        left.Value == right.Value;

    public static bool operator !=(Hwineventhook left, Hwineventhook right) =>
        left.Value != right.Value;

    public static bool operator <(Hwineventhook left, Hwineventhook right) =>
        left.Value < right.Value;

    public static bool operator <=(Hwineventhook left, Hwineventhook right) =>
        left.Value <= right.Value;

    public static bool operator >(Hwineventhook left, Hwineventhook right) =>
        left.Value > right.Value;

    public static bool operator >=(Hwineventhook left, Hwineventhook right) =>
        left.Value >= right.Value;

    public static explicit operator Hwineventhook(void* value) => new Hwineventhook(value);

    public static implicit operator void*(Hwineventhook value) => value.Value;

    public static explicit operator Hwineventhook(Handle value) => new Hwineventhook(value);

    public static implicit operator Handle(Hwineventhook value) => new Handle(value.Value);

    public static explicit operator Hwineventhook(byte value) =>
        new Hwineventhook(unchecked((void*)(value)));

    public static explicit operator byte(Hwineventhook value) => (byte)(value.Value);

    public static explicit operator Hwineventhook(short value) =>
        new Hwineventhook(unchecked((void*)(value)));

    public static explicit operator short(Hwineventhook value) => (short)(value.Value);

    public static explicit operator Hwineventhook(int value) =>
        new Hwineventhook(unchecked((void*)(value)));

    public static explicit operator int(Hwineventhook value) => (int)(value.Value);

    public static explicit operator Hwineventhook(long value) =>
        new Hwineventhook(unchecked((void*)(value)));

    public static explicit operator long(Hwineventhook value) => (long)(value.Value);

    public static explicit operator Hwineventhook(nint value) =>
        new Hwineventhook(unchecked((void*)(value)));

    public static implicit operator nint(Hwineventhook value) => (nint)(value.Value);

    public static explicit operator Hwineventhook(sbyte value) =>
        new Hwineventhook(unchecked((void*)(value)));

    public static explicit operator sbyte(Hwineventhook value) => (sbyte)(value.Value);

    public static explicit operator Hwineventhook(ushort value) =>
        new Hwineventhook(unchecked((void*)(value)));

    public static explicit operator ushort(Hwineventhook value) => (ushort)(value.Value);

    public static explicit operator Hwineventhook(uint value) =>
        new Hwineventhook(unchecked((void*)(value)));

    public static explicit operator uint(Hwineventhook value) => (uint)(value.Value);

    public static explicit operator Hwineventhook(ulong value) =>
        new Hwineventhook(unchecked((void*)(value)));

    public static explicit operator ulong(Hwineventhook value) => (ulong)(value.Value);

    public static explicit operator Hwineventhook(nuint value) =>
        new Hwineventhook(unchecked((void*)(value)));

    public static implicit operator nuint(Hwineventhook value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hwineventhook other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HWINEVENTHOOK.");
    }

    public int CompareTo(Hwineventhook other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hwineventhook other) && Equals(other);

    public bool Equals(Hwineventhook other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
