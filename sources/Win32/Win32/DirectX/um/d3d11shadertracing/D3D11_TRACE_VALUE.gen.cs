// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_TRACE_VALUE
{
    [NativeTypeName("UINT[4]")]
    public _Bits_e__FixedBuffer Bits;

    [NativeTypeName("D3D11_TRACE_COMPONENT_MASK")]
    public byte ValidMask;

    [InlineArray(4)]
    public partial struct _Bits_e__FixedBuffer
    {
        public uint e0;
    }
}
