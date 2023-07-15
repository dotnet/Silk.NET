// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT.xml' path='doc/member[@name="CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT"]/*'/>
public unsafe partial struct CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT
{
    /// <include file='CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT.xml' path='doc/member[@name="CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT.VetoedFromAltitudeIntegral"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong VetoedFromAltitudeIntegral;
    /// <include file='CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT.xml' path='doc/member[@name="CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT.VetoedFromAltitudeDecimal"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong VetoedFromAltitudeDecimal;
    /// <include file='CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT.xml' path='doc/member[@name="CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT.Reason"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort Reason[256];
}