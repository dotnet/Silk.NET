// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='CODECAPI_AVEncDDDCHighPassFilter.xml' path='doc/member[@name="CODECAPI_AVEncDDDCHighPassFilter"]/*' />
[Guid("9565239F-861C-4AC8-BFDA-E00CB4DB8548")]
public unsafe partial struct CODECAPI_AVEncDDDCHighPassFilter : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncDDDCHighPassFilter));
}
