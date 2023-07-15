// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncDDSurroundDownMixLevel.xml' path='doc/member[@name="CODECAPI_AVEncDDSurroundDownMixLevel"]/*'/>
[Guid("7B20D6E5-0BCF-4273-A487-506B047997E9")]
public unsafe partial struct CODECAPI_AVEncDDSurroundDownMixLevel : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncDDSurroundDownMixLevel));
}