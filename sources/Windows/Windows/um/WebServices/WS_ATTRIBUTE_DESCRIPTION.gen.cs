// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_ATTRIBUTE_DESCRIPTION.xml' path='doc/member[@name="WS_ATTRIBUTE_DESCRIPTION"]/*'/>
public unsafe partial struct WS_ATTRIBUTE_DESCRIPTION
{
    /// <include file='WS_ATTRIBUTE_DESCRIPTION.xml' path='doc/member[@name="WS_ATTRIBUTE_DESCRIPTION.attributeLocalName"]/*'/>
    public WS_XML_STRING* attributeLocalName;
    /// <include file='WS_ATTRIBUTE_DESCRIPTION.xml' path='doc/member[@name="WS_ATTRIBUTE_DESCRIPTION.attributeNs"]/*'/>
    public WS_XML_STRING* attributeNs;
    /// <include file='WS_ATTRIBUTE_DESCRIPTION.xml' path='doc/member[@name="WS_ATTRIBUTE_DESCRIPTION.type"]/*'/>
    public WS_TYPE type;
    /// <include file='WS_ATTRIBUTE_DESCRIPTION.xml' path='doc/member[@name="WS_ATTRIBUTE_DESCRIPTION.typeDescription"]/*'/>
    public void* typeDescription;
}