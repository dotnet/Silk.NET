// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D11_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER_DESC"]/*'/>
public unsafe partial struct D3D11_INFO_QUEUE_FILTER_DESC
{
    /// <include file='D3D11_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER_DESC.NumCategories"]/*'/>
    public uint NumCategories;
    /// <include file='D3D11_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER_DESC.pCategoryList"]/*'/>
    public D3D11_MESSAGE_CATEGORY* pCategoryList;
    /// <include file='D3D11_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER_DESC.NumSeverities"]/*'/>
    public uint NumSeverities;
    /// <include file='D3D11_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER_DESC.pSeverityList"]/*'/>
    public D3D11_MESSAGE_SEVERITY* pSeverityList;
    /// <include file='D3D11_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER_DESC.NumIDs"]/*'/>
    public uint NumIDs;
    /// <include file='D3D11_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="D3D11_INFO_QUEUE_FILTER_DESC.pIDList"]/*'/>
    public D3D11_MESSAGE_ID* pIDList;
}