// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.DirectX;

/// <include file='DirectManipulationPrimaryContent.xml' path='doc/member[@name="DirectManipulationPrimaryContent"]/*' />
[Guid("CAA02661-D59E-41C7-8393-3BA3BACB6B57")]
public unsafe partial struct DirectManipulationPrimaryContent : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_DirectManipulationPrimaryContent));
}
