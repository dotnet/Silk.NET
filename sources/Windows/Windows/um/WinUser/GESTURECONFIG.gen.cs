// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='GESTURECONFIG.xml' path='doc/member[@name="GESTURECONFIG"]/*'/>
public partial struct GESTURECONFIG
{
    /// <include file='GESTURECONFIG.xml' path='doc/member[@name="GESTURECONFIG.dwID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwID;
    /// <include file='GESTURECONFIG.xml' path='doc/member[@name="GESTURECONFIG.dwWant"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwWant;
    /// <include file='GESTURECONFIG.xml' path='doc/member[@name="GESTURECONFIG.dwBlock"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBlock;
}