// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MOUSEMOVEPOINT.xml' path='doc/member[@name="MOUSEMOVEPOINT"]/*'/>
public partial struct MOUSEMOVEPOINT
{
    /// <include file='MOUSEMOVEPOINT.xml' path='doc/member[@name="MOUSEMOVEPOINT.x"]/*'/>
    public int x;
    /// <include file='MOUSEMOVEPOINT.xml' path='doc/member[@name="MOUSEMOVEPOINT.y"]/*'/>
    public int y;
    /// <include file='MOUSEMOVEPOINT.xml' path='doc/member[@name="MOUSEMOVEPOINT.time"]/*'/>
    [NativeTypeName("DWORD")]
    public uint time;
    /// <include file='MOUSEMOVEPOINT.xml' path='doc/member[@name="MOUSEMOVEPOINT.dwExtraInfo"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint dwExtraInfo;
}