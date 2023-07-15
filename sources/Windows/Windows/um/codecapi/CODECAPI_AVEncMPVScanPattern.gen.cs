// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncMPVScanPattern.xml' path='doc/member[@name="CODECAPI_AVEncMPVScanPattern"]/*'/>
[Guid("7F8A478E-7BBB-4AE2-B2FC-96D17FC4A2D6")]
public unsafe partial struct CODECAPI_AVEncMPVScanPattern : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncMPVScanPattern));
}