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

public readonly unsafe partial struct PtpPool
    : IComparable,
        IComparable<PtpPool>,
        IEquatable<PtpPool>,
        IFormattable
{
    public readonly void* Value;

    public PtpPool(void* value)
    {
        Value = value;
    }

    public static PtpPool NULL => new PtpPool(null);

    public static bool operator ==(PtpPool left, PtpPool right) => left.Value == right.Value;

    public static bool operator !=(PtpPool left, PtpPool right) => left.Value != right.Value;

    public static bool operator <(PtpPool left, PtpPool right) => left.Value < right.Value;

    public static bool operator <=(PtpPool left, PtpPool right) => left.Value <= right.Value;

    public static bool operator >(PtpPool left, PtpPool right) => left.Value > right.Value;

    public static bool operator >=(PtpPool left, PtpPool right) => left.Value >= right.Value;

    public static explicit operator PtpPool(void* value) => new PtpPool(value);

    public static implicit operator void*(PtpPool value) => value.Value;

    public static explicit operator PtpPool(byte value) => new PtpPool(unchecked((void*)(value)));

    public static explicit operator byte(PtpPool value) => (byte)(value.Value);

    public static explicit operator PtpPool(short value) => new PtpPool(unchecked((void*)(value)));

    public static explicit operator short(PtpPool value) => (short)(value.Value);

    public static explicit operator PtpPool(int value) => new PtpPool(unchecked((void*)(value)));

    public static explicit operator int(PtpPool value) => (int)(value.Value);

    public static explicit operator PtpPool(long value) => new PtpPool(unchecked((void*)(value)));

    public static explicit operator long(PtpPool value) => (long)(value.Value);

    public static explicit operator PtpPool(nint value) => new PtpPool(unchecked((void*)(value)));

    public static implicit operator nint(PtpPool value) => (nint)(value.Value);

    public static explicit operator PtpPool(sbyte value) => new PtpPool(unchecked((void*)(value)));

    public static explicit operator sbyte(PtpPool value) => (sbyte)(value.Value);

    public static explicit operator PtpPool(ushort value) => new PtpPool(unchecked((void*)(value)));

    public static explicit operator ushort(PtpPool value) => (ushort)(value.Value);

    public static explicit operator PtpPool(uint value) => new PtpPool(unchecked((void*)(value)));

    public static explicit operator uint(PtpPool value) => (uint)(value.Value);

    public static explicit operator PtpPool(ulong value) => new PtpPool(unchecked((void*)(value)));

    public static explicit operator ulong(PtpPool value) => (ulong)(value.Value);

    public static explicit operator PtpPool(nuint value) => new PtpPool(unchecked((void*)(value)));

    public static implicit operator nuint(PtpPool value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PtpPool other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PTP_POOL.");
    }

    public int CompareTo(PtpPool other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is PtpPool other) && Equals(other);

    public bool Equals(PtpPool other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
