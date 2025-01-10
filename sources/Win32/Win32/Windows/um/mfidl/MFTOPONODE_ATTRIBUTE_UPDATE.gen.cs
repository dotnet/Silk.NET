// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MFTOPONODE_ATTRIBUTE_UPDATE
{
    [NativeTypeName("TOPOID")]
    public ulong NodeId;
    public Guid guidAttributeKey;
    public MF_ATTRIBUTE_TYPE attrType;

    [NativeTypeName("__AnonymousRecord_mfidl_L11509_C36")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref uint u32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.u32; }
    }

    [UnscopedRef]
    public ref ulong u64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.u64; }
    }

    [UnscopedRef]
    public ref double d
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.d; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint u32;

        [FieldOffset(0)]
        [NativeTypeName("UINT64")]
        public ulong u64;

        [FieldOffset(0)]
        public double d;
    }
}
