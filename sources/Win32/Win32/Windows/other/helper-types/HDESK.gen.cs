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

public readonly unsafe partial struct Hdesk
    : IComparable,
        IComparable<Hdesk>,
        IEquatable<Hdesk>,
        IFormattable
{
    public readonly void* Value;

    public Hdesk(void* value)
    {
        Value = value;
    }

    public static Hdesk INVALID_VALUE => new Hdesk((void*)(-1));
    public static Hdesk NULL => new Hdesk(null);

    public static bool operator ==(Hdesk left, Hdesk right) => left.Value == right.Value;

    public static bool operator !=(Hdesk left, Hdesk right) => left.Value != right.Value;

    public static bool operator <(Hdesk left, Hdesk right) => left.Value < right.Value;

    public static bool operator <=(Hdesk left, Hdesk right) => left.Value <= right.Value;

    public static bool operator >(Hdesk left, Hdesk right) => left.Value > right.Value;

    public static bool operator >=(Hdesk left, Hdesk right) => left.Value >= right.Value;

    public static explicit operator Hdesk(void* value) => new Hdesk(value);

    public static implicit operator void*(Hdesk value) => value.Value;

    public static explicit operator Hdesk(Handle value) => new Hdesk(value);

    public static implicit operator Handle(Hdesk value) => new Handle(value.Value);

    public static explicit operator Hdesk(byte value) => new Hdesk(unchecked((void*)(value)));

    public static explicit operator byte(Hdesk value) => (byte)(value.Value);

    public static explicit operator Hdesk(short value) => new Hdesk(unchecked((void*)(value)));

    public static explicit operator short(Hdesk value) => (short)(value.Value);

    public static explicit operator Hdesk(int value) => new Hdesk(unchecked((void*)(value)));

    public static explicit operator int(Hdesk value) => (int)(value.Value);

    public static explicit operator Hdesk(long value) => new Hdesk(unchecked((void*)(value)));

    public static explicit operator long(Hdesk value) => (long)(value.Value);

    public static explicit operator Hdesk(nint value) => new Hdesk(unchecked((void*)(value)));

    public static implicit operator nint(Hdesk value) => (nint)(value.Value);

    public static explicit operator Hdesk(sbyte value) => new Hdesk(unchecked((void*)(value)));

    public static explicit operator sbyte(Hdesk value) => (sbyte)(value.Value);

    public static explicit operator Hdesk(ushort value) => new Hdesk(unchecked((void*)(value)));

    public static explicit operator ushort(Hdesk value) => (ushort)(value.Value);

    public static explicit operator Hdesk(uint value) => new Hdesk(unchecked((void*)(value)));

    public static explicit operator uint(Hdesk value) => (uint)(value.Value);

    public static explicit operator Hdesk(ulong value) => new Hdesk(unchecked((void*)(value)));

    public static explicit operator ulong(Hdesk value) => (ulong)(value.Value);

    public static explicit operator Hdesk(nuint value) => new Hdesk(unchecked((void*)(value)));

    public static implicit operator nuint(Hdesk value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Hdesk other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDESK.");
    }

    public int CompareTo(Hdesk other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Hdesk other) && Equals(other);

    public bool Equals(Hdesk other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
