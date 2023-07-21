// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows;

/// <include file='SpSharedRecognizer.xml' path='doc/member[@name="SpSharedRecognizer"]/*' />
[Guid("3BEE4890-4FE9-4A37-8C1E-5E7E12791C1F")]
public unsafe partial struct SpSharedRecognizer : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_SpSharedRecognizer));
}
