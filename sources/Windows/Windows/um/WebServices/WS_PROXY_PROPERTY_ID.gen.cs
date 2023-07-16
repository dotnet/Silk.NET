// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_PROXY_PROPERTY_ID.xml' path='doc/member[@name="WS_PROXY_PROPERTY_ID"]/*'/>
public enum WS_PROXY_PROPERTY_ID
{
    /// <include file='WS_PROXY_PROPERTY_ID.xml' path='doc/member[@name="WS_PROXY_PROPERTY_ID.WS_PROXY_PROPERTY_CALL_TIMEOUT"]/*'/>
    WS_PROXY_PROPERTY_CALL_TIMEOUT = 0,
    /// <include file='WS_PROXY_PROPERTY_ID.xml' path='doc/member[@name="WS_PROXY_PROPERTY_ID.WS_PROXY_PROPERTY_MESSAGE_PROPERTIES"]/*'/>
    WS_PROXY_PROPERTY_MESSAGE_PROPERTIES = 1,
    /// <include file='WS_PROXY_PROPERTY_ID.xml' path='doc/member[@name="WS_PROXY_PROPERTY_ID.WS_PROXY_PROPERTY_MAX_CALL_POOL_SIZE"]/*'/>
    WS_PROXY_PROPERTY_MAX_CALL_POOL_SIZE = 2,
    /// <include file='WS_PROXY_PROPERTY_ID.xml' path='doc/member[@name="WS_PROXY_PROPERTY_ID.WS_PROXY_PROPERTY_STATE"]/*'/>
    WS_PROXY_PROPERTY_STATE = 3,
    /// <include file='WS_PROXY_PROPERTY_ID.xml' path='doc/member[@name="WS_PROXY_PROPERTY_ID.WS_PROXY_PROPERTY_MAX_PENDING_CALLS"]/*'/>
    WS_PROXY_PROPERTY_MAX_PENDING_CALLS = 4,
    /// <include file='WS_PROXY_PROPERTY_ID.xml' path='doc/member[@name="WS_PROXY_PROPERTY_ID.WS_PROXY_PROPERTY_MAX_CLOSE_TIMEOUT"]/*'/>
    WS_PROXY_PROPERTY_MAX_CLOSE_TIMEOUT = 5,
    /// <include file='WS_PROXY_PROPERTY_ID.xml' path='doc/member[@name="WS_PROXY_PROPERTY_ID.WS_PROXY_FAULT_LANG_ID"]/*'/>
    WS_PROXY_FAULT_LANG_ID = 6,
}