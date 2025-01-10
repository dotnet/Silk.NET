// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum APPACTIONFLAGS
{
    APPACTION_INSTALL = 0x1,
    APPACTION_UNINSTALL = 0x2,
    APPACTION_MODIFY = 0x4,
    APPACTION_REPAIR = 0x8,
    APPACTION_UPGRADE = 0x10,
    APPACTION_CANGETSIZE = 0x20,
    APPACTION_MODIFYREMOVE = 0x80,
    APPACTION_ADDLATER = 0x100,
    APPACTION_UNSCHEDULE = 0x200,
}
