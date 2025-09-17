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

public readonly unsafe partial struct Hcatadmin
    : IComparable,
        IComparable<Hcatadmin>,
        IEquatable<Hcatadmin>,
        IFormattable
{
    public readonly void* Value;

    public Hcatadmin(void* value)
    {
        Value = value;
    }

    public static Hcatadmin INVALID_VALUE => new Hcatadmin((void*)(-1));
    public static Hcatadmin NULL => new Hcatadmin(null);

    public static bool operator ==(Hcatadmin left, Hcatadmin right) => left.Value == right.Value;

    public static bool operator !=(Hcatadmin left, Hcatadmin right) => left.Value != right.Value;

    public static bool operator <(Hcatadmin left, Hcatadmin right) => left.Value < right.Value;

    public static bool operator <=(Hcatadmin left, Hcatadmin right) => left.Value <= right.Value;

    public static bool operator >(Hcatadmin left, Hcatadmin right) => left.Value > right.Value;

    public static bool operator >=(Hcatadmin left, Hcatadmin right) => left.Value >= right.Value;

    public static explicit operator Hcatadmin(void* value) => new Hcatadmin(value);

    public static implicit operator void*(Hcatadmin value) => value.Value;

    public static explicit operator Hcatadmin(Handle value) => new Hcatadmin(value);

    public static implicit operator Handle(Hcatadmin value) => new Handle(value.Value);

    public static explicit operator Hcatadmin(byte value) =>
        new Hcatadmin(unchecked((void*)(value)));

    public static explicit operator byte(Hcatadmin value) => (byte)(value.Value);

    public static explicit operator Hcatadmin(short value) =>
        new Hcatadmin(unchecked((void*)(value)));

    public static explicit operator short(Hcatadmin value) => (short)(value.Value);

    public static explicit operator Hcatadmin(int value) =>
        new Hcatadmin(unchecked((void*)(value)));

    public static explicit operator int(Hcatadmin value) => (int)(value.Value);

    public static explicit operator Hcatadmin(long value) =>
        new Hcatadmin(unchecked((void*)(value)));

    public static explicit operator long(Hcatadmin value) => (long)(value.Value);

    public static explicit operator Hcatadmin(nint value) =>
        new Hcatadmin(unchecked((void*)(value)));

    public static implicit operator nint(Hcatadmin value) => (nint)(value.Value);

    public static explicit operator Hcatadmin(sbyte value) =>
        new Hcatadmin(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcatadmin value) => (sbyte)(value.Value);

    public static explicit operator Hcatadmin(ushort value) =>
        new Hcatadmin(unchecked((void*)(value)));

    public static explicit operator ushort(Hcatadmin value) => (ushort)(value.Value);

    public static explicit operator Hcatadmin(uint value) =>
        new Hcatadmin(unchecked((void*)(value)));

    public static explicit operator uint(Hcatadmin value) => (uint)(value.Value);

    public static explicit operator Hcatadmin(ulong value) =>
        new Hcatadmin(unchecked((void*)(value)));

    public static explicit operator ulong(Hcatadmin value) => (ulong)(value.Value);

    public static explicit operator Hcatadmin(nuint value) =>
        new Hcatadmin(unchecked((void*)(value)));

    public static implicit operator nuint(Hcatadmin value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcatadmin other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCATADMIN.");
    }

    public int CompareTo(Hcatadmin other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hcatadmin other) && Equals(other);

    public bool Equals(Hcatadmin other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
