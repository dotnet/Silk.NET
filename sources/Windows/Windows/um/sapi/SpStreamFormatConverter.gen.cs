// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows;
/// <include file='SpStreamFormatConverter.xml' path='doc/member[@name="SpStreamFormatConverter"]/*'/>
[Guid("7013943A-E2EC-11D2-A086-00C04F8EF9B5")]
public unsafe partial struct SpStreamFormatConverter : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_SpStreamFormatConverter));
}