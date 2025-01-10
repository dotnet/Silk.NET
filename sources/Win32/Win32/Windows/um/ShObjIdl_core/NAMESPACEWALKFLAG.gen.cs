// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum NAMESPACEWALKFLAG
{
    NSWF_DEFAULT = 0,
    NSWF_NONE_IMPLIES_ALL = 0x1,
    NSWF_ONE_IMPLIES_ALL = 0x2,
    NSWF_DONT_TRAVERSE_LINKS = 0x4,
    NSWF_DONT_ACCUMULATE_RESULT = 0x8,
    NSWF_TRAVERSE_STREAM_JUNCTIONS = 0x10,
    NSWF_FILESYSTEM_ONLY = 0x20,
    NSWF_SHOW_PROGRESS = 0x40,
    NSWF_FLAG_VIEWORDER = 0x80,
    NSWF_IGNORE_AUTOPLAY_HIDA = 0x100,
    NSWF_ASYNC = 0x200,
    NSWF_DONT_RESOLVE_LINKS = 0x400,
    NSWF_ACCUMULATE_FOLDERS = 0x800,
    NSWF_DONT_SORT = 0x1000,
    NSWF_USE_TRANSFER_MEDIUM = 0x2000,
    NSWF_DONT_TRAVERSE_STREAM_JUNCTIONS = 0x4000,
    NSWF_ANY_IMPLIES_ALL = 0x8000,
}
