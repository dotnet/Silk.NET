// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncDDChannelBWLowPassFilter.xml' path='doc/member[@name="CODECAPI_AVEncDDChannelBWLowPassFilter"]/*'/>
[Guid("E197821D-D2E7-43E2-AD2C-00582F518545")]
public unsafe partial struct CODECAPI_AVEncDDChannelBWLowPassFilter : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncDDChannelBWLowPassFilter));
}