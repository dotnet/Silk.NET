// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum IMAPI_MODE_PAGE_TYPE
{
    IMAPI_MODE_PAGE_TYPE_READ_WRITE_ERROR_RECOVERY = 0x1,
    IMAPI_MODE_PAGE_TYPE_MRW = 0x3,
    IMAPI_MODE_PAGE_TYPE_WRITE_PARAMETERS = 0x5,
    IMAPI_MODE_PAGE_TYPE_CACHING = 0x8,
    IMAPI_MODE_PAGE_TYPE_INFORMATIONAL_EXCEPTIONS = 0x1c,
    IMAPI_MODE_PAGE_TYPE_TIMEOUT_AND_PROTECT = 0x1d,
    IMAPI_MODE_PAGE_TYPE_POWER_CONDITION = 0x1a,
    IMAPI_MODE_PAGE_TYPE_LEGACY_CAPABILITIES = 0x2a,
}
