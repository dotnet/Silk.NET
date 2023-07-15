// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='SyncMgrScheduleWizard.xml' path='doc/member[@name="SyncMgrScheduleWizard"]/*'/>
[Guid("8D8B8E30-C451-421B-8553-D2976AFA648C")]
public unsafe partial struct SyncMgrScheduleWizard : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_SyncMgrScheduleWizard));
}