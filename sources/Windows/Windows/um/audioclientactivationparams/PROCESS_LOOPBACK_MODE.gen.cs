// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audioclientactivationparams.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='PROCESS_LOOPBACK_MODE.xml' path='doc/member[@name="PROCESS_LOOPBACK_MODE"]/*'/>
[SupportedOSPlatform("windows10.0.19043.0")]
public enum PROCESS_LOOPBACK_MODE
{
    /// <include file='PROCESS_LOOPBACK_MODE.xml' path='doc/member[@name="PROCESS_LOOPBACK_MODE.PROCESS_LOOPBACK_MODE_INCLUDE_TARGET_PROCESS_TREE"]/*'/>
    PROCESS_LOOPBACK_MODE_INCLUDE_TARGET_PROCESS_TREE = 0,
    /// <include file='PROCESS_LOOPBACK_MODE.xml' path='doc/member[@name="PROCESS_LOOPBACK_MODE.PROCESS_LOOPBACK_MODE_EXCLUDE_TARGET_PROCESS_TREE"]/*'/>
    PROCESS_LOOPBACK_MODE_EXCLUDE_TARGET_PROCESS_TREE = 1,
}