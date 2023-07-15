// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_INFO_QUEUE_FILTER.xml' path='doc/member[@name="D3D12_INFO_QUEUE_FILTER"]/*'/>
public partial struct D3D12_INFO_QUEUE_FILTER
{
    /// <include file='D3D12_INFO_QUEUE_FILTER.xml' path='doc/member[@name="D3D12_INFO_QUEUE_FILTER.AllowList"]/*'/>
    public D3D12_INFO_QUEUE_FILTER_DESC AllowList;
    /// <include file='D3D12_INFO_QUEUE_FILTER.xml' path='doc/member[@name="D3D12_INFO_QUEUE_FILTER.DenyList"]/*'/>
    public D3D12_INFO_QUEUE_FILTER_DESC DenyList;
}