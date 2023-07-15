// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='SimpleConflictPresenter.xml' path='doc/member[@name="SimpleConflictPresenter"]/*'/>
[Guid("7A0F6AB7-ED84-46B6-B47E-02AA159A152B")]
public unsafe partial struct SimpleConflictPresenter : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_SimpleConflictPresenter));
}