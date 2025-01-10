// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SYNCMGR_PROGRESS_STATUS
{
    SYNCMGR_PS_UPDATING = 1,
    SYNCMGR_PS_UPDATING_INDETERMINATE = 2,
    SYNCMGR_PS_SUCCEEDED = 3,
    SYNCMGR_PS_FAILED = 4,
    SYNCMGR_PS_CANCELED = 5,
    SYNCMGR_PS_DISCONNECTED = 6,
    SYNCMGR_PS_MAX = SYNCMGR_PS_DISCONNECTED,
}
