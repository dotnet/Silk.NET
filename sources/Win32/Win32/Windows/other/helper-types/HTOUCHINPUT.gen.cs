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

public readonly unsafe partial struct Htouchinput
    : IComparable,
        IComparable<Htouchinput>,
        IEquatable<Htouchinput>,
        IFormattable
{
    public readonly void* Value;

    public Htouchinput(void* value)
    {
        Value = value;
    }

    public static Htouchinput INVALID_VALUE => new Htouchinput((void*)(-1));
    public static Htouchinput NULL => new Htouchinput(null);

    public static bool operator ==(Htouchinput left, Htouchinput right) =>
        left.Value == right.Value;

    public static bool operator !=(Htouchinput left, Htouchinput right) =>
        left.Value != right.Value;

    public static bool operator <(Htouchinput left, Htouchinput right) => left.Value < right.Value;

    public static bool operator <=(Htouchinput left, Htouchinput right) =>
        left.Value <= right.Value;

    public static bool operator >(Htouchinput left, Htouchinput right) => left.Value > right.Value;

    public static bool operator >=(Htouchinput left, Htouchinput right) =>
        left.Value >= right.Value;

    public static explicit operator Htouchinput(void* value) => new Htouchinput(value);

    public static implicit operator void*(Htouchinput value) => value.Value;

    public static explicit operator Htouchinput(Handle value) => new Htouchinput(value);

    public static implicit operator Handle(Htouchinput value) => new Handle(value.Value);

    public static explicit operator Htouchinput(byte value) =>
        new Htouchinput(unchecked((void*)(value)));

    public static explicit operator byte(Htouchinput value) => (byte)(value.Value);

    public static explicit operator Htouchinput(short value) =>
        new Htouchinput(unchecked((void*)(value)));

    public static explicit operator short(Htouchinput value) => (short)(value.Value);

    public static explicit operator Htouchinput(int value) =>
        new Htouchinput(unchecked((void*)(value)));

    public static explicit operator int(Htouchinput value) => (int)(value.Value);

    public static explicit operator Htouchinput(long value) =>
        new Htouchinput(unchecked((void*)(value)));

    public static explicit operator long(Htouchinput value) => (long)(value.Value);

    public static explicit operator Htouchinput(nint value) =>
        new Htouchinput(unchecked((void*)(value)));

    public static implicit operator nint(Htouchinput value) => (nint)(value.Value);

    public static explicit operator Htouchinput(sbyte value) =>
        new Htouchinput(unchecked((void*)(value)));

    public static explicit operator sbyte(Htouchinput value) => (sbyte)(value.Value);

    public static explicit operator Htouchinput(ushort value) =>
        new Htouchinput(unchecked((void*)(value)));

    public static explicit operator ushort(Htouchinput value) => (ushort)(value.Value);

    public static explicit operator Htouchinput(uint value) =>
        new Htouchinput(unchecked((void*)(value)));

    public static explicit operator uint(Htouchinput value) => (uint)(value.Value);

    public static explicit operator Htouchinput(ulong value) =>
        new Htouchinput(unchecked((void*)(value)));

    public static explicit operator ulong(Htouchinput value) => (ulong)(value.Value);

    public static explicit operator Htouchinput(nuint value) =>
        new Htouchinput(unchecked((void*)(value)));

    public static implicit operator nuint(Htouchinput value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Htouchinput other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HTOUCHINPUT.");
    }

    public int CompareTo(Htouchinput other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Htouchinput other) && Equals(other);

    public bool Equals(Htouchinput other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
