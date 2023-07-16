// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_MESSAGE_INITIALIZATION.xml' path='doc/member[@name="WS_MESSAGE_INITIALIZATION"]/*'/>
public enum WS_MESSAGE_INITIALIZATION
{
    /// <include file='WS_MESSAGE_INITIALIZATION.xml' path='doc/member[@name="WS_MESSAGE_INITIALIZATION.WS_BLANK_MESSAGE"]/*'/>
    WS_BLANK_MESSAGE = 0,
    /// <include file='WS_MESSAGE_INITIALIZATION.xml' path='doc/member[@name="WS_MESSAGE_INITIALIZATION.WS_DUPLICATE_MESSAGE"]/*'/>
    WS_DUPLICATE_MESSAGE = 1,
    /// <include file='WS_MESSAGE_INITIALIZATION.xml' path='doc/member[@name="WS_MESSAGE_INITIALIZATION.WS_REQUEST_MESSAGE"]/*'/>
    WS_REQUEST_MESSAGE = 2,
    /// <include file='WS_MESSAGE_INITIALIZATION.xml' path='doc/member[@name="WS_MESSAGE_INITIALIZATION.WS_REPLY_MESSAGE"]/*'/>
    WS_REPLY_MESSAGE = 3,
    /// <include file='WS_MESSAGE_INITIALIZATION.xml' path='doc/member[@name="WS_MESSAGE_INITIALIZATION.WS_FAULT_MESSAGE"]/*'/>
    WS_FAULT_MESSAGE = 4,
}