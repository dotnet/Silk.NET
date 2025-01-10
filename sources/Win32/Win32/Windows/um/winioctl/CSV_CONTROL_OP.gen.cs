// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CSV_CONTROL_OP
{
    CsvControlStartRedirectFile = 0x02,
    CsvControlStopRedirectFile = 0x03,
    CsvControlQueryRedirectState = 0x04,
    CsvControlQueryFileRevision = 0x06,
    CsvControlQueryMdsPath = 0x08,
    CsvControlQueryFileRevisionFileId128 = 0x09,
    CsvControlQueryVolumeRedirectState = 0x0a,
    CsvControlEnableUSNRangeModificationTracking = 0x0d,
    CsvControlMarkHandleLocalVolumeMount = 0x0e,
    CsvControlUnmarkHandleLocalVolumeMount = 0x0f,
    CsvControlGetCsvFsMdsPathV2 = 0x12,
    CsvControlDisableCaching = 0x13,
    CsvControlEnableCaching = 0x14,
    CsvControlStartForceDFO = 0x15,
    CsvControlStopForceDFO = 0x16,
    CsvControlQueryMdsPathNoPause = 0x17,
    CsvControlSetVolumeId = 0x18,
    CsvControlQueryVolumeId = 0x19,
}
