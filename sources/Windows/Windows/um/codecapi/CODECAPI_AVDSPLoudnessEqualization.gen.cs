// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='CODECAPI_AVDSPLoudnessEqualization.xml' path='doc/member[@name="CODECAPI_AVDSPLoudnessEqualization"]/*' />
[Guid("8AFD1A15-1812-4CBF-9319-433A5B2A3B27")]
public unsafe partial struct CODECAPI_AVDSPLoudnessEqualization : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVDSPLoudnessEqualization));
}
