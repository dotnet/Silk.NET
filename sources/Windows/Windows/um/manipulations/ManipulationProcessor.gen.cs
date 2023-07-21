// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows;

/// <include file='ManipulationProcessor.xml' path='doc/member[@name="ManipulationProcessor"]/*' />
[Guid("597D4FB0-47FD-4AFF-89B9-C6CFAE8CF08E")]
public unsafe partial struct ManipulationProcessor : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_ManipulationProcessor));
}
