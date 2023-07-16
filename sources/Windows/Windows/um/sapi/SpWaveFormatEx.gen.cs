// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows;
/// <include file='SpWaveFormatEx.xml' path='doc/member[@name="SpWaveFormatEx"]/*'/>
[Guid("C79A574C-63BE-44B9-801F-283F87F898BE")]
public unsafe partial struct SpWaveFormatEx : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_SpWaveFormatEx));
}