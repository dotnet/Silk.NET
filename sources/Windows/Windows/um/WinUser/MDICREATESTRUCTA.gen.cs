// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MDICREATESTRUCTA.xml' path='doc/member[@name="MDICREATESTRUCTA"]/*'/>
public unsafe partial struct MDICREATESTRUCTA
{
    /// <include file='MDICREATESTRUCTA.xml' path='doc/member[@name="MDICREATESTRUCTA.szClass"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* szClass;
    /// <include file='MDICREATESTRUCTA.xml' path='doc/member[@name="MDICREATESTRUCTA.szTitle"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* szTitle;
    /// <include file='MDICREATESTRUCTA.xml' path='doc/member[@name="MDICREATESTRUCTA.hOwner"]/*'/>
    public HANDLE hOwner;
    /// <include file='MDICREATESTRUCTA.xml' path='doc/member[@name="MDICREATESTRUCTA.x"]/*'/>
    public int x;
    /// <include file='MDICREATESTRUCTA.xml' path='doc/member[@name="MDICREATESTRUCTA.y"]/*'/>
    public int y;
    /// <include file='MDICREATESTRUCTA.xml' path='doc/member[@name="MDICREATESTRUCTA.cx"]/*'/>
    public int cx;
    /// <include file='MDICREATESTRUCTA.xml' path='doc/member[@name="MDICREATESTRUCTA.cy"]/*'/>
    public int cy;
    /// <include file='MDICREATESTRUCTA.xml' path='doc/member[@name="MDICREATESTRUCTA.style"]/*'/>
    [NativeTypeName("DWORD")]
    public uint style;
    /// <include file='MDICREATESTRUCTA.xml' path='doc/member[@name="MDICREATESTRUCTA.lParam"]/*'/>
    public LPARAM lParam;
}