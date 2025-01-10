// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PathCch.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PATHCCH_OPTIONS
{
    PATHCCH_NONE = 0x0,
    PATHCCH_ALLOW_LONG_PATHS = 0x01,
    PATHCCH_FORCE_ENABLE_LONG_NAME_PROCESS = 0x02,
    PATHCCH_FORCE_DISABLE_LONG_NAME_PROCESS = 0x04,
    PATHCCH_DO_NOT_NORMALIZE_SEGMENTS = 0x08,
    PATHCCH_ENSURE_IS_EXTENDED_LENGTH_PATH = 0x10,
    PATHCCH_ENSURE_TRAILING_SLASH = 0x020,
    PATHCCH_CANONICALIZE_SLASHES = 0x040,
}
