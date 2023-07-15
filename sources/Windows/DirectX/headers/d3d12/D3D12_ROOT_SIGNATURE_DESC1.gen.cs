// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_ROOT_SIGNATURE_DESC1.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC1"]/*'/>
public unsafe partial struct D3D12_ROOT_SIGNATURE_DESC1
{
    /// <include file='D3D12_ROOT_SIGNATURE_DESC1.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC1.NumParameters"]/*'/>
    public uint NumParameters;
    /// <include file='D3D12_ROOT_SIGNATURE_DESC1.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC1.pParameters"]/*'/>
    [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")]
    public D3D12_ROOT_PARAMETER1* pParameters;
    /// <include file='D3D12_ROOT_SIGNATURE_DESC1.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC1.NumStaticSamplers"]/*'/>
    public uint NumStaticSamplers;
    /// <include file='D3D12_ROOT_SIGNATURE_DESC1.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC1.pStaticSamplers"]/*'/>
    [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
    public D3D12_STATIC_SAMPLER_DESC* pStaticSamplers;
    /// <include file='D3D12_ROOT_SIGNATURE_DESC1.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC1.Flags"]/*'/>
    public D3D12_ROOT_SIGNATURE_FLAGS Flags;
}