// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum SLR_FLAGS
{
    SLR_NONE = 0,
    SLR_NO_UI = 0x1,
    SLR_ANY_MATCH = 0x2,
    SLR_UPDATE = 0x4,
    SLR_NOUPDATE = 0x8,
    SLR_NOSEARCH = 0x10,
    SLR_NOTRACK = 0x20,
    SLR_NOLINKINFO = 0x40,
    SLR_INVOKE_MSI = 0x80,
    SLR_NO_UI_WITH_MSG_PUMP = 0x101,
    SLR_OFFER_DELETE_WITHOUT_FILE = 0x200,
    SLR_KNOWNFOLDER = 0x400,
    SLR_MACHINE_IN_LOCAL_TARGET = 0x800,
    SLR_UPDATE_MACHINE_AND_SID = 0x1000,
    SLR_NO_OBJECT_ID = 0x2000,
}
