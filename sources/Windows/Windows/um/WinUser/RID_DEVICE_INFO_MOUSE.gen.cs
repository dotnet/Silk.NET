// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='RID_DEVICE_INFO_MOUSE.xml' path='doc/member[@name="RID_DEVICE_INFO_MOUSE"]/*'/>
public partial struct RID_DEVICE_INFO_MOUSE
{
    /// <include file='RID_DEVICE_INFO_MOUSE.xml' path='doc/member[@name="RID_DEVICE_INFO_MOUSE.dwId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwId;
    /// <include file='RID_DEVICE_INFO_MOUSE.xml' path='doc/member[@name="RID_DEVICE_INFO_MOUSE.dwNumberOfButtons"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumberOfButtons;
    /// <include file='RID_DEVICE_INFO_MOUSE.xml' path='doc/member[@name="RID_DEVICE_INFO_MOUSE.dwSampleRate"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSampleRate;
    /// <include file='RID_DEVICE_INFO_MOUSE.xml' path='doc/member[@name="RID_DEVICE_INFO_MOUSE.fHasHorizontalWheel"]/*'/>
    public BOOL fHasHorizontalWheel;
}