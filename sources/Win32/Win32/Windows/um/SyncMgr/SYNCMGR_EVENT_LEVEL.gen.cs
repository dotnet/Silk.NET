// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SYNCMGR_EVENT_LEVEL
{
    SYNCMGR_EL_INFORMATION = 1,
    SYNCMGR_EL_WARNING = 2,
    SYNCMGR_EL_ERROR = 3,
    SYNCMGR_EL_MAX = SYNCMGR_EL_ERROR,
}
