// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TRUECOLORINFO
{
    [NativeTypeName("DWORD[3]")]
    public _dwBitMasks_e__FixedBuffer dwBitMasks;

    [NativeTypeName("RGBQUAD[256]")]
    public _bmiColors_e__FixedBuffer bmiColors;

    [InlineArray(3)]
    public partial struct _dwBitMasks_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(256)]
    public partial struct _bmiColors_e__FixedBuffer
    {
        public RGBQUAD e0;
    }
}
