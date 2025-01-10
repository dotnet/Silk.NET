// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tvout.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct VIDEOPARAMETERS
{
    public Guid Guid;

    [NativeTypeName("ULONG")]
    public uint dwOffset;

    [NativeTypeName("ULONG")]
    public uint dwCommand;

    [NativeTypeName("ULONG")]
    public uint dwFlags;

    [NativeTypeName("ULONG")]
    public uint dwMode;

    [NativeTypeName("ULONG")]
    public uint dwTVStandard;

    [NativeTypeName("ULONG")]
    public uint dwAvailableModes;

    [NativeTypeName("ULONG")]
    public uint dwAvailableTVStandard;

    [NativeTypeName("ULONG")]
    public uint dwFlickerFilter;

    [NativeTypeName("ULONG")]
    public uint dwOverScanX;

    [NativeTypeName("ULONG")]
    public uint dwOverScanY;

    [NativeTypeName("ULONG")]
    public uint dwMaxUnscaledX;

    [NativeTypeName("ULONG")]
    public uint dwMaxUnscaledY;

    [NativeTypeName("ULONG")]
    public uint dwPositionX;

    [NativeTypeName("ULONG")]
    public uint dwPositionY;

    [NativeTypeName("ULONG")]
    public uint dwBrightness;

    [NativeTypeName("ULONG")]
    public uint dwContrast;

    [NativeTypeName("ULONG")]
    public uint dwCPType;

    [NativeTypeName("ULONG")]
    public uint dwCPCommand;

    [NativeTypeName("ULONG")]
    public uint dwCPStandard;

    [NativeTypeName("ULONG")]
    public uint dwCPKey;

    [NativeTypeName("ULONG")]
    public uint bCP_APSTriggerBits;

    [NativeTypeName("UCHAR[256]")]
    public _bOEMCopyProtection_e__FixedBuffer bOEMCopyProtection;

    [InlineArray(256)]
    public partial struct _bOEMCopyProtection_e__FixedBuffer
    {
        public byte e0;
    }
}
