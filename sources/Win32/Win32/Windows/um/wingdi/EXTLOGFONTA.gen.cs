// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct EXTLOGFONTA
{
    public LOGFONTA elfLogFont;

    [NativeTypeName("BYTE[64]")]
    public _elfFullName_e__FixedBuffer elfFullName;

    [NativeTypeName("BYTE[32]")]
    public _elfStyle_e__FixedBuffer elfStyle;

    [NativeTypeName("DWORD")]
    public uint elfVersion;

    [NativeTypeName("DWORD")]
    public uint elfStyleSize;

    [NativeTypeName("DWORD")]
    public uint elfMatch;

    [NativeTypeName("DWORD")]
    public uint elfReserved;

    [NativeTypeName("BYTE[4]")]
    public _elfVendorId_e__FixedBuffer elfVendorId;

    [NativeTypeName("DWORD")]
    public uint elfCulture;
    public PANOSE elfPanose;

    [InlineArray(64)]
    public partial struct _elfFullName_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(32)]
    public partial struct _elfStyle_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(4)]
    public partial struct _elfVendorId_e__FixedBuffer
    {
        public byte e0;
    }
}
