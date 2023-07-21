// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_TRACE_GS_INPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_TRACE_GS_INPUT_PRIMITIVE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum D3D11_TRACE_GS_INPUT_PRIMITIVE
{
    /// <include file='D3D11_TRACE_GS_INPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_TRACE_GS_INPUT_PRIMITIVE.D3D11_TRACE_GS_INPUT_PRIMITIVE_UNDEFINED"]/*' />
    D3D11_TRACE_GS_INPUT_PRIMITIVE_UNDEFINED = 0,

    /// <include file='D3D11_TRACE_GS_INPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_TRACE_GS_INPUT_PRIMITIVE.D3D11_TRACE_GS_INPUT_PRIMITIVE_POINT"]/*' />
    D3D11_TRACE_GS_INPUT_PRIMITIVE_POINT = 1,

    /// <include file='D3D11_TRACE_GS_INPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_TRACE_GS_INPUT_PRIMITIVE.D3D11_TRACE_GS_INPUT_PRIMITIVE_LINE"]/*' />
    D3D11_TRACE_GS_INPUT_PRIMITIVE_LINE = 2,

    /// <include file='D3D11_TRACE_GS_INPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_TRACE_GS_INPUT_PRIMITIVE.D3D11_TRACE_GS_INPUT_PRIMITIVE_TRIANGLE"]/*' />
    D3D11_TRACE_GS_INPUT_PRIMITIVE_TRIANGLE = 3,

    /// <include file='D3D11_TRACE_GS_INPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_TRACE_GS_INPUT_PRIMITIVE.D3D11_TRACE_GS_INPUT_PRIMITIVE_LINE_ADJ"]/*' />
    D3D11_TRACE_GS_INPUT_PRIMITIVE_LINE_ADJ = 6,

    /// <include file='D3D11_TRACE_GS_INPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_TRACE_GS_INPUT_PRIMITIVE.D3D11_TRACE_GS_INPUT_PRIMITIVE_TRIANGLE_ADJ"]/*' />
    D3D11_TRACE_GS_INPUT_PRIMITIVE_TRIANGLE_ADJ = 7,
}
