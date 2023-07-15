// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncMPVQScaleType.xml' path='doc/member[@name="CODECAPI_AVEncMPVQScaleType"]/*'/>
[Guid("2B79EBB7-F484-4AF7-BB58-A2A188C5CBBE")]
public unsafe partial struct CODECAPI_AVEncMPVQScaleType : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncMPVQScaleType));
}