// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public partial struct ColorLUTParams
{
    [NativeTypeName("Gdiplus::ColorChannelLUT")]
    public _lutB_e__FixedBuffer lutB;

    [NativeTypeName("Gdiplus::ColorChannelLUT")]
    public _lutG_e__FixedBuffer lutG;

    [NativeTypeName("Gdiplus::ColorChannelLUT")]
    public _lutR_e__FixedBuffer lutR;

    [NativeTypeName("Gdiplus::ColorChannelLUT")]
    public _lutA_e__FixedBuffer lutA;

    [InlineArray(256)]
    public partial struct _lutB_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(256)]
    public partial struct _lutG_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(256)]
    public partial struct _lutR_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(256)]
    public partial struct _lutA_e__FixedBuffer
    {
        public byte e0;
    }
}
