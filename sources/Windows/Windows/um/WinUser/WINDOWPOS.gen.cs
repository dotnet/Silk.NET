// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WINDOWPOS.xml' path='doc/member[@name="WINDOWPOS"]/*'/>
public partial struct WINDOWPOS
{
    /// <include file='WINDOWPOS.xml' path='doc/member[@name="WINDOWPOS.hwnd"]/*'/>
    public HWND hwnd;
    /// <include file='WINDOWPOS.xml' path='doc/member[@name="WINDOWPOS.hwndInsertAfter"]/*'/>
    public HWND hwndInsertAfter;
    /// <include file='WINDOWPOS.xml' path='doc/member[@name="WINDOWPOS.x"]/*'/>
    public int x;
    /// <include file='WINDOWPOS.xml' path='doc/member[@name="WINDOWPOS.y"]/*'/>
    public int y;
    /// <include file='WINDOWPOS.xml' path='doc/member[@name="WINDOWPOS.cx"]/*'/>
    public int cx;
    /// <include file='WINDOWPOS.xml' path='doc/member[@name="WINDOWPOS.cy"]/*'/>
    public int cy;
    /// <include file='WINDOWPOS.xml' path='doc/member[@name="WINDOWPOS.flags"]/*'/>
    public uint flags;
}