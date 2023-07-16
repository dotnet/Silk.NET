// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP"]/*'/>
public enum CSV_CONTROL_OP
{
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlStartRedirectFile"]/*'/>
    CsvControlStartRedirectFile = 0x02,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlStopRedirectFile"]/*'/>
    CsvControlStopRedirectFile = 0x03,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlQueryRedirectState"]/*'/>
    CsvControlQueryRedirectState = 0x04,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlQueryFileRevision"]/*'/>
    CsvControlQueryFileRevision = 0x06,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlQueryMdsPath"]/*'/>
    CsvControlQueryMdsPath = 0x08,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlQueryFileRevisionFileId128"]/*'/>
    CsvControlQueryFileRevisionFileId128 = 0x09,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlQueryVolumeRedirectState"]/*'/>
    CsvControlQueryVolumeRedirectState = 0x0a,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlEnableUSNRangeModificationTracking"]/*'/>
    CsvControlEnableUSNRangeModificationTracking = 0x0d,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlMarkHandleLocalVolumeMount"]/*'/>
    CsvControlMarkHandleLocalVolumeMount = 0x0e,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlUnmarkHandleLocalVolumeMount"]/*'/>
    CsvControlUnmarkHandleLocalVolumeMount = 0x0f,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlGetCsvFsMdsPathV2"]/*'/>
    CsvControlGetCsvFsMdsPathV2 = 0x12,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlDisableCaching"]/*'/>
    CsvControlDisableCaching = 0x13,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlEnableCaching"]/*'/>
    CsvControlEnableCaching = 0x14,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlStartForceDFO"]/*'/>
    CsvControlStartForceDFO = 0x15,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlStopForceDFO"]/*'/>
    CsvControlStopForceDFO = 0x16,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlQueryMdsPathNoPause"]/*'/>
    CsvControlQueryMdsPathNoPause = 0x17,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlSetVolumeId"]/*'/>
    CsvControlSetVolumeId = 0x18,
    /// <include file='CSV_CONTROL_OP.xml' path='doc/member[@name="CSV_CONTROL_OP.CsvControlQueryVolumeId"]/*'/>
    CsvControlQueryVolumeId = 0x19,
}