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

public readonly unsafe partial struct Hcryptdefaultcontext
    : IComparable,
        IComparable<Hcryptdefaultcontext>,
        IEquatable<Hcryptdefaultcontext>,
        IFormattable
{
    public readonly void* Value;

    public Hcryptdefaultcontext(void* value)
    {
        Value = value;
    }

    public static Hcryptdefaultcontext INVALID_VALUE => new Hcryptdefaultcontext((void*)(-1));
    public static Hcryptdefaultcontext NULL => new Hcryptdefaultcontext(null);

    public static bool operator ==(Hcryptdefaultcontext left, Hcryptdefaultcontext right) =>
        left.Value == right.Value;

    public static bool operator !=(Hcryptdefaultcontext left, Hcryptdefaultcontext right) =>
        left.Value != right.Value;

    public static bool operator <(Hcryptdefaultcontext left, Hcryptdefaultcontext right) =>
        left.Value < right.Value;

    public static bool operator <=(Hcryptdefaultcontext left, Hcryptdefaultcontext right) =>
        left.Value <= right.Value;

    public static bool operator >(Hcryptdefaultcontext left, Hcryptdefaultcontext right) =>
        left.Value > right.Value;

    public static bool operator >=(Hcryptdefaultcontext left, Hcryptdefaultcontext right) =>
        left.Value >= right.Value;

    public static explicit operator Hcryptdefaultcontext(void* value) =>
        new Hcryptdefaultcontext(value);

    public static implicit operator void*(Hcryptdefaultcontext value) => value.Value;

    public static explicit operator Hcryptdefaultcontext(Handle value) =>
        new Hcryptdefaultcontext(value);

    public static implicit operator Handle(Hcryptdefaultcontext value) => new Handle(value.Value);

    public static explicit operator Hcryptdefaultcontext(byte value) =>
        new Hcryptdefaultcontext(unchecked((void*)(value)));

    public static explicit operator byte(Hcryptdefaultcontext value) => (byte)(value.Value);

    public static explicit operator Hcryptdefaultcontext(short value) =>
        new Hcryptdefaultcontext(unchecked((void*)(value)));

    public static explicit operator short(Hcryptdefaultcontext value) => (short)(value.Value);

    public static explicit operator Hcryptdefaultcontext(int value) =>
        new Hcryptdefaultcontext(unchecked((void*)(value)));

    public static explicit operator int(Hcryptdefaultcontext value) => (int)(value.Value);

    public static explicit operator Hcryptdefaultcontext(long value) =>
        new Hcryptdefaultcontext(unchecked((void*)(value)));

    public static explicit operator long(Hcryptdefaultcontext value) => (long)(value.Value);

    public static explicit operator Hcryptdefaultcontext(nint value) =>
        new Hcryptdefaultcontext(unchecked((void*)(value)));

    public static implicit operator nint(Hcryptdefaultcontext value) => (nint)(value.Value);

    public static explicit operator Hcryptdefaultcontext(sbyte value) =>
        new Hcryptdefaultcontext(unchecked((void*)(value)));

    public static explicit operator sbyte(Hcryptdefaultcontext value) => (sbyte)(value.Value);

    public static explicit operator Hcryptdefaultcontext(ushort value) =>
        new Hcryptdefaultcontext(unchecked((void*)(value)));

    public static explicit operator ushort(Hcryptdefaultcontext value) => (ushort)(value.Value);

    public static explicit operator Hcryptdefaultcontext(uint value) =>
        new Hcryptdefaultcontext(unchecked((void*)(value)));

    public static explicit operator uint(Hcryptdefaultcontext value) => (uint)(value.Value);

    public static explicit operator Hcryptdefaultcontext(ulong value) =>
        new Hcryptdefaultcontext(unchecked((void*)(value)));

    public static explicit operator ulong(Hcryptdefaultcontext value) => (ulong)(value.Value);

    public static explicit operator Hcryptdefaultcontext(nuint value) =>
        new Hcryptdefaultcontext(unchecked((void*)(value)));

    public static implicit operator nuint(Hcryptdefaultcontext value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hcryptdefaultcontext other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTDEFAULTCONTEXT.");
    }

    public int CompareTo(Hcryptdefaultcontext other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is Hcryptdefaultcontext other) && Equals(other);

    public bool Equals(Hcryptdefaultcontext other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
