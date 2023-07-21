// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='VIRTUAL_STORAGE_BEHAVIOR_CODE.xml' path='doc/member[@name="VIRTUAL_STORAGE_BEHAVIOR_CODE"]/*' />
public enum VIRTUAL_STORAGE_BEHAVIOR_CODE
{
    /// <include file='VIRTUAL_STORAGE_BEHAVIOR_CODE.xml' path='doc/member[@name="VIRTUAL_STORAGE_BEHAVIOR_CODE.VirtualStorageBehaviorUndefined"]/*' />
    VirtualStorageBehaviorUndefined = 0,

    /// <include file='VIRTUAL_STORAGE_BEHAVIOR_CODE.xml' path='doc/member[@name="VIRTUAL_STORAGE_BEHAVIOR_CODE.VirtualStorageBehaviorCacheWriteThrough"]/*' />
    VirtualStorageBehaviorCacheWriteThrough = 1,

    /// <include file='VIRTUAL_STORAGE_BEHAVIOR_CODE.xml' path='doc/member[@name="VIRTUAL_STORAGE_BEHAVIOR_CODE.VirtualStorageBehaviorCacheWriteBack"]/*' />
    VirtualStorageBehaviorCacheWriteBack = 2,

    /// <include file='VIRTUAL_STORAGE_BEHAVIOR_CODE.xml' path='doc/member[@name="VIRTUAL_STORAGE_BEHAVIOR_CODE.VirtualStorageBehaviorStopIoProcessing"]/*' />
    VirtualStorageBehaviorStopIoProcessing = 3,

    /// <include file='VIRTUAL_STORAGE_BEHAVIOR_CODE.xml' path='doc/member[@name="VIRTUAL_STORAGE_BEHAVIOR_CODE.VirtualStorageBehaviorRestartIoProcessing"]/*' />
    VirtualStorageBehaviorRestartIoProcessing = 4,
}
