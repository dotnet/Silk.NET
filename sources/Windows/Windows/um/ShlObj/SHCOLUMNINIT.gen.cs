// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SHCOLUMNINIT.xml' path='doc/member[@name="SHCOLUMNINIT"]/*'/>
public unsafe partial struct SHCOLUMNINIT
{
    /// <include file='SHCOLUMNINIT.xml' path='doc/member[@name="SHCOLUMNINIT.dwFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwFlags;
    /// <include file='SHCOLUMNINIT.xml' path='doc/member[@name="SHCOLUMNINIT.dwReserved"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwReserved;
    /// <include file='SHCOLUMNINIT.xml' path='doc/member[@name="SHCOLUMNINIT.wszFolder"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort wszFolder[260];
}