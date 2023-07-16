// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='APPLICATIONLAUNCH_SETTING_VALUE.xml' path='doc/member[@name="APPLICATIONLAUNCH_SETTING_VALUE"]/*'/>
public partial struct APPLICATIONLAUNCH_SETTING_VALUE
{
    /// <include file='APPLICATIONLAUNCH_SETTING_VALUE.xml' path='doc/member[@name="APPLICATIONLAUNCH_SETTING_VALUE.ActivationTime"]/*'/>
    public LARGE_INTEGER ActivationTime;
    /// <include file='APPLICATIONLAUNCH_SETTING_VALUE.xml' path='doc/member[@name="APPLICATIONLAUNCH_SETTING_VALUE.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='APPLICATIONLAUNCH_SETTING_VALUE.xml' path='doc/member[@name="APPLICATIONLAUNCH_SETTING_VALUE.ButtonInstanceID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ButtonInstanceID;
}