// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SERVERSILO_STATE.xml' path='doc/member[@name="SERVERSILO_STATE"]/*'/>
public enum SERVERSILO_STATE
{
    /// <include file='SERVERSILO_STATE.xml' path='doc/member[@name="SERVERSILO_STATE.SERVERSILO_INITING"]/*'/>
    SERVERSILO_INITING = 0,
    /// <include file='SERVERSILO_STATE.xml' path='doc/member[@name="SERVERSILO_STATE.SERVERSILO_STARTED"]/*'/>
    SERVERSILO_STARTED,
    /// <include file='SERVERSILO_STATE.xml' path='doc/member[@name="SERVERSILO_STATE.SERVERSILO_SHUTTING_DOWN"]/*'/>
    SERVERSILO_SHUTTING_DOWN,
    /// <include file='SERVERSILO_STATE.xml' path='doc/member[@name="SERVERSILO_STATE.SERVERSILO_TERMINATING"]/*'/>
    SERVERSILO_TERMINATING,
    /// <include file='SERVERSILO_STATE.xml' path='doc/member[@name="SERVERSILO_STATE.SERVERSILO_TERMINATED"]/*'/>
    SERVERSILO_TERMINATED,
}