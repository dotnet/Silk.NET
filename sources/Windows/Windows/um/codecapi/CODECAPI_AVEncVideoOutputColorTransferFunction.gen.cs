// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='CODECAPI_AVEncVideoOutputColorTransferFunction.xml' path='doc/member[@name="CODECAPI_AVEncVideoOutputColorTransferFunction"]/*' />
[Guid("4A7F884A-EA11-460D-BF57-B88BC75900DE")]
public unsafe partial struct CODECAPI_AVEncVideoOutputColorTransferFunction : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoOutputColorTransferFunction));
}
