// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_AVEncVideoPixelAspectRatio.xml' path='doc/member[@name="CODECAPI_AVEncVideoPixelAspectRatio"]/*'/>
[Guid("3CDC718F-B3E9-4EB6-A57F-CF1F1B321B87")]
public unsafe partial struct CODECAPI_AVEncVideoPixelAspectRatio : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoPixelAspectRatio));
}