// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HARDWARE_COUNTER_DATA.xml' path='doc/member[@name="HARDWARE_COUNTER_DATA"]/*'/>
public partial struct HARDWARE_COUNTER_DATA
{
    /// <include file='HARDWARE_COUNTER_DATA.xml' path='doc/member[@name="HARDWARE_COUNTER_DATA.Type"]/*'/>
    public HARDWARE_COUNTER_TYPE Type;
    /// <include file='HARDWARE_COUNTER_DATA.xml' path='doc/member[@name="HARDWARE_COUNTER_DATA.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
    /// <include file='HARDWARE_COUNTER_DATA.xml' path='doc/member[@name="HARDWARE_COUNTER_DATA.Value"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Value;
}