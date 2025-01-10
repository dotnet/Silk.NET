// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SYNCMGR_CONTROL_FLAGS
{
    SYNCMGR_CF_NONE = 0,
    SYNCMGR_CF_NOWAIT = 0,
    SYNCMGR_CF_WAIT = 0x1,
    SYNCMGR_CF_NOUI = 0x2,
    SYNCMGR_CF_VALID = 0x3,
}
