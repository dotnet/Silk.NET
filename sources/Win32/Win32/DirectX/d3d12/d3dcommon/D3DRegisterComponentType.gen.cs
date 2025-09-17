// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE"]/*'/>
public enum D3DRegisterComponentType
{
    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_UNKNOWN"]/*'/>

    DRegisterComponentUnknown = 0,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_UINT32"]/*'/>

    DRegisterComponentUint32 = 1,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_SINT32"]/*'/>

    DRegisterComponentSint32 = 2,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_FLOAT32"]/*'/>

    DRegisterComponentFloat32 = 3,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_UINT16"]/*'/>

    DRegisterComponentUint16 = 4,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_SINT16"]/*'/>

    DRegisterComponentSint16 = 5,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_FLOAT16"]/*'/>

    DRegisterComponentFloat16 = 6,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_UINT64"]/*'/>

    DRegisterComponentUint64 = 7,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_SINT64"]/*'/>

    DRegisterComponentSint64 = 8,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_FLOAT64"]/*'/>

    DRegisterComponentFloat64 = 9,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_UNKNOWN"]/*'/>

    D10RegisterComponentUnknown = DRegisterComponentUnknown,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_UINT32"]/*'/>

    D10RegisterComponentUint32 = DRegisterComponentUint32,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_SINT32"]/*'/>

    D10RegisterComponentSint32 = DRegisterComponentSint32,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_FLOAT32"]/*'/>

    D10RegisterComponentFloat32 = DRegisterComponentFloat32,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_UINT16"]/*'/>

    D10RegisterComponentUint16 = DRegisterComponentUint16,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_SINT16"]/*'/>

    D10RegisterComponentSint16 = DRegisterComponentSint16,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_FLOAT16"]/*'/>

    D10RegisterComponentFloat16 = DRegisterComponentFloat16,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_UINT64"]/*'/>

    D10RegisterComponentUint64 = DRegisterComponentUint64,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_SINT64"]/*'/>

    D10RegisterComponentSint64 = DRegisterComponentSint64,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_FLOAT64"]/*'/>

    D10RegisterComponentFloat64 = DRegisterComponentFloat64,
}
