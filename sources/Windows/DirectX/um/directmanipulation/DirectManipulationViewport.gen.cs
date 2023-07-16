// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.DirectX;
/// <include file='DirectManipulationViewport.xml' path='doc/member[@name="DirectManipulationViewport"]/*'/>
[Guid("34E211B6-3650-4F75-8334-FA359598E1C5")]
public unsafe partial struct DirectManipulationViewport : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_DirectManipulationViewport));
}