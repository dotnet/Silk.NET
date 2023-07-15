// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVDecSoftwareDynamicFormatChange.xml' path='doc/member[@name="CODECAPI_AVDecSoftwareDynamicFormatChange"]/*'/>
[Guid("862E2F0A-507B-47FF-AF47-01E2624298B7")]
public unsafe partial struct CODECAPI_AVDecSoftwareDynamicFormatChange : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVDecSoftwareDynamicFormatChange));
}