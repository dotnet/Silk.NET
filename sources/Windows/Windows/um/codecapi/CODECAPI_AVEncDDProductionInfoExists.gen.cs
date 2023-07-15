// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncDDProductionInfoExists.xml' path='doc/member[@name="CODECAPI_AVEncDDProductionInfoExists"]/*'/>
[Guid("B0B7FE5F-B6AB-4F40-964D-8D91F17C19E8")]
public unsafe partial struct CODECAPI_AVEncDDProductionInfoExists : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncDDProductionInfoExists));
}