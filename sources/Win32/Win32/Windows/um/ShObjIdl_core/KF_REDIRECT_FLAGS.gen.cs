// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum KF_REDIRECT_FLAGS
{
    KF_REDIRECT_USER_EXCLUSIVE = 0x1,
    KF_REDIRECT_COPY_SOURCE_DACL = 0x2,
    KF_REDIRECT_OWNER_USER = 0x4,
    KF_REDIRECT_SET_OWNER_EXPLICIT = 0x8,
    KF_REDIRECT_CHECK_ONLY = 0x10,
    KF_REDIRECT_WITH_UI = 0x20,
    KF_REDIRECT_UNPIN = 0x40,
    KF_REDIRECT_PIN = 0x80,
    KF_REDIRECT_COPY_CONTENTS = 0x200,
    KF_REDIRECT_DEL_SOURCE_CONTENTS = 0x400,
    KF_REDIRECT_EXCLUDE_ALL_KNOWN_SUBFOLDERS = 0x800,
}
