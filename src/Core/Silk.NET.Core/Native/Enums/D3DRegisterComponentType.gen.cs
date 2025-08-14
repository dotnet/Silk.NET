// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_REGISTER_COMPONENT_TYPE")]
    public enum D3DRegisterComponentType : int
    {
        [NativeName("Name", "D3D_REGISTER_COMPONENT_UNKNOWN")]
        D3DRegisterComponentUnknown = 0x0,
        [NativeName("Name", "D3D_REGISTER_COMPONENT_UINT32")]
        D3DRegisterComponentUint32 = 0x1,
        [NativeName("Name", "D3D_REGISTER_COMPONENT_SINT32")]
        D3DRegisterComponentSint32 = 0x2,
        [NativeName("Name", "D3D_REGISTER_COMPONENT_FLOAT32")]
        D3DRegisterComponentFloat32 = 0x3,
        [NativeName("Name", "D3D_REGISTER_COMPONENT_UINT16")]
        D3DRegisterComponentUint16 = 0x4,
        [NativeName("Name", "D3D_REGISTER_COMPONENT_SINT16")]
        D3DRegisterComponentSint16 = 0x5,
        [NativeName("Name", "D3D_REGISTER_COMPONENT_FLOAT16")]
        D3DRegisterComponentFloat16 = 0x6,
        [NativeName("Name", "D3D_REGISTER_COMPONENT_UINT64")]
        D3DRegisterComponentUint64 = 0x7,
        [NativeName("Name", "D3D_REGISTER_COMPONENT_SINT64")]
        D3DRegisterComponentSint64 = 0x8,
        [NativeName("Name", "D3D_REGISTER_COMPONENT_FLOAT64")]
        D3DRegisterComponentFloat64 = 0x9,
        [NativeName("Name", "D3D10_REGISTER_COMPONENT_UNKNOWN")]
        D3D10RegisterComponentUnknown = 0x0,
        [NativeName("Name", "D3D10_REGISTER_COMPONENT_UINT32")]
        D3D10RegisterComponentUint32 = 0x1,
        [NativeName("Name", "D3D10_REGISTER_COMPONENT_SINT32")]
        D3D10RegisterComponentSint32 = 0x2,
        [NativeName("Name", "D3D10_REGISTER_COMPONENT_FLOAT32")]
        D3D10RegisterComponentFloat32 = 0x3,
        [NativeName("Name", "D3D10_REGISTER_COMPONENT_UINT16")]
        D3D10RegisterComponentUint16 = 0x4,
        [NativeName("Name", "D3D10_REGISTER_COMPONENT_SINT16")]
        D3D10RegisterComponentSint16 = 0x5,
        [NativeName("Name", "D3D10_REGISTER_COMPONENT_FLOAT16")]
        D3D10RegisterComponentFloat16 = 0x6,
        [NativeName("Name", "D3D10_REGISTER_COMPONENT_UINT64")]
        D3D10RegisterComponentUint64 = 0x7,
        [NativeName("Name", "D3D10_REGISTER_COMPONENT_SINT64")]
        D3D10RegisterComponentSint64 = 0x8,
        [NativeName("Name", "D3D10_REGISTER_COMPONENT_FLOAT64")]
        D3D10RegisterComponentFloat64 = 0x9,
    }
}
