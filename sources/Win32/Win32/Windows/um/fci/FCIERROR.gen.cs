// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fci.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum FCIERROR
{
    FCIERR_NONE,
    FCIERR_OPEN_SRC,
    FCIERR_READ_SRC,
    FCIERR_ALLOC_FAIL,
    FCIERR_TEMP_FILE,
    FCIERR_BAD_COMPR_TYPE,
    FCIERR_CAB_FILE,
    FCIERR_USER_ABORT,
    FCIERR_MCI_FAIL,
    FCIERR_CAB_FORMAT_LIMIT,
}
