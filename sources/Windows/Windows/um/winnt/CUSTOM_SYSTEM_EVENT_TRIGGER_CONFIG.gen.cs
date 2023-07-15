// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG.xml' path='doc/member[@name="CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG"]/*'/>
public unsafe partial struct CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG
{
    /// <include file='CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG.xml' path='doc/member[@name="CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG.xml' path='doc/member[@name="CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG.TriggerId"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* TriggerId;
}