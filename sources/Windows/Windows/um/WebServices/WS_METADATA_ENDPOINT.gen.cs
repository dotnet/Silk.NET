// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WS_METADATA_ENDPOINT.xml' path='doc/member[@name="WS_METADATA_ENDPOINT"]/*'/>
public unsafe partial struct WS_METADATA_ENDPOINT
{
    /// <include file='WS_METADATA_ENDPOINT.xml' path='doc/member[@name="WS_METADATA_ENDPOINT.endpointAddress"]/*'/>
    public WS_ENDPOINT_ADDRESS endpointAddress;
    /// <include file='WS_METADATA_ENDPOINT.xml' path='doc/member[@name="WS_METADATA_ENDPOINT.endpointPolicy"]/*'/>
    [NativeTypeName("WS_POLICY*")]
    public IntPtr endpointPolicy;
    /// <include file='WS_METADATA_ENDPOINT.xml' path='doc/member[@name="WS_METADATA_ENDPOINT.portName"]/*'/>
    public WS_XML_STRING* portName;
    /// <include file='WS_METADATA_ENDPOINT.xml' path='doc/member[@name="WS_METADATA_ENDPOINT.serviceName"]/*'/>
    public WS_XML_STRING* serviceName;
    /// <include file='WS_METADATA_ENDPOINT.xml' path='doc/member[@name="WS_METADATA_ENDPOINT.serviceNs"]/*'/>
    public WS_XML_STRING* serviceNs;
    /// <include file='WS_METADATA_ENDPOINT.xml' path='doc/member[@name="WS_METADATA_ENDPOINT.bindingName"]/*'/>
    public WS_XML_STRING* bindingName;
    /// <include file='WS_METADATA_ENDPOINT.xml' path='doc/member[@name="WS_METADATA_ENDPOINT.bindingNs"]/*'/>
    public WS_XML_STRING* bindingNs;
    /// <include file='WS_METADATA_ENDPOINT.xml' path='doc/member[@name="WS_METADATA_ENDPOINT.portTypeName"]/*'/>
    public WS_XML_STRING* portTypeName;
    /// <include file='WS_METADATA_ENDPOINT.xml' path='doc/member[@name="WS_METADATA_ENDPOINT.portTypeNs"]/*'/>
    public WS_XML_STRING* portTypeNs;
}