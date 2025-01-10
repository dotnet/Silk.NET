// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D11_SIGNATURE_PARAMETER_DESC
{
    [NativeTypeName("LPCSTR")]
    public sbyte* SemanticName;
    public uint SemanticIndex;
    public uint Register;
    public D3D_NAME SystemValueType;
    public D3D_REGISTER_COMPONENT_TYPE ComponentType;
    public byte Mask;
    public byte ReadWriteMask;
    public uint Stream;
    public D3D_MIN_PRECISION MinPrecision;
}
