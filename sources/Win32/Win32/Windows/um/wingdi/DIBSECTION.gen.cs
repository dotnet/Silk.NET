// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DIBSECTION
{
    public BITMAP dsBm;
    public BITMAPINFOHEADER dsBmih;

    [NativeTypeName("DWORD[3]")]
    public _dsBitfields_e__FixedBuffer dsBitfields;
    public HANDLE dshSection;

    [NativeTypeName("DWORD")]
    public uint dsOffset;

    [InlineArray(3)]
    public partial struct _dsBitfields_e__FixedBuffer
    {
        public uint e0;
    }
}
