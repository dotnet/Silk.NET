// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_SERVICE_ENDPOINT_METADATA.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_METADATA"]/*'/>
public unsafe partial struct WS_SERVICE_ENDPOINT_METADATA
{
    /// <include file='WS_SERVICE_ENDPOINT_METADATA.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_METADATA.portName"]/*'/>
    public WS_XML_STRING* portName;
    /// <include file='WS_SERVICE_ENDPOINT_METADATA.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_METADATA.bindingName"]/*'/>
    public WS_XML_STRING* bindingName;
    /// <include file='WS_SERVICE_ENDPOINT_METADATA.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_METADATA.bindingNs"]/*'/>
    public WS_XML_STRING* bindingNs;
}