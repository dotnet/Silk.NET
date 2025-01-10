// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct AM_DVDCOPY_TITLEKEY
{
    [NativeTypeName("ULONG")]
    public uint KeyFlags;

    [NativeTypeName("ULONG[2]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    [NativeTypeName("UCHAR[6]")]
    public _TitleKey_e__FixedBuffer TitleKey;

    [NativeTypeName("UCHAR[2]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    [InlineArray(2)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(6)]
    public partial struct _TitleKey_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _Reserved2_e__FixedBuffer
    {
        public byte e0;
    }
}
