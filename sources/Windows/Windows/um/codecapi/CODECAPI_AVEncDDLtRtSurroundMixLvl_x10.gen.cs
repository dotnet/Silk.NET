// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncDDLtRtSurroundMixLvl_x10.xml' path='doc/member[@name="CODECAPI_AVEncDDLtRtSurroundMixLvl_x10"]/*'/>
[Guid("212246C7-3D2C-4DFA-BC21-652A9098690D")]
public unsafe partial struct CODECAPI_AVEncDDLtRtSurroundMixLvl_x10 : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncDDLtRtSurroundMixLvl_x10));
}