// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_AVEncVideoSourceIsBW.xml' path='doc/member[@name="CODECAPI_AVEncVideoSourceIsBW"]/*'/>
[Guid("42FFC49B-1812-4FDC-8D24-7054C521E6EB")]
public unsafe partial struct CODECAPI_AVEncVideoSourceIsBW : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoSourceIsBW));
}