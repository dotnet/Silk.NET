// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum ASSOCDATA
{
    ASSOCDATA_MSIDESCRIPTOR = 1,
    ASSOCDATA_NOACTIVATEHANDLER,
    ASSOCDATA_UNUSED1,
    ASSOCDATA_HASPERUSERASSOC,
    ASSOCDATA_EDITFLAGS,
    ASSOCDATA_VALUE,
    ASSOCDATA_MAX,
}
