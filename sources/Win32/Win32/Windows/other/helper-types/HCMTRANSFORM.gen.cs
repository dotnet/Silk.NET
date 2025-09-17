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

public readonly unsafe partial struct Hcmtransform
    : IComparable,
        IComparable<Hcmtransform>,
        IEquatable<Hcmtransform>,
        IFormattable
{
    public readonly void* Value;

    public Hcmtransform(void* value)
    {
        Value = value;
    }

    public static Hcmtransform INVALID_VALUE => new Hcmtransform((void*)(-1));
    public static Hcmtransform NULL => new Hcmtransform(null);

    public static bool operator ==(Hcmtransform left, Hcmtransform right) =>
        left.Value == right.Value;

    public static bool operator !=(Hcmtransform left, Hcmtransform right) =>
        left.Value != right.Value;

    public static bool operator <(Hcmtransform left, Hcmtransform right) =>
        left.Value < right.Value;

    public static bool operator <=(Hcmtransform left, Hcmtransform right) =>
        left.Value <= right.Value;

    public static bool operator >(Hcmtransform left, Hcmtransform right) =>
        left.Value > right.Value;

    public static bool operator >=(Hcmtransform left, Hcmtransform right) =>
        left.Value >= right.Value;

    public static explicit operator Hcmtransform(void* value) => new Hcmtransform(value);

    public static implicit operator void*(Hcmtransform value) => value.Value;

    public static explicit operator Hcmtransform(Handle value) => new Hcmtransform(value);

    public static implicit operator Handle(Hcmtransform value) => new Handle(value.Value);

    public static explicit operator Hcmtransform(byte value) =>
        new Hcmtransform(unchecked((void*)(value)));

    public static explicit operator byte(Hcmtransform value) => (byte)(value.Value);

    public static explicit operator Hcmtransform(short value) =>
        new Hcmtransform(unchecked((void*)(value)));

    public static explicit operator short(Hcmtransform value) => (short)(value.Value);

    public static explicit operator Hcmtransform(int value) =>
        new Hcmtransform(unchecked((void*)(value)));

    public static explicit operator int(Hcmtransform value) => (int)(value.Value);

    public static explicit operator Hcmtransform(long value) =>
        new Hcmtransform(unchecked((void*)(value)));

    public static explicit operator long(Hcmtransform value) => (long)(value.Value);

    public static explicit operator Hcmtransform(nint value) =>
        new Hcmtransform(unchecked((void*)(value)));

    public static implicit operator nint(Hcmtransform value) => (nint)(value.Value);

    public static explicit operator Hcmtransform(sbyte value) =>
        new Hcmtransform(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcmtransform value) => (sbyte)(value.Value);

    public static explicit operator Hcmtransform(ushort value) =>
        new Hcmtransform(unchecked((void*)(value)));

    public static explicit operator ushort(Hcmtransform value) => (ushort)(value.Value);

    public static explicit operator Hcmtransform(uint value) =>
        new Hcmtransform(unchecked((void*)(value)));

    public static explicit operator uint(Hcmtransform value) => (uint)(value.Value);

    public static explicit operator Hcmtransform(ulong value) =>
        new Hcmtransform(unchecked((void*)(value)));

    public static explicit operator ulong(Hcmtransform value) => (ulong)(value.Value);

    public static explicit operator Hcmtransform(nuint value) =>
        new Hcmtransform(unchecked((void*)(value)));

    public static implicit operator nuint(Hcmtransform value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcmtransform other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCMTRANSFORM.");
    }

    public int CompareTo(Hcmtransform other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hcmtransform other) && Equals(other);

    public bool Equals(Hcmtransform other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
