// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WS_SERVICE_ENDPOINT.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT"]/*'/>
public unsafe partial struct WS_SERVICE_ENDPOINT
{
    /// <include file='WS_SERVICE_ENDPOINT.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT.address"]/*'/>
    public WS_ENDPOINT_ADDRESS address;
    /// <include file='WS_SERVICE_ENDPOINT.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT.channelBinding"]/*'/>
    public WS_CHANNEL_BINDING channelBinding;
    /// <include file='WS_SERVICE_ENDPOINT.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT.channelType"]/*'/>
    public WS_CHANNEL_TYPE channelType;
    /// <include file='WS_SERVICE_ENDPOINT.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT.securityDescription"]/*'/>
    [NativeTypeName("const WS_SECURITY_DESCRIPTION *")]
    public WS_SECURITY_DESCRIPTION* securityDescription;
    /// <include file='WS_SERVICE_ENDPOINT.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT.contract"]/*'/>
    [NativeTypeName("const WS_SERVICE_CONTRACT *")]
    public WS_SERVICE_CONTRACT* contract;
    /// <include file='WS_SERVICE_ENDPOINT.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT.authorizationCallback"]/*'/>
    [NativeTypeName("WS_SERVICE_SECURITY_CALLBACK")]
    public delegate* unmanaged<IntPtr, BOOL*, IntPtr, HRESULT> authorizationCallback;
    /// <include file='WS_SERVICE_ENDPOINT.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT.properties"]/*'/>
    [NativeTypeName("const WS_SERVICE_ENDPOINT_PROPERTY *")]
    public WS_SERVICE_ENDPOINT_PROPERTY* properties;
    /// <include file='WS_SERVICE_ENDPOINT.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT.propertyCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint propertyCount;
    /// <include file='WS_SERVICE_ENDPOINT.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT.channelProperties"]/*'/>
    public WS_CHANNEL_PROPERTIES channelProperties;
}