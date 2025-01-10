// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PUBAPPINFOFLAGS
{
    PAI_SOURCE = 0x1,
    PAI_ASSIGNEDTIME = 0x2,
    PAI_PUBLISHEDTIME = 0x4,
    PAI_SCHEDULEDTIME = 0x8,
    PAI_EXPIRETIME = 0x10,
}
