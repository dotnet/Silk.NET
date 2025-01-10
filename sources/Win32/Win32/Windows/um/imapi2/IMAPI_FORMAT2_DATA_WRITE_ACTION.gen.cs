// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum IMAPI_FORMAT2_DATA_WRITE_ACTION
{
    IMAPI_FORMAT2_DATA_WRITE_ACTION_VALIDATING_MEDIA = 0,
    IMAPI_FORMAT2_DATA_WRITE_ACTION_FORMATTING_MEDIA = 0x1,
    IMAPI_FORMAT2_DATA_WRITE_ACTION_INITIALIZING_HARDWARE = 0x2,
    IMAPI_FORMAT2_DATA_WRITE_ACTION_CALIBRATING_POWER = 0x3,
    IMAPI_FORMAT2_DATA_WRITE_ACTION_WRITING_DATA = 0x4,
    IMAPI_FORMAT2_DATA_WRITE_ACTION_FINALIZATION = 0x5,
    IMAPI_FORMAT2_DATA_WRITE_ACTION_COMPLETED = 0x6,
    IMAPI_FORMAT2_DATA_WRITE_ACTION_VERIFYING = 0x7,
}
