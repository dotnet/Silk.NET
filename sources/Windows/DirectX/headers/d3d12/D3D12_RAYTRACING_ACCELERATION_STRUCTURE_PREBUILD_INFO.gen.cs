// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO"]/*'/>
public partial struct D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO
{
    /// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO.ResultDataMaxSizeInBytes"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong ResultDataMaxSizeInBytes;
    /// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO.ScratchDataSizeInBytes"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong ScratchDataSizeInBytes;
    /// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO.UpdateScratchDataSizeInBytes"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong UpdateScratchDataSizeInBytes;
}