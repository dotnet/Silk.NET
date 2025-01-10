// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SYNCMGR_PRESENTER_NEXT_STEP
{
    SYNCMGR_PNS_CONTINUE = 0,
    SYNCMGR_PNS_DEFAULT = (SYNCMGR_PNS_CONTINUE + 1),
    SYNCMGR_PNS_CANCEL = (SYNCMGR_PNS_DEFAULT + 1),
}
