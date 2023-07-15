// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncDDCentreDownMixLevel.xml' path='doc/member[@name="CODECAPI_AVEncDDCentreDownMixLevel"]/*'/>
[Guid("E285072C-C958-4A81-AFD2-E5E0DAF1B148")]
public unsafe partial struct CODECAPI_AVEncDDCentreDownMixLevel : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncDDCentreDownMixLevel));
}