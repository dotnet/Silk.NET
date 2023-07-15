// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_DEVICE_UNSAFE_SHUTDOWN_COUNT.xml' path='doc/member[@name="STORAGE_DEVICE_UNSAFE_SHUTDOWN_COUNT"]/*'/>
public partial struct STORAGE_DEVICE_UNSAFE_SHUTDOWN_COUNT
{
    /// <include file='STORAGE_DEVICE_UNSAFE_SHUTDOWN_COUNT.xml' path='doc/member[@name="STORAGE_DEVICE_UNSAFE_SHUTDOWN_COUNT.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_DEVICE_UNSAFE_SHUTDOWN_COUNT.xml' path='doc/member[@name="STORAGE_DEVICE_UNSAFE_SHUTDOWN_COUNT.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_DEVICE_UNSAFE_SHUTDOWN_COUNT.xml' path='doc/member[@name="STORAGE_DEVICE_UNSAFE_SHUTDOWN_COUNT.UnsafeShutdownCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UnsafeShutdownCount;
}