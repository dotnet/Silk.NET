// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DXGI_HDR_METADATA_HDR10
{
    [NativeTypeName("UINT16[2]")]
    public _RedPrimary_e__FixedBuffer RedPrimary;

    [NativeTypeName("UINT16[2]")]
    public _GreenPrimary_e__FixedBuffer GreenPrimary;

    [NativeTypeName("UINT16[2]")]
    public _BluePrimary_e__FixedBuffer BluePrimary;

    [NativeTypeName("UINT16[2]")]
    public _WhitePoint_e__FixedBuffer WhitePoint;
    public uint MaxMasteringLuminance;
    public uint MinMasteringLuminance;

    [NativeTypeName("UINT16")]
    public ushort MaxContentLightLevel;

    [NativeTypeName("UINT16")]
    public ushort MaxFrameAverageLightLevel;

    [InlineArray(2)]
    public partial struct _RedPrimary_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(2)]
    public partial struct _GreenPrimary_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(2)]
    public partial struct _BluePrimary_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(2)]
    public partial struct _WhitePoint_e__FixedBuffer
    {
        public ushort e0;
    }
}
