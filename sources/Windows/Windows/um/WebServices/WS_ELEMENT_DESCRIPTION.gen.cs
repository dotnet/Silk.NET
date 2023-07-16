// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_ELEMENT_DESCRIPTION.xml' path='doc/member[@name="WS_ELEMENT_DESCRIPTION"]/*'/>
public unsafe partial struct WS_ELEMENT_DESCRIPTION
{
    /// <include file='WS_ELEMENT_DESCRIPTION.xml' path='doc/member[@name="WS_ELEMENT_DESCRIPTION.elementLocalName"]/*'/>
    public WS_XML_STRING* elementLocalName;
    /// <include file='WS_ELEMENT_DESCRIPTION.xml' path='doc/member[@name="WS_ELEMENT_DESCRIPTION.elementNs"]/*'/>
    public WS_XML_STRING* elementNs;
    /// <include file='WS_ELEMENT_DESCRIPTION.xml' path='doc/member[@name="WS_ELEMENT_DESCRIPTION.type"]/*'/>
    public WS_TYPE type;
    /// <include file='WS_ELEMENT_DESCRIPTION.xml' path='doc/member[@name="WS_ELEMENT_DESCRIPTION.typeDescription"]/*'/>
    public void* typeDescription;
}