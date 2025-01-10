// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DXGI_OUTPUT_DESC1
{
    [NativeTypeName("WCHAR[32]")]
    public _DeviceName_e__FixedBuffer DeviceName;
    public RECT DesktopCoordinates;
    public BOOL AttachedToDesktop;
    public DXGI_MODE_ROTATION Rotation;
    public HMONITOR Monitor;
    public uint BitsPerColor;
    public DXGI_COLOR_SPACE_TYPE ColorSpace;

    [NativeTypeName("FLOAT[2]")]
    public _RedPrimary_e__FixedBuffer RedPrimary;

    [NativeTypeName("FLOAT[2]")]
    public _GreenPrimary_e__FixedBuffer GreenPrimary;

    [NativeTypeName("FLOAT[2]")]
    public _BluePrimary_e__FixedBuffer BluePrimary;

    [NativeTypeName("FLOAT[2]")]
    public _WhitePoint_e__FixedBuffer WhitePoint;
    public float MinLuminance;
    public float MaxLuminance;
    public float MaxFullFrameLuminance;

    [InlineArray(32)]
    public partial struct _DeviceName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(2)]
    public partial struct _RedPrimary_e__FixedBuffer
    {
        public float e0;
    }

    [InlineArray(2)]
    public partial struct _GreenPrimary_e__FixedBuffer
    {
        public float e0;
    }

    [InlineArray(2)]
    public partial struct _BluePrimary_e__FixedBuffer
    {
        public float e0;
    }

    [InlineArray(2)]
    public partial struct _WhitePoint_e__FixedBuffer
    {
        public float e0;
    }
}
