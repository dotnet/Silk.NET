// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DXGI_OFFER_RESOURCE_PRIORITY.xml' path='doc/member[@name="DXGI_OFFER_RESOURCE_PRIORITY"]/*'/>
public enum DXGI_OFFER_RESOURCE_PRIORITY
{
    /// <include file='DXGI_OFFER_RESOURCE_PRIORITY.xml' path='doc/member[@name="DXGI_OFFER_RESOURCE_PRIORITY.DXGI_OFFER_RESOURCE_PRIORITY_LOW"]/*'/>
    DXGI_OFFER_RESOURCE_PRIORITY_LOW = 1,
    /// <include file='DXGI_OFFER_RESOURCE_PRIORITY.xml' path='doc/member[@name="DXGI_OFFER_RESOURCE_PRIORITY.DXGI_OFFER_RESOURCE_PRIORITY_NORMAL"]/*'/>
    DXGI_OFFER_RESOURCE_PRIORITY_NORMAL = (DXGI_OFFER_RESOURCE_PRIORITY_LOW + 1),
    /// <include file='DXGI_OFFER_RESOURCE_PRIORITY.xml' path='doc/member[@name="DXGI_OFFER_RESOURCE_PRIORITY.DXGI_OFFER_RESOURCE_PRIORITY_HIGH"]/*'/>
    DXGI_OFFER_RESOURCE_PRIORITY_HIGH = (DXGI_OFFER_RESOURCE_PRIORITY_NORMAL + 1),
}