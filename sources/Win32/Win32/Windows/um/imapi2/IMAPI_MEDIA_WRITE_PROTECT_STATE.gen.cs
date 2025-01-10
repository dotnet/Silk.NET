// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum IMAPI_MEDIA_WRITE_PROTECT_STATE
{
    IMAPI_WRITEPROTECTED_UNTIL_POWERDOWN = 0x1,
    IMAPI_WRITEPROTECTED_BY_CARTRIDGE = 0x2,
    IMAPI_WRITEPROTECTED_BY_MEDIA_SPECIFIC_REASON = 0x4,
    IMAPI_WRITEPROTECTED_BY_SOFTWARE_WRITE_PROTECT = 0x8,
    IMAPI_WRITEPROTECTED_BY_DISC_CONTROL_BLOCK = 0x10,
    IMAPI_WRITEPROTECTED_READ_ONLY_MEDIA = 0x4000,
}
