// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct ENUMTYPEW
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwVersion;

    [NativeTypeName("DWORD")]
    public uint dwFields;

    [NativeTypeName("PCWSTR")]
    public ushort* pDeviceName;

    [NativeTypeName("DWORD")]
    public uint dwMediaType;

    [NativeTypeName("DWORD")]
    public uint dwDitheringMode;

    [NativeTypeName("DWORD[2]")]
    public _dwResolution_e__FixedBuffer dwResolution;

    [NativeTypeName("DWORD")]
    public uint dwCMMType;

    [NativeTypeName("DWORD")]
    public uint dwClass;

    [NativeTypeName("DWORD")]
    public uint dwDataColorSpace;

    [NativeTypeName("DWORD")]
    public uint dwConnectionSpace;

    [NativeTypeName("DWORD")]
    public uint dwSignature;

    [NativeTypeName("DWORD")]
    public uint dwPlatform;

    [NativeTypeName("DWORD")]
    public uint dwProfileFlags;

    [NativeTypeName("DWORD")]
    public uint dwManufacturer;

    [NativeTypeName("DWORD")]
    public uint dwModel;

    [NativeTypeName("DWORD[2]")]
    public _dwAttributes_e__FixedBuffer dwAttributes;

    [NativeTypeName("DWORD")]
    public uint dwRenderingIntent;

    [NativeTypeName("DWORD")]
    public uint dwCreator;

    [NativeTypeName("DWORD")]
    public uint dwDeviceClass;

    [InlineArray(2)]
    public partial struct _dwResolution_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(2)]
    public partial struct _dwAttributes_e__FixedBuffer
    {
        public uint e0;
    }
}
