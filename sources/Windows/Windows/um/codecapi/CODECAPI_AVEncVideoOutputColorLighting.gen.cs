// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_AVEncVideoOutputColorLighting.xml' path='doc/member[@name="CODECAPI_AVEncVideoOutputColorLighting"]/*'/>
[Guid("0E5AAAC6-ACE6-4C5C-998E-1A8C9C6C0F89")]
public unsafe partial struct CODECAPI_AVEncVideoOutputColorLighting : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoOutputColorLighting));
}