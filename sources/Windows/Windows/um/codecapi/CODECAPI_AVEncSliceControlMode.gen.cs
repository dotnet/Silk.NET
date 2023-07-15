// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncSliceControlMode.xml' path='doc/member[@name="CODECAPI_AVEncSliceControlMode"]/*'/>
[Guid("E9E782EF-5F18-44C9-A90B-E9C3C2C17B0B")]
public unsafe partial struct CODECAPI_AVEncSliceControlMode : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncSliceControlMode));
}