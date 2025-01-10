// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum TYSPEC
{
    TYSPEC_CLSID = 0,
    TYSPEC_FILEEXT = (TYSPEC_CLSID + 1),
    TYSPEC_MIMETYPE = (TYSPEC_FILEEXT + 1),
    TYSPEC_FILENAME = (TYSPEC_MIMETYPE + 1),
    TYSPEC_PROGID = (TYSPEC_FILENAME + 1),
    TYSPEC_PACKAGENAME = (TYSPEC_PROGID + 1),
    TYSPEC_OBJECTID = (TYSPEC_PACKAGENAME + 1),
}
