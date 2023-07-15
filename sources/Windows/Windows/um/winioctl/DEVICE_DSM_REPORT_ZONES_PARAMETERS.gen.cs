// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DEVICE_DSM_REPORT_ZONES_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_PARAMETERS"]/*'/>
public unsafe partial struct DEVICE_DSM_REPORT_ZONES_PARAMETERS
{
    /// <include file='DEVICE_DSM_REPORT_ZONES_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_PARAMETERS.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='DEVICE_DSM_REPORT_ZONES_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_PARAMETERS.ReportOption"]/*'/>
    public byte ReportOption;
    /// <include file='DEVICE_DSM_REPORT_ZONES_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_PARAMETERS.Partial"]/*'/>
    public byte Partial;
    /// <include file='DEVICE_DSM_REPORT_ZONES_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_PARAMETERS.Reserved"]/*'/>
    [NativeTypeName("BYTE[2]")]
    public fixed byte Reserved[2];
}