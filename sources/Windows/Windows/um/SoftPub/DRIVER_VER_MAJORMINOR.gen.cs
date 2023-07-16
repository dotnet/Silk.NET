// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DRIVER_VER_MAJORMINOR.xml' path='doc/member[@name="DRIVER_VER_MAJORMINOR"]/*'/>
public partial struct DRIVER_VER_MAJORMINOR
{
    /// <include file='DRIVER_VER_MAJORMINOR.xml' path='doc/member[@name="DRIVER_VER_MAJORMINOR.dwMajor"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMajor;
    /// <include file='DRIVER_VER_MAJORMINOR.xml' path='doc/member[@name="DRIVER_VER_MAJORMINOR.dwMinor"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinor;
}