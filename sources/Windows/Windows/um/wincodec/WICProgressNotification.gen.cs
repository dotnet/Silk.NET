// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WICProgressNotification.xml' path='doc/member[@name="WICProgressNotification"]/*'/>
public enum WICProgressNotification
{
    /// <include file='WICProgressNotification.xml' path='doc/member[@name="WICProgressNotification.WICProgressNotificationBegin"]/*'/>
    WICProgressNotificationBegin = 0x10000,
    /// <include file='WICProgressNotification.xml' path='doc/member[@name="WICProgressNotification.WICProgressNotificationEnd"]/*'/>
    WICProgressNotificationEnd = 0x20000,
    /// <include file='WICProgressNotification.xml' path='doc/member[@name="WICProgressNotification.WICProgressNotificationFrequent"]/*'/>
    WICProgressNotificationFrequent = 0x40000,
    /// <include file='WICProgressNotification.xml' path='doc/member[@name="WICProgressNotification.WICProgressNotificationAll"]/*'/>
    WICProgressNotificationAll = unchecked((int)(0xffff0000)),
    /// <include file='WICProgressNotification.xml' path='doc/member[@name="WICProgressNotification.WICPROGRESSNOTIFICATION_FORCE_DWORD"]/*'/>
    WICPROGRESSNOTIFICATION_FORCE_DWORD = 0x7fffffff,
}