// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct XSAVE_FORMAT
{
    [NativeTypeName("WORD")]
    public ushort ControlWord;

    [NativeTypeName("WORD")]
    public ushort StatusWord;
    public byte TagWord;
    public byte Reserved1;

    [NativeTypeName("WORD")]
    public ushort ErrorOpcode;

    [NativeTypeName("DWORD")]
    public uint ErrorOffset;

    [NativeTypeName("WORD")]
    public ushort ErrorSelector;

    [NativeTypeName("WORD")]
    public ushort Reserved2;

    [NativeTypeName("DWORD")]
    public uint DataOffset;

    [NativeTypeName("WORD")]
    public ushort DataSelector;

    [NativeTypeName("WORD")]
    public ushort Reserved3;

    [NativeTypeName("DWORD")]
    public uint MxCsr;

    [NativeTypeName("DWORD")]
    public uint MxCsr_Mask;

    [NativeTypeName("M128A[8]")]
    public _FloatRegisters_e__FixedBuffer FloatRegisters;

    [NativeTypeName("M128A[16]")]
    public _XmmRegisters_e__FixedBuffer XmmRegisters;

    [NativeTypeName("BYTE[96]")]
    public _Reserved4_e__FixedBuffer Reserved4;

    [InlineArray(8)]
    public partial struct _FloatRegisters_e__FixedBuffer
    {
        public M128A e0;
    }

    [InlineArray(16)]
    public partial struct _XmmRegisters_e__FixedBuffer
    {
        public M128A e0;
    }

    [InlineArray(96)]
    public partial struct _Reserved4_e__FixedBuffer
    {
        public byte e0;
    }
}
