// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;
/// <include file='MSEnumDiscRecordersObj.xml' path='doc/member[@name="MSEnumDiscRecordersObj"]/*'/>
[Guid("8A03567A-63CB-4BA8-BAF6-52119816D1EF")]
public unsafe partial struct MSEnumDiscRecordersObj : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_MSEnumDiscRecordersObj));
}