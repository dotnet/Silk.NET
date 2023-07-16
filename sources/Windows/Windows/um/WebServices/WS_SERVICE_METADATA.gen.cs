// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_SERVICE_METADATA.xml' path='doc/member[@name="WS_SERVICE_METADATA"]/*'/>
public unsafe partial struct WS_SERVICE_METADATA
{
    /// <include file='WS_SERVICE_METADATA.xml' path='doc/member[@name="WS_SERVICE_METADATA.documentCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint documentCount;
    /// <include file='WS_SERVICE_METADATA.xml' path='doc/member[@name="WS_SERVICE_METADATA.documents"]/*'/>
    public WS_SERVICE_METADATA_DOCUMENT** documents;
    /// <include file='WS_SERVICE_METADATA.xml' path='doc/member[@name="WS_SERVICE_METADATA.serviceName"]/*'/>
    public WS_XML_STRING* serviceName;
    /// <include file='WS_SERVICE_METADATA.xml' path='doc/member[@name="WS_SERVICE_METADATA.serviceNs"]/*'/>
    public WS_XML_STRING* serviceNs;
}