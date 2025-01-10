// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct LOGCOLORSPACEW
{
    [NativeTypeName("DWORD")]
    public uint lcsSignature;

    [NativeTypeName("DWORD")]
    public uint lcsVersion;

    [NativeTypeName("DWORD")]
    public uint lcsSize;

    [NativeTypeName("LCSCSTYPE")]
    public int lcsCSType;

    [NativeTypeName("LCSGAMUTMATCH")]
    public int lcsIntent;
    public CIEXYZTRIPLE lcsEndpoints;

    [NativeTypeName("DWORD")]
    public uint lcsGammaRed;

    [NativeTypeName("DWORD")]
    public uint lcsGammaGreen;

    [NativeTypeName("DWORD")]
    public uint lcsGammaBlue;

    [NativeTypeName("WCHAR[260]")]
    public _lcsFilename_e__FixedBuffer lcsFilename;

    [InlineArray(260)]
    public partial struct _lcsFilename_e__FixedBuffer
    {
        public ushort e0;
    }
}
