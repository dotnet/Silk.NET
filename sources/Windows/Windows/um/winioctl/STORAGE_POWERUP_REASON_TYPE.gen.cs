// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_POWERUP_REASON_TYPE.xml' path='doc/member[@name="STORAGE_POWERUP_REASON_TYPE"]/*'/>
public enum STORAGE_POWERUP_REASON_TYPE
{
    /// <include file='STORAGE_POWERUP_REASON_TYPE.xml' path='doc/member[@name="STORAGE_POWERUP_REASON_TYPE.StoragePowerupUnknown"]/*'/>
    StoragePowerupUnknown = 0,
    /// <include file='STORAGE_POWERUP_REASON_TYPE.xml' path='doc/member[@name="STORAGE_POWERUP_REASON_TYPE.StoragePowerupIO"]/*'/>
    StoragePowerupIO,
    /// <include file='STORAGE_POWERUP_REASON_TYPE.xml' path='doc/member[@name="STORAGE_POWERUP_REASON_TYPE.StoragePowerupDeviceAttention"]/*'/>
    StoragePowerupDeviceAttention,
}