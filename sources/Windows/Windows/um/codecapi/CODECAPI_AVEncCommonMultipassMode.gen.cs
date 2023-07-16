// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_AVEncCommonMultipassMode.xml' path='doc/member[@name="CODECAPI_AVEncCommonMultipassMode"]/*'/>
[Guid("22533D4C-47E1-41B5-9352-A2B7780E7AC4")]
public unsafe partial struct CODECAPI_AVEncCommonMultipassMode : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncCommonMultipassMode));
}