// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CURSORINFO.xml' path='doc/member[@name="CURSORINFO"]/*'/>
public partial struct CURSORINFO
{
    /// <include file='CURSORINFO.xml' path='doc/member[@name="CURSORINFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CURSORINFO.xml' path='doc/member[@name="CURSORINFO.flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint flags;
    /// <include file='CURSORINFO.xml' path='doc/member[@name="CURSORINFO.hCursor"]/*'/>
    public HCURSOR hCursor;
    /// <include file='CURSORINFO.xml' path='doc/member[@name="CURSORINFO.ptScreenPos"]/*'/>
    public POINT ptScreenPos;
}