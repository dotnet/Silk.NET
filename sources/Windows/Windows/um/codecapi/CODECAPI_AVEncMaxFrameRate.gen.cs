// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncMaxFrameRate.xml' path='doc/member[@name="CODECAPI_AVEncMaxFrameRate"]/*'/>
[Guid("B98E1B31-19FA-4D4F-9931-D6A5B8AAB93C")]
public unsafe partial struct CODECAPI_AVEncMaxFrameRate : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncMaxFrameRate));
}