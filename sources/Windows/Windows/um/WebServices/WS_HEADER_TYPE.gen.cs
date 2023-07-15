// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_HEADER_TYPE.xml' path='doc/member[@name="WS_HEADER_TYPE"]/*'/>
public enum WS_HEADER_TYPE
{
    /// <include file='WS_HEADER_TYPE.xml' path='doc/member[@name="WS_HEADER_TYPE.WS_ACTION_HEADER"]/*'/>
    WS_ACTION_HEADER = 1,
    /// <include file='WS_HEADER_TYPE.xml' path='doc/member[@name="WS_HEADER_TYPE.WS_TO_HEADER"]/*'/>
    WS_TO_HEADER = 2,
    /// <include file='WS_HEADER_TYPE.xml' path='doc/member[@name="WS_HEADER_TYPE.WS_MESSAGE_ID_HEADER"]/*'/>
    WS_MESSAGE_ID_HEADER = 3,
    /// <include file='WS_HEADER_TYPE.xml' path='doc/member[@name="WS_HEADER_TYPE.WS_RELATES_TO_HEADER"]/*'/>
    WS_RELATES_TO_HEADER = 4,
    /// <include file='WS_HEADER_TYPE.xml' path='doc/member[@name="WS_HEADER_TYPE.WS_FROM_HEADER"]/*'/>
    WS_FROM_HEADER = 5,
    /// <include file='WS_HEADER_TYPE.xml' path='doc/member[@name="WS_HEADER_TYPE.WS_REPLY_TO_HEADER"]/*'/>
    WS_REPLY_TO_HEADER = 6,
    /// <include file='WS_HEADER_TYPE.xml' path='doc/member[@name="WS_HEADER_TYPE.WS_FAULT_TO_HEADER"]/*'/>
    WS_FAULT_TO_HEADER = 7,
}