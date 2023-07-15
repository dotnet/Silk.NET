// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='PRJ_NOTIFICATION_MAPPING.xml' path='doc/member[@name="PRJ_NOTIFICATION_MAPPING"]/*'/>
[SupportedOSPlatform("windows10.0.17763.0")]
public unsafe partial struct PRJ_NOTIFICATION_MAPPING
{
    /// <include file='PRJ_NOTIFICATION_MAPPING.xml' path='doc/member[@name="PRJ_NOTIFICATION_MAPPING.NotificationBitMask"]/*'/>
    public PRJ_NOTIFY_TYPES NotificationBitMask;
    /// <include file='PRJ_NOTIFICATION_MAPPING.xml' path='doc/member[@name="PRJ_NOTIFICATION_MAPPING.NotificationRoot"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* NotificationRoot;
}