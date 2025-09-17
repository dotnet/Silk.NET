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

public readonly unsafe partial struct CompressorHandle
    : IComparable,
        IComparable<CompressorHandle>,
        IEquatable<CompressorHandle>,
        IFormattable
{
    public readonly void* Value;

    public CompressorHandle(void* value)
    {
        Value = value;
    }

    public static CompressorHandle INVALID_VALUE => new CompressorHandle((void*)(-1));
    public static CompressorHandle NULL => new CompressorHandle(null);

    public static bool operator ==(CompressorHandle left, CompressorHandle right) =>
        left.Value == right.Value;

    public static bool operator !=(CompressorHandle left, CompressorHandle right) =>
        left.Value != right.Value;

    public static bool operator <(CompressorHandle left, CompressorHandle right) =>
        left.Value < right.Value;

    public static bool operator <=(CompressorHandle left, CompressorHandle right) =>
        left.Value <= right.Value;

    public static bool operator >(CompressorHandle left, CompressorHandle right) =>
        left.Value > right.Value;

    public static bool operator >=(CompressorHandle left, CompressorHandle right) =>
        left.Value >= right.Value;

    public static explicit operator CompressorHandle(void* value) => new CompressorHandle(value);

    public static implicit operator void*(CompressorHandle value) => value.Value;

    public static explicit operator CompressorHandle(Handle value) => new CompressorHandle(value);

    public static implicit operator Handle(CompressorHandle value) => new Handle(value.Value);

    public static explicit operator CompressorHandle(byte value) =>
        new CompressorHandle(unchecked((void*)(value)));

    public static explicit operator byte(CompressorHandle value) => (byte)(value.Value);

    public static explicit operator CompressorHandle(short value) =>
        new CompressorHandle(unchecked((void*)(value)));

    public static explicit operator short(CompressorHandle value) => (short)(value.Value);

    public static explicit operator CompressorHandle(int value) =>
        new CompressorHandle(unchecked((void*)(value)));

    public static explicit operator int(CompressorHandle value) => (int)(value.Value);

    public static explicit operator CompressorHandle(long value) =>
        new CompressorHandle(unchecked((void*)(value)));

    public static explicit operator long(CompressorHandle value) => (long)(value.Value);

    public static explicit operator CompressorHandle(nint value) =>
        new CompressorHandle(unchecked((void*)(value)));

    public static implicit operator nint(CompressorHandle value) => (nint)(value.Value);

    public static explicit operator CompressorHandle(sbyte value) =>
        new CompressorHandle(unchecked((void*)(value)));

    public static explicit operator sbyte(CompressorHandle value) => (sbyte)(value.Value);

    public static explicit operator CompressorHandle(ushort value) =>
        new CompressorHandle(unchecked((void*)(value)));

    public static explicit operator ushort(CompressorHandle value) => (ushort)(value.Value);

    public static explicit operator CompressorHandle(uint value) =>
        new CompressorHandle(unchecked((void*)(value)));

    public static explicit operator uint(CompressorHandle value) => (uint)(value.Value);

    public static explicit operator CompressorHandle(ulong value) =>
        new CompressorHandle(unchecked((void*)(value)));

    public static explicit operator ulong(CompressorHandle value) => (ulong)(value.Value);

    public static explicit operator CompressorHandle(nuint value) =>
        new CompressorHandle(unchecked((void*)(value)));

    public static implicit operator nuint(CompressorHandle value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is CompressorHandle other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of COMPRESSOR_HANDLE.");
    }

    public int CompareTo(CompressorHandle other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is CompressorHandle other) && Equals(other);

    public bool Equals(CompressorHandle other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
