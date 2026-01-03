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

public readonly unsafe partial struct PackageInfoReference
    : IComparable,
        IComparable<PackageInfoReference>,
        IEquatable<PackageInfoReference>,
        IFormattable
{
    public readonly void* Value;

    public PackageInfoReference(void* value)
    {
        Value = value;
    }

    public static PackageInfoReference NULL => new PackageInfoReference(null);

    public static bool operator ==(PackageInfoReference left, PackageInfoReference right) =>
        left.Value == right.Value;

    public static bool operator !=(PackageInfoReference left, PackageInfoReference right) =>
        left.Value != right.Value;

    public static bool operator <(PackageInfoReference left, PackageInfoReference right) =>
        left.Value < right.Value;

    public static bool operator <=(PackageInfoReference left, PackageInfoReference right) =>
        left.Value <= right.Value;

    public static bool operator >(PackageInfoReference left, PackageInfoReference right) =>
        left.Value > right.Value;

    public static bool operator >=(PackageInfoReference left, PackageInfoReference right) =>
        left.Value >= right.Value;

    public static explicit operator PackageInfoReference(void* value) =>
        new PackageInfoReference(value);

    public static implicit operator void*(PackageInfoReference value) => value.Value;

    public static explicit operator PackageInfoReference(byte value) =>
        new PackageInfoReference(unchecked((void*)(value)));

    public static explicit operator byte(PackageInfoReference value) => (byte)(value.Value);

    public static explicit operator PackageInfoReference(short value) =>
        new PackageInfoReference(unchecked((void*)(value)));

    public static explicit operator short(PackageInfoReference value) => (short)(value.Value);

    public static explicit operator PackageInfoReference(int value) =>
        new PackageInfoReference(unchecked((void*)(value)));

    public static explicit operator int(PackageInfoReference value) => (int)(value.Value);

    public static explicit operator PackageInfoReference(long value) =>
        new PackageInfoReference(unchecked((void*)(value)));

    public static explicit operator long(PackageInfoReference value) => (long)(value.Value);

    public static explicit operator PackageInfoReference(nint value) =>
        new PackageInfoReference(unchecked((void*)(value)));

    public static implicit operator nint(PackageInfoReference value) => (nint)(value.Value);

    public static explicit operator PackageInfoReference(sbyte value) =>
        new PackageInfoReference(unchecked((void*)(value)));

    public static explicit operator sbyte(PackageInfoReference value) => (sbyte)(value.Value);

    public static explicit operator PackageInfoReference(ushort value) =>
        new PackageInfoReference(unchecked((void*)(value)));

    public static explicit operator ushort(PackageInfoReference value) => (ushort)(value.Value);

    public static explicit operator PackageInfoReference(uint value) =>
        new PackageInfoReference(unchecked((void*)(value)));

    public static explicit operator uint(PackageInfoReference value) => (uint)(value.Value);

    public static explicit operator PackageInfoReference(ulong value) =>
        new PackageInfoReference(unchecked((void*)(value)));

    public static explicit operator ulong(PackageInfoReference value) => (ulong)(value.Value);

    public static explicit operator PackageInfoReference(nuint value) =>
        new PackageInfoReference(unchecked((void*)(value)));

    public static implicit operator nuint(PackageInfoReference value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PackageInfoReference other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PACKAGE_INFO_REFERENCE.");
    }

    public int CompareTo(PackageInfoReference other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is PackageInfoReference other) && Equals(other);

    public bool Equals(PackageInfoReference other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
