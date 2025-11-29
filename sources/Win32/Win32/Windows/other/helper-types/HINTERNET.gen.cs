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

public readonly unsafe partial struct Hinternet
    : IComparable,
        IComparable<Hinternet>,
        IEquatable<Hinternet>,
        IFormattable
{
    public readonly void* Value;

    public Hinternet(void* value)
    {
        Value = value;
    }

    public static Hinternet INVALID_VALUE => new Hinternet((void*)(-1));
    public static Hinternet NULL => new Hinternet(null);

    public static bool operator ==(Hinternet left, Hinternet right) => left.Value == right.Value;

    public static bool operator !=(Hinternet left, Hinternet right) => left.Value != right.Value;

    public static bool operator <(Hinternet left, Hinternet right) => left.Value < right.Value;

    public static bool operator <=(Hinternet left, Hinternet right) => left.Value <= right.Value;

    public static bool operator >(Hinternet left, Hinternet right) => left.Value > right.Value;

    public static bool operator >=(Hinternet left, Hinternet right) => left.Value >= right.Value;

    public static explicit operator Hinternet(void* value) => new Hinternet(value);

    public static implicit operator void*(Hinternet value) => value.Value;

    public static explicit operator Hinternet(Handle value) => new Hinternet(value);

    public static implicit operator Handle(Hinternet value) => new Handle(value.Value);

    public static explicit operator Hinternet(byte value) =>
        new Hinternet(unchecked((void*)(value)));

    public static explicit operator byte(Hinternet value) => (byte)(value.Value);

    public static explicit operator Hinternet(short value) =>
        new Hinternet(unchecked((void*)(value)));

    public static explicit operator short(Hinternet value) => (short)(value.Value);

    public static explicit operator Hinternet(int value) =>
        new Hinternet(unchecked((void*)(value)));

    public static explicit operator int(Hinternet value) => (int)(value.Value);

    public static explicit operator Hinternet(long value) =>
        new Hinternet(unchecked((void*)(value)));

    public static explicit operator long(Hinternet value) => (long)(value.Value);

    public static explicit operator Hinternet(nint value) =>
        new Hinternet(unchecked((void*)(value)));

    public static implicit operator nint(Hinternet value) => (nint)(value.Value);

    public static explicit operator Hinternet(sbyte value) =>
        new Hinternet(unchecked((void*)(value)));

    public static explicit operator sbyte(Hinternet value) => (sbyte)(value.Value);

    public static explicit operator Hinternet(ushort value) =>
        new Hinternet(unchecked((void*)(value)));

    public static explicit operator ushort(Hinternet value) => (ushort)(value.Value);

    public static explicit operator Hinternet(uint value) =>
        new Hinternet(unchecked((void*)(value)));

    public static explicit operator uint(Hinternet value) => (uint)(value.Value);

    public static explicit operator Hinternet(ulong value) =>
        new Hinternet(unchecked((void*)(value)));

    public static explicit operator ulong(Hinternet value) => (ulong)(value.Value);

    public static explicit operator Hinternet(nuint value) =>
        new Hinternet(unchecked((void*)(value)));

    public static implicit operator nuint(Hinternet value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hinternet other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HINTERNET.");
    }

    public int CompareTo(Hinternet other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hinternet other) && Equals(other);

    public bool Equals(Hinternet other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
