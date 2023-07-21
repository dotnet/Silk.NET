// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='CODECAPI_AVEncSliceControlSize.xml' path='doc/member[@name="CODECAPI_AVEncSliceControlSize"]/*' />
[Guid("92F51DF3-07A5-4172-AEFE-C69CA3B60E35")]
public unsafe partial struct CODECAPI_AVEncSliceControlSize : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncSliceControlSize));
}
