// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='RM_SHUTDOWN_TYPE.xml' path='doc/member[@name="RM_SHUTDOWN_TYPE"]/*'/>
[Flags]
public enum RM_SHUTDOWN_TYPE
{
    /// <include file='RM_SHUTDOWN_TYPE.xml' path='doc/member[@name="RM_SHUTDOWN_TYPE.RmForceShutdown"]/*'/>
    RmForceShutdown = 0x1,
    /// <include file='RM_SHUTDOWN_TYPE.xml' path='doc/member[@name="RM_SHUTDOWN_TYPE.RmShutdownOnlyRegistered"]/*'/>
    RmShutdownOnlyRegistered = 0x10,
}