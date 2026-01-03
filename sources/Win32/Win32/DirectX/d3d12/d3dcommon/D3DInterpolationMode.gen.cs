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

/// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE"]/*'/>
public enum D3DInterpolationMode
{
    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_UNDEFINED"]/*'/>

    Undefined = 0,

    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_CONSTANT"]/*'/>

    Constant = 1,

    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_LINEAR"]/*'/>

    Linear = 2,

    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_LINEAR_CENTROID"]/*'/>

    LinearCentroid = 3,

    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE"]/*'/>

    LinearNoperspective = 4,

    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_CENTROID"]/*'/>

    LinearNoperspectiveCentroid = 5,

    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_LINEAR_SAMPLE"]/*'/>

    LinearSample = 6,

    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_SAMPLE"]/*'/>

    LinearNoperspectiveSample = 7,
}
