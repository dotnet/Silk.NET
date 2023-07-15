// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO"]/*'/>
public partial struct GUITHREADINFO
{
    /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint flags;
    /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.hwndActive"]/*'/>
    public HWND hwndActive;
    /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.hwndFocus"]/*'/>
    public HWND hwndFocus;
    /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.hwndCapture"]/*'/>
    public HWND hwndCapture;
    /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.hwndMenuOwner"]/*'/>
    public HWND hwndMenuOwner;
    /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.hwndMoveSize"]/*'/>
    public HWND hwndMoveSize;
    /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.hwndCaret"]/*'/>
    public HWND hwndCaret;
    /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.rcCaret"]/*'/>
    public RECT rcCaret;
}