// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncDDPreferredStereoDownMixMode.xml' path='doc/member[@name="CODECAPI_AVEncDDPreferredStereoDownMixMode"]/*'/>
[Guid("7F4E6B31-9185-403D-B0A2-763743E6F063")]
public unsafe partial struct CODECAPI_AVEncDDPreferredStereoDownMixMode : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncDDPreferredStereoDownMixMode));
}