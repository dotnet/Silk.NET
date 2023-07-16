// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='POLYTEXTW.xml' path='doc/member[@name="POLYTEXTW"]/*'/>
public unsafe partial struct POLYTEXTW
{
    /// <include file='POLYTEXTW.xml' path='doc/member[@name="POLYTEXTW.x"]/*'/>
    public int x;
    /// <include file='POLYTEXTW.xml' path='doc/member[@name="POLYTEXTW.y"]/*'/>
    public int y;
    /// <include file='POLYTEXTW.xml' path='doc/member[@name="POLYTEXTW.n"]/*'/>
    public uint n;
    /// <include file='POLYTEXTW.xml' path='doc/member[@name="POLYTEXTW.lpstr"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpstr;
    /// <include file='POLYTEXTW.xml' path='doc/member[@name="POLYTEXTW.uiFlags"]/*'/>
    public uint uiFlags;
    /// <include file='POLYTEXTW.xml' path='doc/member[@name="POLYTEXTW.rcl"]/*'/>
    public RECT rcl;
    /// <include file='POLYTEXTW.xml' path='doc/member[@name="POLYTEXTW.pdx"]/*'/>
    public int* pdx;
}