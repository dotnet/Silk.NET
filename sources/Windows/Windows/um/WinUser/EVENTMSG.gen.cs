// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EVENTMSG.xml' path='doc/member[@name="EVENTMSG"]/*'/>
public partial struct EVENTMSG
{
    /// <include file='EVENTMSG.xml' path='doc/member[@name="EVENTMSG.message"]/*'/>
    public uint message;
    /// <include file='EVENTMSG.xml' path='doc/member[@name="EVENTMSG.paramL"]/*'/>
    public uint paramL;
    /// <include file='EVENTMSG.xml' path='doc/member[@name="EVENTMSG.paramH"]/*'/>
    public uint paramH;
    /// <include file='EVENTMSG.xml' path='doc/member[@name="EVENTMSG.time"]/*'/>
    [NativeTypeName("DWORD")]
    public uint time;
    /// <include file='EVENTMSG.xml' path='doc/member[@name="EVENTMSG.hwnd"]/*'/>
    public HWND hwnd;
}