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

public readonly unsafe partial struct Asynccompletionhandle
    : IComparable,
        IComparable<Asynccompletionhandle>,
        IEquatable<Asynccompletionhandle>,
        IFormattable
{
    public readonly void* Value;

    public Asynccompletionhandle(void* value)
    {
        Value = value;
    }

    public static Asynccompletionhandle NULL => new Asynccompletionhandle(null);

    public static bool operator ==(Asynccompletionhandle left, Asynccompletionhandle right) =>
        left.Value == right.Value;

    public static bool operator !=(Asynccompletionhandle left, Asynccompletionhandle right) =>
        left.Value != right.Value;

    public static bool operator <(Asynccompletionhandle left, Asynccompletionhandle right) =>
        left.Value < right.Value;

    public static bool operator <=(Asynccompletionhandle left, Asynccompletionhandle right) =>
        left.Value <= right.Value;

    public static bool operator >(Asynccompletionhandle left, Asynccompletionhandle right) =>
        left.Value > right.Value;

    public static bool operator >=(Asynccompletionhandle left, Asynccompletionhandle right) =>
        left.Value >= right.Value;

    public static explicit operator Asynccompletionhandle(void* value) =>
        new Asynccompletionhandle(value);

    public static implicit operator void*(Asynccompletionhandle value) => value.Value;

    public static explicit operator Asynccompletionhandle(byte value) =>
        new Asynccompletionhandle(unchecked((void*)(value)));

    public static explicit operator byte(Asynccompletionhandle value) => (byte)(value.Value);

    public static explicit operator Asynccompletionhandle(short value) =>
        new Asynccompletionhandle(unchecked((void*)(value)));

    public static explicit operator short(Asynccompletionhandle value) => (short)(value.Value);

    public static explicit operator Asynccompletionhandle(int value) =>
        new Asynccompletionhandle(unchecked((void*)(value)));

    public static explicit operator int(Asynccompletionhandle value) => (int)(value.Value);

    public static explicit operator Asynccompletionhandle(long value) =>
        new Asynccompletionhandle(unchecked((void*)(value)));

    public static explicit operator long(Asynccompletionhandle value) => (long)(value.Value);

    public static explicit operator Asynccompletionhandle(nint value) =>
        new Asynccompletionhandle(unchecked((void*)(value)));

    public static implicit operator nint(Asynccompletionhandle value) => (nint)(value.Value);

    public static explicit operator Asynccompletionhandle(sbyte value) =>
        new Asynccompletionhandle(unchecked((void*)(value)));

    public static explicit operator sbyte(Asynccompletionhandle value) => (sbyte)(value.Value);

    public static explicit operator Asynccompletionhandle(ushort value) =>
        new Asynccompletionhandle(unchecked((void*)(value)));

    public static explicit operator ushort(Asynccompletionhandle value) => (ushort)(value.Value);

    public static explicit operator Asynccompletionhandle(uint value) =>
        new Asynccompletionhandle(unchecked((void*)(value)));

    public static explicit operator uint(Asynccompletionhandle value) => (uint)(value.Value);

    public static explicit operator Asynccompletionhandle(ulong value) =>
        new Asynccompletionhandle(unchecked((void*)(value)));

    public static explicit operator ulong(Asynccompletionhandle value) => (ulong)(value.Value);

    public static explicit operator Asynccompletionhandle(nuint value) =>
        new Asynccompletionhandle(unchecked((void*)(value)));

    public static implicit operator nuint(Asynccompletionhandle value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Asynccompletionhandle other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of ASYNCCOMPLETIONHANDLE.");
    }

    public int CompareTo(Asynccompletionhandle other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is Asynccompletionhandle other) && Equals(other);

    public bool Equals(Asynccompletionhandle other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
