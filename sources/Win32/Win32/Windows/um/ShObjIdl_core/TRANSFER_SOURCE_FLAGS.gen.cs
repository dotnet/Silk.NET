// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum TRANSFER_SOURCE_FLAGS
{
    TSF_NORMAL = 0,
    TSF_FAIL_EXIST = 0,
    TSF_RENAME_EXIST = 0x1,
    TSF_OVERWRITE_EXIST = 0x2,
    TSF_ALLOW_DECRYPTION = 0x4,
    TSF_NO_SECURITY = 0x8,
    TSF_COPY_CREATION_TIME = 0x10,
    TSF_COPY_WRITE_TIME = 0x20,
    TSF_USE_FULL_ACCESS = 0x40,
    TSF_DELETE_RECYCLE_IF_POSSIBLE = 0x80,
    TSF_COPY_HARD_LINK = 0x100,
    TSF_COPY_LOCALIZED_NAME = 0x200,
    TSF_MOVE_AS_COPY_DELETE = 0x400,
    TSF_SUSPEND_SHELLEVENTS = 0x800,
}
