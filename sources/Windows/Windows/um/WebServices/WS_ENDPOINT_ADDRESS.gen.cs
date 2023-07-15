// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='WS_ENDPOINT_ADDRESS.xml' path='doc/member[@name="WS_ENDPOINT_ADDRESS"]/*'/>
public unsafe partial struct WS_ENDPOINT_ADDRESS
{
    /// <include file='WS_ENDPOINT_ADDRESS.xml' path='doc/member[@name="WS_ENDPOINT_ADDRESS.url"]/*'/>
    public WS_STRING url;
    /// <include file='WS_ENDPOINT_ADDRESS.xml' path='doc/member[@name="WS_ENDPOINT_ADDRESS.headers"]/*'/>
    [NativeTypeName("WS_XML_BUFFER*")]
    public IntPtr headers;
    /// <include file='WS_ENDPOINT_ADDRESS.xml' path='doc/member[@name="WS_ENDPOINT_ADDRESS.extensions"]/*'/>
    [NativeTypeName("WS_XML_BUFFER*")]
    public IntPtr extensions;
    /// <include file='WS_ENDPOINT_ADDRESS.xml' path='doc/member[@name="WS_ENDPOINT_ADDRESS.identity"]/*'/>
    public WS_ENDPOINT_IDENTITY* identity;
}