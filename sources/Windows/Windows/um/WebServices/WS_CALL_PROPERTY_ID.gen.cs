// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_CALL_PROPERTY_ID.xml' path='doc/member[@name="WS_CALL_PROPERTY_ID"]/*'/>
public enum WS_CALL_PROPERTY_ID
{
    /// <include file='WS_CALL_PROPERTY_ID.xml' path='doc/member[@name="WS_CALL_PROPERTY_ID.WS_CALL_PROPERTY_CHECK_MUST_UNDERSTAND"]/*'/>
    WS_CALL_PROPERTY_CHECK_MUST_UNDERSTAND = 0,
    /// <include file='WS_CALL_PROPERTY_ID.xml' path='doc/member[@name="WS_CALL_PROPERTY_ID.WS_CALL_PROPERTY_SEND_MESSAGE_CONTEXT"]/*'/>
    WS_CALL_PROPERTY_SEND_MESSAGE_CONTEXT = 1,
    /// <include file='WS_CALL_PROPERTY_ID.xml' path='doc/member[@name="WS_CALL_PROPERTY_ID.WS_CALL_PROPERTY_RECEIVE_MESSAGE_CONTEXT"]/*'/>
    WS_CALL_PROPERTY_RECEIVE_MESSAGE_CONTEXT = 2,
    /// <include file='WS_CALL_PROPERTY_ID.xml' path='doc/member[@name="WS_CALL_PROPERTY_ID.WS_CALL_PROPERTY_CALL_ID"]/*'/>
    WS_CALL_PROPERTY_CALL_ID = 3,
}