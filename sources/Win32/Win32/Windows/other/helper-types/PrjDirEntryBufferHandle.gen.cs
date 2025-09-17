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

public readonly unsafe partial struct PrjDirEntryBufferHandle
    : IComparable,
        IComparable<PrjDirEntryBufferHandle>,
        IEquatable<PrjDirEntryBufferHandle>,
        IFormattable
{
    public readonly void* Value;

    public PrjDirEntryBufferHandle(void* value)
    {
        Value = value;
    }

    public static PrjDirEntryBufferHandle INVALID_VALUE => new PrjDirEntryBufferHandle((void*)(-1));
    public static PrjDirEntryBufferHandle NULL => new PrjDirEntryBufferHandle(null);

    public static bool operator ==(PrjDirEntryBufferHandle left, PrjDirEntryBufferHandle right) =>
        left.Value == right.Value;

    public static bool operator !=(PrjDirEntryBufferHandle left, PrjDirEntryBufferHandle right) =>
        left.Value != right.Value;

    public static bool operator <(PrjDirEntryBufferHandle left, PrjDirEntryBufferHandle right) =>
        left.Value < right.Value;

    public static bool operator <=(PrjDirEntryBufferHandle left, PrjDirEntryBufferHandle right) =>
        left.Value <= right.Value;

    public static bool operator >(PrjDirEntryBufferHandle left, PrjDirEntryBufferHandle right) =>
        left.Value > right.Value;

    public static bool operator >=(PrjDirEntryBufferHandle left, PrjDirEntryBufferHandle right) =>
        left.Value >= right.Value;

    public static explicit operator PrjDirEntryBufferHandle(void* value) =>
        new PrjDirEntryBufferHandle(value);

    public static implicit operator void*(PrjDirEntryBufferHandle value) => value.Value;

    public static explicit operator PrjDirEntryBufferHandle(Handle value) =>
        new PrjDirEntryBufferHandle(value);

    public static implicit operator Handle(PrjDirEntryBufferHandle value) =>
        new Handle(value.Value);

    public static explicit operator PrjDirEntryBufferHandle(byte value) =>
        new PrjDirEntryBufferHandle(unchecked((void*)(value)));

    public static explicit operator byte(PrjDirEntryBufferHandle value) => (byte)(value.Value);

    public static explicit operator PrjDirEntryBufferHandle(short value) =>
        new PrjDirEntryBufferHandle(unchecked((void*)(value)));

    public static explicit operator short(PrjDirEntryBufferHandle value) => (short)(value.Value);

    public static explicit operator PrjDirEntryBufferHandle(int value) =>
        new PrjDirEntryBufferHandle(unchecked((void*)(value)));

    public static explicit operator int(PrjDirEntryBufferHandle value) => (int)(value.Value);

    public static explicit operator PrjDirEntryBufferHandle(long value) =>
        new PrjDirEntryBufferHandle(unchecked((void*)(value)));

    public static explicit operator long(PrjDirEntryBufferHandle value) => (long)(value.Value);

    public static explicit operator PrjDirEntryBufferHandle(nint value) =>
        new PrjDirEntryBufferHandle(unchecked((void*)(value)));

    public static implicit operator nint(PrjDirEntryBufferHandle value) => (nint)(value.Value);

    public static explicit operator PrjDirEntryBufferHandle(sbyte value) =>
        new PrjDirEntryBufferHandle(unchecked((void*)(value)));

    public static explicit operator sbyte(PrjDirEntryBufferHandle value) => (sbyte)(value.Value);

    public static explicit operator PrjDirEntryBufferHandle(ushort value) =>
        new PrjDirEntryBufferHandle(unchecked((void*)(value)));

    public static explicit operator ushort(PrjDirEntryBufferHandle value) => (ushort)(value.Value);

    public static explicit operator PrjDirEntryBufferHandle(uint value) =>
        new PrjDirEntryBufferHandle(unchecked((void*)(value)));

    public static explicit operator uint(PrjDirEntryBufferHandle value) => (uint)(value.Value);

    public static explicit operator PrjDirEntryBufferHandle(ulong value) =>
        new PrjDirEntryBufferHandle(unchecked((void*)(value)));

    public static explicit operator ulong(PrjDirEntryBufferHandle value) => (ulong)(value.Value);

    public static explicit operator PrjDirEntryBufferHandle(nuint value) =>
        new PrjDirEntryBufferHandle(unchecked((void*)(value)));

    public static implicit operator nuint(PrjDirEntryBufferHandle value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PrjDirEntryBufferHandle other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PRJ_DIR_ENTRY_BUFFER_HANDLE.");
    }

    public int CompareTo(PrjDirEntryBufferHandle other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is PrjDirEntryBufferHandle other) && Equals(other);

    public bool Equals(PrjDirEntryBufferHandle other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
