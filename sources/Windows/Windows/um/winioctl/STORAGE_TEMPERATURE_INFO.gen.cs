// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_TEMPERATURE_INFO.xml' path='doc/member[@name="STORAGE_TEMPERATURE_INFO"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_TEMPERATURE_INFO
{
    /// <include file='STORAGE_TEMPERATURE_INFO.xml' path='doc/member[@name="STORAGE_TEMPERATURE_INFO.Index"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Index;
    /// <include file='STORAGE_TEMPERATURE_INFO.xml' path='doc/member[@name="STORAGE_TEMPERATURE_INFO.Temperature"]/*'/>
    public short Temperature;
    /// <include file='STORAGE_TEMPERATURE_INFO.xml' path='doc/member[@name="STORAGE_TEMPERATURE_INFO.OverThreshold"]/*'/>
    public short OverThreshold;
    /// <include file='STORAGE_TEMPERATURE_INFO.xml' path='doc/member[@name="STORAGE_TEMPERATURE_INFO.UnderThreshold"]/*'/>
    public short UnderThreshold;
    /// <include file='STORAGE_TEMPERATURE_INFO.xml' path='doc/member[@name="STORAGE_TEMPERATURE_INFO.OverThresholdChangable"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte OverThresholdChangable;
    /// <include file='STORAGE_TEMPERATURE_INFO.xml' path='doc/member[@name="STORAGE_TEMPERATURE_INFO.UnderThresholdChangable"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte UnderThresholdChangable;
    /// <include file='STORAGE_TEMPERATURE_INFO.xml' path='doc/member[@name="STORAGE_TEMPERATURE_INFO.EventGenerated"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte EventGenerated;
    /// <include file='STORAGE_TEMPERATURE_INFO.xml' path='doc/member[@name="STORAGE_TEMPERATURE_INFO.Reserved0"]/*'/>
    public byte Reserved0;
    /// <include file='STORAGE_TEMPERATURE_INFO.xml' path='doc/member[@name="STORAGE_TEMPERATURE_INFO.Reserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved1;
}