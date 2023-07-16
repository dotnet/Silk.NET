// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='DXGI_INFO_QUEUE_FILTER.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct DXGI_INFO_QUEUE_FILTER
{
    /// <include file='DXGI_INFO_QUEUE_FILTER.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER.AllowList"]/*'/>
    public DXGI_INFO_QUEUE_FILTER_DESC AllowList;
    /// <include file='DXGI_INFO_QUEUE_FILTER.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER.DenyList"]/*'/>
    public DXGI_INFO_QUEUE_FILTER_DESC DenyList;
}