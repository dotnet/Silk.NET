// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='WS_XML_TOKEN_MESSAGE_SECURITY_BINDING.xml' path='doc/member[@name="WS_XML_TOKEN_MESSAGE_SECURITY_BINDING"]/*'/>
public partial struct WS_XML_TOKEN_MESSAGE_SECURITY_BINDING
{
    /// <include file='WS_XML_TOKEN_MESSAGE_SECURITY_BINDING.xml' path='doc/member[@name="WS_XML_TOKEN_MESSAGE_SECURITY_BINDING.binding"]/*'/>
    public WS_SECURITY_BINDING binding;
    /// <include file='WS_XML_TOKEN_MESSAGE_SECURITY_BINDING.xml' path='doc/member[@name="WS_XML_TOKEN_MESSAGE_SECURITY_BINDING.bindingUsage"]/*'/>
    public WS_MESSAGE_SECURITY_USAGE bindingUsage;
    /// <include file='WS_XML_TOKEN_MESSAGE_SECURITY_BINDING.xml' path='doc/member[@name="WS_XML_TOKEN_MESSAGE_SECURITY_BINDING.xmlToken"]/*'/>
    [NativeTypeName("WS_SECURITY_TOKEN*")]
    public IntPtr xmlToken;
}