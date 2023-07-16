// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MDICREATESTRUCTW.xml' path='doc/member[@name="MDICREATESTRUCTW"]/*'/>
public unsafe partial struct MDICREATESTRUCTW
{
    /// <include file='MDICREATESTRUCTW.xml' path='doc/member[@name="MDICREATESTRUCTW.szClass"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* szClass;
    /// <include file='MDICREATESTRUCTW.xml' path='doc/member[@name="MDICREATESTRUCTW.szTitle"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* szTitle;
    /// <include file='MDICREATESTRUCTW.xml' path='doc/member[@name="MDICREATESTRUCTW.hOwner"]/*'/>
    public HANDLE hOwner;
    /// <include file='MDICREATESTRUCTW.xml' path='doc/member[@name="MDICREATESTRUCTW.x"]/*'/>
    public int x;
    /// <include file='MDICREATESTRUCTW.xml' path='doc/member[@name="MDICREATESTRUCTW.y"]/*'/>
    public int y;
    /// <include file='MDICREATESTRUCTW.xml' path='doc/member[@name="MDICREATESTRUCTW.cx"]/*'/>
    public int cx;
    /// <include file='MDICREATESTRUCTW.xml' path='doc/member[@name="MDICREATESTRUCTW.cy"]/*'/>
    public int cy;
    /// <include file='MDICREATESTRUCTW.xml' path='doc/member[@name="MDICREATESTRUCTW.style"]/*'/>
    [NativeTypeName("DWORD")]
    public uint style;
    /// <include file='MDICREATESTRUCTW.xml' path='doc/member[@name="MDICREATESTRUCTW.lParam"]/*'/>
    public LPARAM lParam;
}