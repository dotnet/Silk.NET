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

public readonly unsafe partial struct PrjNamespaceVirtualizationContext
    : IComparable,
        IComparable<PrjNamespaceVirtualizationContext>,
        IEquatable<PrjNamespaceVirtualizationContext>,
        IFormattable
{
    public readonly void* Value;

    public PrjNamespaceVirtualizationContext(void* value)
    {
        Value = value;
    }

    public static PrjNamespaceVirtualizationContext INVALID_VALUE =>
        new PrjNamespaceVirtualizationContext((void*)(-1));
    public static PrjNamespaceVirtualizationContext NULL =>
        new PrjNamespaceVirtualizationContext(null);

    public static bool operator ==(
        PrjNamespaceVirtualizationContext left,
        PrjNamespaceVirtualizationContext right
    ) => left.Value == right.Value;

    public static bool operator !=(
        PrjNamespaceVirtualizationContext left,
        PrjNamespaceVirtualizationContext right
    ) => left.Value != right.Value;

    public static bool operator <(
        PrjNamespaceVirtualizationContext left,
        PrjNamespaceVirtualizationContext right
    ) => left.Value < right.Value;

    public static bool operator <=(
        PrjNamespaceVirtualizationContext left,
        PrjNamespaceVirtualizationContext right
    ) => left.Value <= right.Value;

    public static bool operator >(
        PrjNamespaceVirtualizationContext left,
        PrjNamespaceVirtualizationContext right
    ) => left.Value > right.Value;

    public static bool operator >=(
        PrjNamespaceVirtualizationContext left,
        PrjNamespaceVirtualizationContext right
    ) => left.Value >= right.Value;

    public static explicit operator PrjNamespaceVirtualizationContext(void* value) =>
        new PrjNamespaceVirtualizationContext(value);

    public static implicit operator void*(PrjNamespaceVirtualizationContext value) => value.Value;

    public static explicit operator PrjNamespaceVirtualizationContext(Handle value) =>
        new PrjNamespaceVirtualizationContext(value);

    public static implicit operator Handle(PrjNamespaceVirtualizationContext value) =>
        new Handle(value.Value);

    public static explicit operator PrjNamespaceVirtualizationContext(byte value) =>
        new PrjNamespaceVirtualizationContext(unchecked((void*)(value)));

    public static explicit operator byte(PrjNamespaceVirtualizationContext value) =>
        (byte)(value.Value);

    public static explicit operator PrjNamespaceVirtualizationContext(short value) =>
        new PrjNamespaceVirtualizationContext(unchecked((void*)(value)));

    public static explicit operator short(PrjNamespaceVirtualizationContext value) =>
        (short)(value.Value);

    public static explicit operator PrjNamespaceVirtualizationContext(int value) =>
        new PrjNamespaceVirtualizationContext(unchecked((void*)(value)));

    public static explicit operator int(PrjNamespaceVirtualizationContext value) =>
        (int)(value.Value);

    public static explicit operator PrjNamespaceVirtualizationContext(long value) =>
        new PrjNamespaceVirtualizationContext(unchecked((void*)(value)));

    public static explicit operator long(PrjNamespaceVirtualizationContext value) =>
        (long)(value.Value);

    public static explicit operator PrjNamespaceVirtualizationContext(nint value) =>
        new PrjNamespaceVirtualizationContext(unchecked((void*)(value)));

    public static implicit operator nint(PrjNamespaceVirtualizationContext value) =>
        (nint)(value.Value);

    public static explicit operator PrjNamespaceVirtualizationContext(sbyte value) =>
        new PrjNamespaceVirtualizationContext(unchecked((void*)(value)));

    public static explicit operator sbyte(PrjNamespaceVirtualizationContext value) =>
        (sbyte)(value.Value);

    public static explicit operator PrjNamespaceVirtualizationContext(ushort value) =>
        new PrjNamespaceVirtualizationContext(unchecked((void*)(value)));

    public static explicit operator ushort(PrjNamespaceVirtualizationContext value) =>
        (ushort)(value.Value);

    public static explicit operator PrjNamespaceVirtualizationContext(uint value) =>
        new PrjNamespaceVirtualizationContext(unchecked((void*)(value)));

    public static explicit operator uint(PrjNamespaceVirtualizationContext value) =>
        (uint)(value.Value);

    public static explicit operator PrjNamespaceVirtualizationContext(ulong value) =>
        new PrjNamespaceVirtualizationContext(unchecked((void*)(value)));

    public static explicit operator ulong(PrjNamespaceVirtualizationContext value) =>
        (ulong)(value.Value);

    public static explicit operator PrjNamespaceVirtualizationContext(nuint value) =>
        new PrjNamespaceVirtualizationContext(unchecked((void*)(value)));

    public static implicit operator nuint(PrjNamespaceVirtualizationContext value) =>
        (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PrjNamespaceVirtualizationContext other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException(
                "obj is not an instance of PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT."
            );
    }

    public int CompareTo(PrjNamespaceVirtualizationContext other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is PrjNamespaceVirtualizationContext other) && Equals(other);

    public bool Equals(PrjNamespaceVirtualizationContext other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
