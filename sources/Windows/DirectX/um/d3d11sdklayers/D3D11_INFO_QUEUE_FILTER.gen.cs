// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_INFO_QUEUE_FILTER.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER"]/*'/>
public partial struct D3D11_INFO_QUEUE_FILTER
{
    /// <include file='D3D11_INFO_QUEUE_FILTER.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER.AllowList"]/*'/>
    public D3D11_INFO_QUEUE_FILTER_DESC AllowList;
    /// <include file='D3D11_INFO_QUEUE_FILTER.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER.DenyList"]/*'/>
    public D3D11_INFO_QUEUE_FILTER_DESC DenyList;
}