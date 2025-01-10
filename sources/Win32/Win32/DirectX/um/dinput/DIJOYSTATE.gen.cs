// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DIJOYSTATE
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

    [NativeTypeName("BYTE[32]")]
    public _rgbButtons_e__FixedBuffer rgbButtons;

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

    [InlineArray(32)]
    public partial struct _rgbButtons_e__FixedBuffer
    {
        public byte e0;
    }
}
