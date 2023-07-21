// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='CODECAPI_AVEncDDRFPreEmphasisFilter.xml' path='doc/member[@name="CODECAPI_AVEncDDRFPreEmphasisFilter"]/*' />
[Guid("21AF44C0-244E-4F3D-A2CC-3D3068B2E73F")]
public unsafe partial struct CODECAPI_AVEncDDRFPreEmphasisFilter : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncDDRFPreEmphasisFilter));
}
