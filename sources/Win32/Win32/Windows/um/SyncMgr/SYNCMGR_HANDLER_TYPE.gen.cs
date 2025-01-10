// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SYNCMGR_HANDLER_TYPE
{
    SYNCMGR_HT_UNSPECIFIED = 0,
    SYNCMGR_HT_APPLICATION = 1,
    SYNCMGR_HT_DEVICE = 2,
    SYNCMGR_HT_FOLDER = 3,
    SYNCMGR_HT_SERVICE = 4,
    SYNCMGR_HT_COMPUTER = 5,
    SYNCMGR_HT_MIN = 0,
    SYNCMGR_HT_MAX = SYNCMGR_HT_COMPUTER,
}
