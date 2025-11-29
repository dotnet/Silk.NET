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

public readonly unsafe partial struct PackagedependencyContext
    : IComparable,
        IComparable<PackagedependencyContext>,
        IEquatable<PackagedependencyContext>,
        IFormattable
{
    public readonly void* Value;

    public PackagedependencyContext(void* value)
    {
        Value = value;
    }

    public static PackagedependencyContext NULL => new PackagedependencyContext(null);

    public static bool operator ==(PackagedependencyContext left, PackagedependencyContext right) =>
        left.Value == right.Value;

    public static bool operator !=(PackagedependencyContext left, PackagedependencyContext right) =>
        left.Value != right.Value;

    public static bool operator <(PackagedependencyContext left, PackagedependencyContext right) =>
        left.Value < right.Value;

    public static bool operator <=(PackagedependencyContext left, PackagedependencyContext right) =>
        left.Value <= right.Value;

    public static bool operator >(PackagedependencyContext left, PackagedependencyContext right) =>
        left.Value > right.Value;

    public static bool operator >=(PackagedependencyContext left, PackagedependencyContext right) =>
        left.Value >= right.Value;

    public static explicit operator PackagedependencyContext(void* value) =>
        new PackagedependencyContext(value);

    public static implicit operator void*(PackagedependencyContext value) => value.Value;

    public static explicit operator PackagedependencyContext(byte value) =>
        new PackagedependencyContext(unchecked((void*)(value)));

    public static explicit operator byte(PackagedependencyContext value) => (byte)(value.Value);

    public static explicit operator PackagedependencyContext(short value) =>
        new PackagedependencyContext(unchecked((void*)(value)));

    public static explicit operator short(PackagedependencyContext value) => (short)(value.Value);

    public static explicit operator PackagedependencyContext(int value) =>
        new PackagedependencyContext(unchecked((void*)(value)));

    public static explicit operator int(PackagedependencyContext value) => (int)(value.Value);

    public static explicit operator PackagedependencyContext(long value) =>
        new PackagedependencyContext(unchecked((void*)(value)));

    public static explicit operator long(PackagedependencyContext value) => (long)(value.Value);

    public static explicit operator PackagedependencyContext(nint value) =>
        new PackagedependencyContext(unchecked((void*)(value)));

    public static implicit operator nint(PackagedependencyContext value) => (nint)(value.Value);

    public static explicit operator PackagedependencyContext(sbyte value) =>
        new PackagedependencyContext(unchecked((void*)(value)));

    public static explicit operator sbyte(PackagedependencyContext value) => (sbyte)(value.Value);

    public static explicit operator PackagedependencyContext(ushort value) =>
        new PackagedependencyContext(unchecked((void*)(value)));

    public static explicit operator ushort(PackagedependencyContext value) => (ushort)(value.Value);

    public static explicit operator PackagedependencyContext(uint value) =>
        new PackagedependencyContext(unchecked((void*)(value)));

    public static explicit operator uint(PackagedependencyContext value) => (uint)(value.Value);

    public static explicit operator PackagedependencyContext(ulong value) =>
        new PackagedependencyContext(unchecked((void*)(value)));

    public static explicit operator ulong(PackagedependencyContext value) => (ulong)(value.Value);

    public static explicit operator PackagedependencyContext(nuint value) =>
        new PackagedependencyContext(unchecked((void*)(value)));

    public static implicit operator nuint(PackagedependencyContext value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PackagedependencyContext other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PACKAGEDEPENDENCY_CONTEXT.");
    }

    public int CompareTo(PackagedependencyContext other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is PackagedependencyContext other) && Equals(other);

    public bool Equals(PackagedependencyContext other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
