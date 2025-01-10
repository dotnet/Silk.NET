// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows6.2")]
public enum D3D11_TRACE_GS_INPUT_PRIMITIVE
{
    D3D11_TRACE_GS_INPUT_PRIMITIVE_UNDEFINED = 0,
    D3D11_TRACE_GS_INPUT_PRIMITIVE_POINT = 1,
    D3D11_TRACE_GS_INPUT_PRIMITIVE_LINE = 2,
    D3D11_TRACE_GS_INPUT_PRIMITIVE_TRIANGLE = 3,
    D3D11_TRACE_GS_INPUT_PRIMITIVE_LINE_ADJ = 6,
    D3D11_TRACE_GS_INPUT_PRIMITIVE_TRIANGLE_ADJ = 7,
}
