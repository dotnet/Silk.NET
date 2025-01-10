// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D11_SHADER_INPUT_BIND_DESC
{
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;
    public D3D_SHADER_INPUT_TYPE Type;
    public uint BindPoint;
    public uint BindCount;
    public uint uFlags;
    public D3D_RESOURCE_RETURN_TYPE ReturnType;
    public D3D_SRV_DIMENSION Dimension;
    public uint NumSamples;
}
