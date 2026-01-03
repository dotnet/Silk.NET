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

public readonly unsafe partial struct PtpCallbackInstance
    : IComparable,
        IComparable<PtpCallbackInstance>,
        IEquatable<PtpCallbackInstance>,
        IFormattable
{
    public readonly void* Value;

    public PtpCallbackInstance(void* value)
    {
        Value = value;
    }

    public static PtpCallbackInstance NULL => new PtpCallbackInstance(null);

    public static bool operator ==(PtpCallbackInstance left, PtpCallbackInstance right) =>
        left.Value == right.Value;

    public static bool operator !=(PtpCallbackInstance left, PtpCallbackInstance right) =>
        left.Value != right.Value;

    public static bool operator <(PtpCallbackInstance left, PtpCallbackInstance right) =>
        left.Value < right.Value;

    public static bool operator <=(PtpCallbackInstance left, PtpCallbackInstance right) =>
        left.Value <= right.Value;

    public static bool operator >(PtpCallbackInstance left, PtpCallbackInstance right) =>
        left.Value > right.Value;

    public static bool operator >=(PtpCallbackInstance left, PtpCallbackInstance right) =>
        left.Value >= right.Value;

    public static explicit operator PtpCallbackInstance(void* value) =>
        new PtpCallbackInstance(value);

    public static implicit operator void*(PtpCallbackInstance value) => value.Value;

    public static explicit operator PtpCallbackInstance(byte value) =>
        new PtpCallbackInstance(unchecked((void*)(value)));

    public static explicit operator byte(PtpCallbackInstance value) => (byte)(value.Value);

    public static explicit operator PtpCallbackInstance(short value) =>
        new PtpCallbackInstance(unchecked((void*)(value)));

    public static explicit operator short(PtpCallbackInstance value) => (short)(value.Value);

    public static explicit operator PtpCallbackInstance(int value) =>
        new PtpCallbackInstance(unchecked((void*)(value)));

    public static explicit operator int(PtpCallbackInstance value) => (int)(value.Value);

    public static explicit operator PtpCallbackInstance(long value) =>
        new PtpCallbackInstance(unchecked((void*)(value)));

    public static explicit operator long(PtpCallbackInstance value) => (long)(value.Value);

    public static explicit operator PtpCallbackInstance(nint value) =>
        new PtpCallbackInstance(unchecked((void*)(value)));

    public static implicit operator nint(PtpCallbackInstance value) => (nint)(value.Value);

    public static explicit operator PtpCallbackInstance(sbyte value) =>
        new PtpCallbackInstance(unchecked((void*)(value)));

    public static explicit operator sbyte(PtpCallbackInstance value) => (sbyte)(value.Value);

    public static explicit operator PtpCallbackInstance(ushort value) =>
        new PtpCallbackInstance(unchecked((void*)(value)));

    public static explicit operator ushort(PtpCallbackInstance value) => (ushort)(value.Value);

    public static explicit operator PtpCallbackInstance(uint value) =>
        new PtpCallbackInstance(unchecked((void*)(value)));

    public static explicit operator uint(PtpCallbackInstance value) => (uint)(value.Value);

    public static explicit operator PtpCallbackInstance(ulong value) =>
        new PtpCallbackInstance(unchecked((void*)(value)));

    public static explicit operator ulong(PtpCallbackInstance value) => (ulong)(value.Value);

    public static explicit operator PtpCallbackInstance(nuint value) =>
        new PtpCallbackInstance(unchecked((void*)(value)));

    public static implicit operator nuint(PtpCallbackInstance value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PtpCallbackInstance other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PTP_CALLBACK_INSTANCE.");
    }

    public int CompareTo(PtpCallbackInstance other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is PtpCallbackInstance other) && Equals(other);

    public bool Equals(PtpCallbackInstance other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
