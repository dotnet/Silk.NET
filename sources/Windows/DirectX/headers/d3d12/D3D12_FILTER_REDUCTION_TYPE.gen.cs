// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D12_FILTER_REDUCTION_TYPE"]/*'/>
public enum D3D12_FILTER_REDUCTION_TYPE
{
    /// <include file='D3D12_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D12_FILTER_REDUCTION_TYPE.D3D12_FILTER_REDUCTION_TYPE_STANDARD"]/*'/>
    D3D12_FILTER_REDUCTION_TYPE_STANDARD = 0,
    /// <include file='D3D12_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D12_FILTER_REDUCTION_TYPE.D3D12_FILTER_REDUCTION_TYPE_COMPARISON"]/*'/>
    D3D12_FILTER_REDUCTION_TYPE_COMPARISON = 1,
    /// <include file='D3D12_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D12_FILTER_REDUCTION_TYPE.D3D12_FILTER_REDUCTION_TYPE_MINIMUM"]/*'/>
    D3D12_FILTER_REDUCTION_TYPE_MINIMUM = 2,
    /// <include file='D3D12_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D12_FILTER_REDUCTION_TYPE.D3D12_FILTER_REDUCTION_TYPE_MAXIMUM"]/*'/>
    D3D12_FILTER_REDUCTION_TYPE_MAXIMUM = 3,
}