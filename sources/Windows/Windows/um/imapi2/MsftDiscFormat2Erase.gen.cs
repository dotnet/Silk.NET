// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows;
/// <include file='MsftDiscFormat2Erase.xml' path='doc/member[@name="MsftDiscFormat2Erase"]/*'/>
[Guid("2735412B-7F64-5B0F-8F00-5D77AFBE261E")]
public unsafe partial struct MsftDiscFormat2Erase : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_MsftDiscFormat2Erase));
}