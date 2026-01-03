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

public readonly unsafe partial struct PtpCleanupGroup
    : IComparable,
        IComparable<PtpCleanupGroup>,
        IEquatable<PtpCleanupGroup>,
        IFormattable
{
    public readonly void* Value;

    public PtpCleanupGroup(void* value)
    {
        Value = value;
    }

    public static PtpCleanupGroup NULL => new PtpCleanupGroup(null);

    public static bool operator ==(PtpCleanupGroup left, PtpCleanupGroup right) =>
        left.Value == right.Value;

    public static bool operator !=(PtpCleanupGroup left, PtpCleanupGroup right) =>
        left.Value != right.Value;

    public static bool operator <(PtpCleanupGroup left, PtpCleanupGroup right) =>
        left.Value < right.Value;

    public static bool operator <=(PtpCleanupGroup left, PtpCleanupGroup right) =>
        left.Value <= right.Value;

    public static bool operator >(PtpCleanupGroup left, PtpCleanupGroup right) =>
        left.Value > right.Value;

    public static bool operator >=(PtpCleanupGroup left, PtpCleanupGroup right) =>
        left.Value >= right.Value;

    public static explicit operator PtpCleanupGroup(void* value) => new PtpCleanupGroup(value);

    public static implicit operator void*(PtpCleanupGroup value) => value.Value;

    public static explicit operator PtpCleanupGroup(byte value) =>
        new PtpCleanupGroup(unchecked((void*)(value)));

    public static explicit operator byte(PtpCleanupGroup value) => (byte)(value.Value);

    public static explicit operator PtpCleanupGroup(short value) =>
        new PtpCleanupGroup(unchecked((void*)(value)));

    public static explicit operator short(PtpCleanupGroup value) => (short)(value.Value);

    public static explicit operator PtpCleanupGroup(int value) =>
        new PtpCleanupGroup(unchecked((void*)(value)));

    public static explicit operator int(PtpCleanupGroup value) => (int)(value.Value);

    public static explicit operator PtpCleanupGroup(long value) =>
        new PtpCleanupGroup(unchecked((void*)(value)));

    public static explicit operator long(PtpCleanupGroup value) => (long)(value.Value);

    public static explicit operator PtpCleanupGroup(nint value) =>
        new PtpCleanupGroup(unchecked((void*)(value)));

    public static implicit operator nint(PtpCleanupGroup value) => (nint)(value.Value);

    public static explicit operator PtpCleanupGroup(sbyte value) =>
        new PtpCleanupGroup(unchecked((void*)(value)));

    public static explicit operator sbyte(PtpCleanupGroup value) => (sbyte)(value.Value);

    public static explicit operator PtpCleanupGroup(ushort value) =>
        new PtpCleanupGroup(unchecked((void*)(value)));

    public static explicit operator ushort(PtpCleanupGroup value) => (ushort)(value.Value);

    public static explicit operator PtpCleanupGroup(uint value) =>
        new PtpCleanupGroup(unchecked((void*)(value)));

    public static explicit operator uint(PtpCleanupGroup value) => (uint)(value.Value);

    public static explicit operator PtpCleanupGroup(ulong value) =>
        new PtpCleanupGroup(unchecked((void*)(value)));

    public static explicit operator ulong(PtpCleanupGroup value) => (ulong)(value.Value);

    public static explicit operator PtpCleanupGroup(nuint value) =>
        new PtpCleanupGroup(unchecked((void*)(value)));

    public static implicit operator nuint(PtpCleanupGroup value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PtpCleanupGroup other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PTP_CLEANUP_GROUP.");
    }

    public int CompareTo(PtpCleanupGroup other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is PtpCleanupGroup other) && Equals(other);

    public bool Equals(PtpCleanupGroup other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
