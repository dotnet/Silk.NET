// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ACCESSTIMEOUT.xml' path='doc/member[@name="ACCESSTIMEOUT"]/*'/>
public partial struct ACCESSTIMEOUT
{
    /// <include file='ACCESSTIMEOUT.xml' path='doc/member[@name="ACCESSTIMEOUT.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='ACCESSTIMEOUT.xml' path='doc/member[@name="ACCESSTIMEOUT.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='ACCESSTIMEOUT.xml' path='doc/member[@name="ACCESSTIMEOUT.iTimeOutMSec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iTimeOutMSec;
}