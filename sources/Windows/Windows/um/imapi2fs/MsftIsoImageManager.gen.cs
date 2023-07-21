// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows;

/// <include file='MsftIsoImageManager.xml' path='doc/member[@name="MsftIsoImageManager"]/*' />
[Guid("CEEE3B62-8F56-4056-869B-EF16917E3EFC")]
public unsafe partial struct MsftIsoImageManager : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_MsftIsoImageManager));
}
