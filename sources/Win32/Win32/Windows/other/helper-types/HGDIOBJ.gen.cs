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

public readonly unsafe partial struct Hgdiobj
    : IComparable,
        IComparable<Hgdiobj>,
        IEquatable<Hgdiobj>,
        IFormattable
{
    public readonly void* Value;

    public Hgdiobj(void* value)
    {
        Value = value;
    }

    public static Hgdiobj INVALID_VALUE => new Hgdiobj((void*)(-1));
    public static Hgdiobj NULL => new Hgdiobj(null);

    public static bool operator ==(Hgdiobj left, Hgdiobj right) => left.Value == right.Value;

    public static bool operator !=(Hgdiobj left, Hgdiobj right) => left.Value != right.Value;

    public static bool operator <(Hgdiobj left, Hgdiobj right) => left.Value < right.Value;

    public static bool operator <=(Hgdiobj left, Hgdiobj right) => left.Value <= right.Value;

    public static bool operator >(Hgdiobj left, Hgdiobj right) => left.Value > right.Value;

    public static bool operator >=(Hgdiobj left, Hgdiobj right) => left.Value >= right.Value;

    public static explicit operator Hgdiobj(void* value) => new Hgdiobj(value);

    public static implicit operator void*(Hgdiobj value) => value.Value;

    public static explicit operator Hgdiobj(Handle value) => new Hgdiobj(value);

    public static implicit operator Handle(Hgdiobj value) => new Handle(value.Value);

    public static explicit operator Hgdiobj(byte value) => new Hgdiobj(unchecked((void*)(value)));

    public static explicit operator byte(Hgdiobj value) => (byte)(value.Value);

    public static explicit operator Hgdiobj(short value) => new Hgdiobj(unchecked((void*)(value)));

    public static explicit operator short(Hgdiobj value) => (short)(value.Value);

    public static explicit operator Hgdiobj(int value) => new Hgdiobj(unchecked((void*)(value)));

    public static explicit operator int(Hgdiobj value) => (int)(value.Value);

    public static explicit operator Hgdiobj(long value) => new Hgdiobj(unchecked((void*)(value)));

    public static explicit operator long(Hgdiobj value) => (long)(value.Value);

    public static explicit operator Hgdiobj(nint value) => new Hgdiobj(unchecked((void*)(value)));

    public static implicit operator nint(Hgdiobj value) => (nint)(value.Value);

    public static explicit operator Hgdiobj(sbyte value) => new Hgdiobj(unchecked((void*)(value)));

    public static explicit operator sbyte(Hgdiobj value) => (sbyte)(value.Value);

    public static explicit operator Hgdiobj(ushort value) => new Hgdiobj(unchecked((void*)(value)));

    public static explicit operator ushort(Hgdiobj value) => (ushort)(value.Value);

    public static explicit operator Hgdiobj(uint value) => new Hgdiobj(unchecked((void*)(value)));

    public static explicit operator uint(Hgdiobj value) => (uint)(value.Value);

    public static explicit operator Hgdiobj(ulong value) => new Hgdiobj(unchecked((void*)(value)));

    public static explicit operator ulong(Hgdiobj value) => (ulong)(value.Value);

    public static explicit operator Hgdiobj(nuint value) => new Hgdiobj(unchecked((void*)(value)));

    public static implicit operator nuint(Hgdiobj value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hgdiobj other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HGDIOBJ.");
    }

    public int CompareTo(Hgdiobj other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hgdiobj other) && Equals(other);

    public bool Equals(Hgdiobj other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
