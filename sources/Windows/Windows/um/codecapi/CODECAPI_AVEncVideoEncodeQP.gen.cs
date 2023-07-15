// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncVideoEncodeQP.xml' path='doc/member[@name="CODECAPI_AVEncVideoEncodeQP"]/*'/>
[Guid("2CB5696B-23FB-4CE1-A0F9-EF5B90FD55CA")]
public unsafe partial struct CODECAPI_AVEncVideoEncodeQP : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoEncodeQP));
}