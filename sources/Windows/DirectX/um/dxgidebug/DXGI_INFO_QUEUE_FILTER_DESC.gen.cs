// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER_DESC"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct DXGI_INFO_QUEUE_FILTER_DESC
{
    /// <include file='DXGI_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER_DESC.NumCategories"]/*'/>
    public uint NumCategories;
    /// <include file='DXGI_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER_DESC.pCategoryList"]/*'/>
    public DXGI_INFO_QUEUE_MESSAGE_CATEGORY* pCategoryList;
    /// <include file='DXGI_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER_DESC.NumSeverities"]/*'/>
    public uint NumSeverities;
    /// <include file='DXGI_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER_DESC.pSeverityList"]/*'/>
    public DXGI_INFO_QUEUE_MESSAGE_SEVERITY* pSeverityList;
    /// <include file='DXGI_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER_DESC.NumIDs"]/*'/>
    public uint NumIDs;
    /// <include file='DXGI_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER_DESC.pIDList"]/*'/>
    [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID *")]
    public int* pIDList;
}