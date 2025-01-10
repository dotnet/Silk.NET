// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct DISPATCHER_CONTEXT_NONVOLREG_ARM64
{
    [FieldOffset(0)]
    [NativeTypeName("BYTE[152]")]
    public _Buffer_e__FixedBuffer Buffer;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L7117_C5")]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public Span<ulong> GpNvRegs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.GpNvRegs; }
    }

    [UnscopedRef]
    public Span<double> FpNvRegs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.FpNvRegs; }
    }

    public partial struct _Anonymous_e__Struct
    {
        [NativeTypeName("DWORD64[11]")]
        public _GpNvRegs_e__FixedBuffer GpNvRegs;

        [NativeTypeName("double[8]")]
        public _FpNvRegs_e__FixedBuffer FpNvRegs;

        [InlineArray(11)]
        public partial struct _GpNvRegs_e__FixedBuffer
        {
            public ulong e0;
        }

        [InlineArray(8)]
        public partial struct _FpNvRegs_e__FixedBuffer
        {
            public double e0;
        }
    }

    [InlineArray(152)]
    public partial struct _Buffer_e__FixedBuffer
    {
        public byte e0;
    }
}
