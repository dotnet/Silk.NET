// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum IMAPI_CD_TRACK_DIGITAL_COPY_SETTING
{
    IMAPI_CD_TRACK_DIGITAL_COPY_PERMITTED = 0,
    IMAPI_CD_TRACK_DIGITAL_COPY_PROHIBITED = 0x1,
    IMAPI_CD_TRACK_DIGITAL_COPY_SCMS = 0x2,
}
