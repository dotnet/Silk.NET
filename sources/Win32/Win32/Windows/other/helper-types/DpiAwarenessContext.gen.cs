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

public readonly unsafe partial struct DpiAwarenessContext
    : IComparable,
        IComparable<DpiAwarenessContext>,
        IEquatable<DpiAwarenessContext>,
        IFormattable
{
    public readonly void* Value;

    public DpiAwarenessContext(void* value)
    {
        Value = value;
    }

    public static DpiAwarenessContext INVALID_VALUE => new DpiAwarenessContext((void*)(-1));
    public static DpiAwarenessContext NULL => new DpiAwarenessContext(null);

    public static bool operator ==(DpiAwarenessContext left, DpiAwarenessContext right) =>
        left.Value == right.Value;

    public static bool operator !=(DpiAwarenessContext left, DpiAwarenessContext right) =>
        left.Value != right.Value;

    public static bool operator <(DpiAwarenessContext left, DpiAwarenessContext right) =>
        left.Value < right.Value;

    public static bool operator <=(DpiAwarenessContext left, DpiAwarenessContext right) =>
        left.Value <= right.Value;

    public static bool operator >(DpiAwarenessContext left, DpiAwarenessContext right) =>
        left.Value > right.Value;

    public static bool operator >=(DpiAwarenessContext left, DpiAwarenessContext right) =>
        left.Value >= right.Value;

    public static explicit operator DpiAwarenessContext(void* value) =>
        new DpiAwarenessContext(value);

    public static implicit operator void*(DpiAwarenessContext value) => value.Value;

    public static explicit operator DpiAwarenessContext(Handle value) =>
        new DpiAwarenessContext(value);

    public static implicit operator Handle(DpiAwarenessContext value) => new Handle(value.Value);

    public static explicit operator DpiAwarenessContext(byte value) =>
        new DpiAwarenessContext(unchecked((void*)(value)));

    public static explicit operator byte(DpiAwarenessContext value) => (byte)(value.Value);

    public static explicit operator DpiAwarenessContext(short value) =>
        new DpiAwarenessContext(unchecked((void*)(value)));

    public static explicit operator short(DpiAwarenessContext value) => (short)(value.Value);

    public static explicit operator DpiAwarenessContext(int value) =>
        new DpiAwarenessContext(unchecked((void*)(value)));

    public static explicit operator int(DpiAwarenessContext value) => (int)(value.Value);

    public static explicit operator DpiAwarenessContext(long value) =>
        new DpiAwarenessContext(unchecked((void*)(value)));

    public static explicit operator long(DpiAwarenessContext value) => (long)(value.Value);

    public static explicit operator DpiAwarenessContext(nint value) =>
        new DpiAwarenessContext(unchecked((void*)(value)));

    public static implicit operator nint(DpiAwarenessContext value) => (nint)(value.Value);

    public static explicit operator DpiAwarenessContext(sbyte value) =>
        new DpiAwarenessContext(unchecked((void*)(value)));

    public static explicit operator sbyte(DpiAwarenessContext value) => (sbyte)(value.Value);

    public static explicit operator DpiAwarenessContext(ushort value) =>
        new DpiAwarenessContext(unchecked((void*)(value)));

    public static explicit operator ushort(DpiAwarenessContext value) => (ushort)(value.Value);

    public static explicit operator DpiAwarenessContext(uint value) =>
        new DpiAwarenessContext(unchecked((void*)(value)));

    public static explicit operator uint(DpiAwarenessContext value) => (uint)(value.Value);

    public static explicit operator DpiAwarenessContext(ulong value) =>
        new DpiAwarenessContext(unchecked((void*)(value)));

    public static explicit operator ulong(DpiAwarenessContext value) => (ulong)(value.Value);

    public static explicit operator DpiAwarenessContext(nuint value) =>
        new DpiAwarenessContext(unchecked((void*)(value)));

    public static implicit operator nuint(DpiAwarenessContext value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is DpiAwarenessContext other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of DPI_AWARENESS_CONTEXT.");
    }

    public int CompareTo(DpiAwarenessContext other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is DpiAwarenessContext other) && Equals(other);

    public bool Equals(DpiAwarenessContext other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
