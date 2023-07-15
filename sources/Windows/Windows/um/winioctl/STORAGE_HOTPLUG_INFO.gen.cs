// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_HOTPLUG_INFO.xml' path='doc/member[@name="STORAGE_HOTPLUG_INFO"]/*'/>
public partial struct STORAGE_HOTPLUG_INFO
{
    /// <include file='STORAGE_HOTPLUG_INFO.xml' path='doc/member[@name="STORAGE_HOTPLUG_INFO.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_HOTPLUG_INFO.xml' path='doc/member[@name="STORAGE_HOTPLUG_INFO.MediaRemovable"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte MediaRemovable;
    /// <include file='STORAGE_HOTPLUG_INFO.xml' path='doc/member[@name="STORAGE_HOTPLUG_INFO.MediaHotplug"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte MediaHotplug;
    /// <include file='STORAGE_HOTPLUG_INFO.xml' path='doc/member[@name="STORAGE_HOTPLUG_INFO.DeviceHotplug"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte DeviceHotplug;
    /// <include file='STORAGE_HOTPLUG_INFO.xml' path='doc/member[@name="STORAGE_HOTPLUG_INFO.WriteCacheEnableOverride"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte WriteCacheEnableOverride;
}