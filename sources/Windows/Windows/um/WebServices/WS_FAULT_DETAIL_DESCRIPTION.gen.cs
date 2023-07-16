// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_FAULT_DETAIL_DESCRIPTION.xml' path='doc/member[@name="WS_FAULT_DETAIL_DESCRIPTION"]/*'/>
public unsafe partial struct WS_FAULT_DETAIL_DESCRIPTION
{
    /// <include file='WS_FAULT_DETAIL_DESCRIPTION.xml' path='doc/member[@name="WS_FAULT_DETAIL_DESCRIPTION.action"]/*'/>
    public WS_XML_STRING* action;
    /// <include file='WS_FAULT_DETAIL_DESCRIPTION.xml' path='doc/member[@name="WS_FAULT_DETAIL_DESCRIPTION.detailElementDescription"]/*'/>
    public WS_ELEMENT_DESCRIPTION* detailElementDescription;
}