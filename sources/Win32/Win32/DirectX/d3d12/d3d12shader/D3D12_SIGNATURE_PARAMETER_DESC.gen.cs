// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_SIGNATURE_PARAMETER_DESC
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
