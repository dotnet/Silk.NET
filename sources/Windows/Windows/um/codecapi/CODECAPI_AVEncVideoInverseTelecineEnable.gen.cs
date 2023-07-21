// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='CODECAPI_AVEncVideoInverseTelecineEnable.xml' path='doc/member[@name="CODECAPI_AVEncVideoInverseTelecineEnable"]/*' />
[Guid("2EA9098B-E76D-4CCD-A030-D3B889C1B64C")]
public unsafe partial struct CODECAPI_AVEncVideoInverseTelecineEnable : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoInverseTelecineEnable));
}
