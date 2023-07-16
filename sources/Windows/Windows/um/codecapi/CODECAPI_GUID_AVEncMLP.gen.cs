// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_GUID_AVEncMLP.xml' path='doc/member[@name="CODECAPI_GUID_AVEncMLP"]/*'/>
[Guid("05F73E29-F0D1-431E-A41C-A47432EC5A66")]
public unsafe partial struct CODECAPI_GUID_AVEncMLP : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_GUID_AVEncMLP));
}