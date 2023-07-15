// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncAACEnableVBR.xml' path='doc/member[@name="CODECAPI_AVEncAACEnableVBR"]/*'/>
[Guid("E836BB98-FCA3-44B6-9A39-24786BE41BE1")]
public unsafe partial struct CODECAPI_AVEncAACEnableVBR : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncAACEnableVBR));
}