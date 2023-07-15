// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidclass.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HID_DRIVER_CONFIG.xml' path='doc/member[@name="HID_DRIVER_CONFIG"]/*'/>
public partial struct HID_DRIVER_CONFIG
{
    /// <include file='HID_DRIVER_CONFIG.xml' path='doc/member[@name="HID_DRIVER_CONFIG.Size"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Size;
    /// <include file='HID_DRIVER_CONFIG.xml' path='doc/member[@name="HID_DRIVER_CONFIG.RingBufferSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint RingBufferSize;
}