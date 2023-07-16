// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HIGHCONTRASTW.xml' path='doc/member[@name="HIGHCONTRASTW"]/*'/>
public unsafe partial struct HIGHCONTRASTW
{
    /// <include file='HIGHCONTRASTW.xml' path='doc/member[@name="HIGHCONTRASTW.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='HIGHCONTRASTW.xml' path='doc/member[@name="HIGHCONTRASTW.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='HIGHCONTRASTW.xml' path='doc/member[@name="HIGHCONTRASTW.lpszDefaultScheme"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszDefaultScheme;
}