// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SERIALKEYSA.xml' path='doc/member[@name="SERIALKEYSA"]/*'/>
public unsafe partial struct SERIALKEYSA
{
    /// <include file='SERIALKEYSA.xml' path='doc/member[@name="SERIALKEYSA.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='SERIALKEYSA.xml' path='doc/member[@name="SERIALKEYSA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='SERIALKEYSA.xml' path='doc/member[@name="SERIALKEYSA.lpszActivePort"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpszActivePort;
    /// <include file='SERIALKEYSA.xml' path='doc/member[@name="SERIALKEYSA.lpszPort"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpszPort;
    /// <include file='SERIALKEYSA.xml' path='doc/member[@name="SERIALKEYSA.iBaudRate"]/*'/>
    public uint iBaudRate;
    /// <include file='SERIALKEYSA.xml' path='doc/member[@name="SERIALKEYSA.iPortState"]/*'/>
    public uint iPortState;
    /// <include file='SERIALKEYSA.xml' path='doc/member[@name="SERIALKEYSA.iActive"]/*'/>
    public uint iActive;
}