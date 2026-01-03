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

/// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION"]/*'/>
public enum D3DFormatComponentInterpretation
{
    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_TYPELESS"]/*'/>

    Typeless = 0,

    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_FLOAT"]/*'/>

    Float = -4,

    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_SNORM"]/*'/>

    Snorm = -3,

    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_UNORM"]/*'/>

    Unorm = -2,

    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_SINT"]/*'/>

    Sint = -1,

    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_UINT"]/*'/>

    Uint = 1,

    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_UNORM_SRGB"]/*'/>

    UnormSrgb = 2,

    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_BIASED_FIXED_2_8"]/*'/>

    BiasedFixed2X8 = 3,
}
