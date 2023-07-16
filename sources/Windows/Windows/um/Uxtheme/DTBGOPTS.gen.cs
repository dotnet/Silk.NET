// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DTBGOPTS.xml' path='doc/member[@name="DTBGOPTS"]/*'/>
public partial struct DTBGOPTS
{
    /// <include file='DTBGOPTS.xml' path='doc/member[@name="DTBGOPTS.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DTBGOPTS.xml' path='doc/member[@name="DTBGOPTS.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DTBGOPTS.xml' path='doc/member[@name="DTBGOPTS.rcClip"]/*'/>
    public RECT rcClip;
}