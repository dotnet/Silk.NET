// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncLowPowerEncoder.xml' path='doc/member[@name="CODECAPI_AVEncLowPowerEncoder"]/*'/>
[Guid("B668D582-8BAD-4F6A-9141-375A95358B6D")]
public unsafe partial struct CODECAPI_AVEncLowPowerEncoder : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncLowPowerEncoder));
}