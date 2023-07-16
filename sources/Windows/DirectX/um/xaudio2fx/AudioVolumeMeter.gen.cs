// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.DirectX;
/// <include file='AudioVolumeMeter.xml' path='doc/member[@name="AudioVolumeMeter"]/*'/>
[Guid("4FC3B166-972A-40CF-BC37-7DB03DB2FBA3")]
public unsafe partial struct AudioVolumeMeter : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_AudioVolumeMeter));
}