// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/NotificationActivationCallback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='NOTIFICATION_USER_INPUT_DATA.xml' path='doc/member[@name="NOTIFICATION_USER_INPUT_DATA"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct NOTIFICATION_USER_INPUT_DATA
{
    /// <include file='NOTIFICATION_USER_INPUT_DATA.xml' path='doc/member[@name="NOTIFICATION_USER_INPUT_DATA.Key"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* Key;
    /// <include file='NOTIFICATION_USER_INPUT_DATA.xml' path='doc/member[@name="NOTIFICATION_USER_INPUT_DATA.Value"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* Value;
}