// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='QUERY_USER_NOTIFICATION_STATE.xml' path='doc/member[@name="QUERY_USER_NOTIFICATION_STATE"]/*'/>
public enum QUERY_USER_NOTIFICATION_STATE
{
    /// <include file='QUERY_USER_NOTIFICATION_STATE.xml' path='doc/member[@name="QUERY_USER_NOTIFICATION_STATE.QUNS_NOT_PRESENT"]/*'/>
    QUNS_NOT_PRESENT = 1,
    /// <include file='QUERY_USER_NOTIFICATION_STATE.xml' path='doc/member[@name="QUERY_USER_NOTIFICATION_STATE.QUNS_BUSY"]/*'/>
    QUNS_BUSY = 2,
    /// <include file='QUERY_USER_NOTIFICATION_STATE.xml' path='doc/member[@name="QUERY_USER_NOTIFICATION_STATE.QUNS_RUNNING_D3D_FULL_SCREEN"]/*'/>
    QUNS_RUNNING_D3D_FULL_SCREEN = 3,
    /// <include file='QUERY_USER_NOTIFICATION_STATE.xml' path='doc/member[@name="QUERY_USER_NOTIFICATION_STATE.QUNS_PRESENTATION_MODE"]/*'/>
    QUNS_PRESENTATION_MODE = 4,
    /// <include file='QUERY_USER_NOTIFICATION_STATE.xml' path='doc/member[@name="QUERY_USER_NOTIFICATION_STATE.QUNS_ACCEPTS_NOTIFICATIONS"]/*'/>
    QUNS_ACCEPTS_NOTIFICATIONS = 5,
    /// <include file='QUERY_USER_NOTIFICATION_STATE.xml' path='doc/member[@name="QUERY_USER_NOTIFICATION_STATE.QUNS_QUIET_TIME"]/*'/>
    QUNS_QUIET_TIME = 6,
    /// <include file='QUERY_USER_NOTIFICATION_STATE.xml' path='doc/member[@name="QUERY_USER_NOTIFICATION_STATE.QUNS_APP"]/*'/>
    QUNS_APP = 7,
}