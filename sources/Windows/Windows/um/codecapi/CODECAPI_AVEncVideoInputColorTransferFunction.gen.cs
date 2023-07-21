// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='CODECAPI_AVEncVideoInputColorTransferFunction.xml' path='doc/member[@name="CODECAPI_AVEncVideoInputColorTransferFunction"]/*' />
[Guid("8C056111-A9C3-4B08-A0A0-CE13F8A27C75")]
public unsafe partial struct CODECAPI_AVEncVideoInputColorTransferFunction : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoInputColorTransferFunction));
}
