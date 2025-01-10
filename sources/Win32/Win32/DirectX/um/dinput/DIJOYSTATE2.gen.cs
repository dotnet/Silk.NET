// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DIJOYSTATE2
{
    [NativeTypeName("LONG")]
    public int lX;

    [NativeTypeName("LONG")]
    public int lY;

    [NativeTypeName("LONG")]
    public int lZ;

    [NativeTypeName("LONG")]
    public int lRx;

    [NativeTypeName("LONG")]
    public int lRy;

    [NativeTypeName("LONG")]
    public int lRz;

    [NativeTypeName("LONG[2]")]
    public _rglSlider_e__FixedBuffer rglSlider;

    [NativeTypeName("DWORD[4]")]
    public _rgdwPOV_e__FixedBuffer rgdwPOV;

    [NativeTypeName("BYTE[128]")]
    public _rgbButtons_e__FixedBuffer rgbButtons;

    [NativeTypeName("LONG")]
    public int lVX;

    [NativeTypeName("LONG")]
    public int lVY;

    [NativeTypeName("LONG")]
    public int lVZ;

    [NativeTypeName("LONG")]
    public int lVRx;

    [NativeTypeName("LONG")]
    public int lVRy;

    [NativeTypeName("LONG")]
    public int lVRz;

    [NativeTypeName("LONG[2]")]
    public _rglVSlider_e__FixedBuffer rglVSlider;

    [NativeTypeName("LONG")]
    public int lAX;

    [NativeTypeName("LONG")]
    public int lAY;

    [NativeTypeName("LONG")]
    public int lAZ;

    [NativeTypeName("LONG")]
    public int lARx;

    [NativeTypeName("LONG")]
    public int lARy;

    [NativeTypeName("LONG")]
    public int lARz;

    [NativeTypeName("LONG[2]")]
    public _rglASlider_e__FixedBuffer rglASlider;

    [NativeTypeName("LONG")]
    public int lFX;

    [NativeTypeName("LONG")]
    public int lFY;

    [NativeTypeName("LONG")]
    public int lFZ;

    [NativeTypeName("LONG")]
    public int lFRx;

    [NativeTypeName("LONG")]
    public int lFRy;

    [NativeTypeName("LONG")]
    public int lFRz;

    [NativeTypeName("LONG[2]")]
    public _rglFSlider_e__FixedBuffer rglFSlider;

    [InlineArray(2)]
    public partial struct _rglSlider_e__FixedBuffer
    {
        public int e0;
    }

    [InlineArray(4)]
    public partial struct _rgdwPOV_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(128)]
    public partial struct _rgbButtons_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _rglVSlider_e__FixedBuffer
    {
        public int e0;
    }

    [InlineArray(2)]
    public partial struct _rglASlider_e__FixedBuffer
    {
        public int e0;
    }

    [InlineArray(2)]
    public partial struct _rglFSlider_e__FixedBuffer
    {
        public int e0;
    }
}
