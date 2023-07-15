// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncVideoInstantTemporalUpSwitching.xml' path='doc/member[@name="CODECAPI_AVEncVideoInstantTemporalUpSwitching"]/*'/>
[Guid("A3308307-0D96-4BA4-B1F0-B91A5E49DF10")]
public unsafe partial struct CODECAPI_AVEncVideoInstantTemporalUpSwitching : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoInstantTemporalUpSwitching));
}