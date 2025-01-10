// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PROFILEHEADER
{
    [NativeTypeName("DWORD")]
    public uint phSize;

    [NativeTypeName("DWORD")]
    public uint phCMMType;

    [NativeTypeName("DWORD")]
    public uint phVersion;

    [NativeTypeName("DWORD")]
    public uint phClass;

    [NativeTypeName("DWORD")]
    public uint phDataColorSpace;

    [NativeTypeName("DWORD")]
    public uint phConnectionSpace;

    [NativeTypeName("DWORD[3]")]
    public _phDateTime_e__FixedBuffer phDateTime;

    [NativeTypeName("DWORD")]
    public uint phSignature;

    [NativeTypeName("DWORD")]
    public uint phPlatform;

    [NativeTypeName("DWORD")]
    public uint phProfileFlags;

    [NativeTypeName("DWORD")]
    public uint phManufacturer;

    [NativeTypeName("DWORD")]
    public uint phModel;

    [NativeTypeName("DWORD[2]")]
    public _phAttributes_e__FixedBuffer phAttributes;

    [NativeTypeName("DWORD")]
    public uint phRenderingIntent;
    public CIEXYZ phIlluminant;

    [NativeTypeName("DWORD")]
    public uint phCreator;

    [NativeTypeName("BYTE[44]")]
    public _phReserved_e__FixedBuffer phReserved;

    [InlineArray(3)]
    public partial struct _phDateTime_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(2)]
    public partial struct _phAttributes_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(44)]
    public partial struct _phReserved_e__FixedBuffer
    {
        public byte e0;
    }
}
