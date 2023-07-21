// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='CODECAPI_AVEncVideoNoOfFieldsToEncode.xml' path='doc/member[@name="CODECAPI_AVEncVideoNoOfFieldsToEncode"]/*' />
[Guid("61E4BBE2-4EE0-40E7-80AB-51DDEEBE6291")]
public unsafe partial struct CODECAPI_AVEncVideoNoOfFieldsToEncode : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoNoOfFieldsToEncode));
}
