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

/// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE"]/*'/>
public enum D3DTessellatorOutputPrimitive
{
    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_UNDEFINED"]/*'/>

    DTessellatorOutputUndefined = 0,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_POINT"]/*'/>

    DTessellatorOutputPoint = 1,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_LINE"]/*'/>

    DTessellatorOutputLine = 2,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_TRIANGLE_CW"]/*'/>

    DTessellatorOutputTriangleCw = 3,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_TRIANGLE_CCW"]/*'/>

    DTessellatorOutputTriangleCcw = 4,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_UNDEFINED"]/*'/>

    D11TessellatorOutputUndefined = DTessellatorOutputUndefined,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_POINT"]/*'/>

    D11TessellatorOutputPoint = DTessellatorOutputPoint,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_LINE"]/*'/>

    D11TessellatorOutputLine = DTessellatorOutputLine,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CW"]/*'/>

    D11TessellatorOutputTriangleCw = DTessellatorOutputTriangleCw,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CCW"]/*'/>

    D11TessellatorOutputTriangleCcw = DTessellatorOutputTriangleCcw,
}
