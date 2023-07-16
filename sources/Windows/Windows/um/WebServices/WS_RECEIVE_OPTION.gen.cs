// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_RECEIVE_OPTION.xml' path='doc/member[@name="WS_RECEIVE_OPTION"]/*'/>
public enum WS_RECEIVE_OPTION
{
    /// <include file='WS_RECEIVE_OPTION.xml' path='doc/member[@name="WS_RECEIVE_OPTION.WS_RECEIVE_REQUIRED_MESSAGE"]/*'/>
    WS_RECEIVE_REQUIRED_MESSAGE = 1,
    /// <include file='WS_RECEIVE_OPTION.xml' path='doc/member[@name="WS_RECEIVE_OPTION.WS_RECEIVE_OPTIONAL_MESSAGE"]/*'/>
    WS_RECEIVE_OPTIONAL_MESSAGE = 2,
}