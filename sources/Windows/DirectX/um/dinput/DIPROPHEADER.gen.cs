// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DIPROPHEADER.xml' path='doc/member[@name="DIPROPHEADER"]/*'/>
public partial struct DIPROPHEADER
{
    /// <include file='DIPROPHEADER.xml' path='doc/member[@name="DIPROPHEADER.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DIPROPHEADER.xml' path='doc/member[@name="DIPROPHEADER.dwHeaderSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHeaderSize;
    /// <include file='DIPROPHEADER.xml' path='doc/member[@name="DIPROPHEADER.dwObj"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwObj;
    /// <include file='DIPROPHEADER.xml' path='doc/member[@name="DIPROPHEADER.dwHow"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHow;
}