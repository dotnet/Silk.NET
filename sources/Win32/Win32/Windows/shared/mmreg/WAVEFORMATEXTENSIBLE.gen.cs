// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEFORMATEXTENSIBLE
{
    public WAVEFORMATEX Format;

    [NativeTypeName("__AnonymousRecord_mmreg_L2525_C5")]
    public _Samples_e__Union Samples;

    [NativeTypeName("DWORD")]
    public uint dwChannelMask;
    public Guid SubFormat;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public partial struct _Samples_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort wValidBitsPerSample;

        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort wSamplesPerBlock;

        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort wReserved;
    }
}
