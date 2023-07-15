// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/timezoneapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION"]/*'/>
public unsafe partial struct DYNAMIC_TIME_ZONE_INFORMATION
{
    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.Bias"]/*'/>
    [NativeTypeName("LONG")]
    public int Bias;
    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.StandardName"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort StandardName[32];
    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.StandardDate"]/*'/>
    public SYSTEMTIME StandardDate;
    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.StandardBias"]/*'/>
    [NativeTypeName("LONG")]
    public int StandardBias;
    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.DaylightName"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort DaylightName[32];
    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.DaylightDate"]/*'/>
    public SYSTEMTIME DaylightDate;
    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.DaylightBias"]/*'/>
    [NativeTypeName("LONG")]
    public int DaylightBias;
    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.TimeZoneKeyName"]/*'/>
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort TimeZoneKeyName[128];
    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.DynamicDaylightTimeDisabled"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte DynamicDaylightTimeDisabled;
}