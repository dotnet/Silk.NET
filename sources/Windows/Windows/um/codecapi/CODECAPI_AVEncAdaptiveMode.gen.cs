// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_AVEncAdaptiveMode.xml' path='doc/member[@name="CODECAPI_AVEncAdaptiveMode"]/*'/>
[Guid("4419B185-DA1F-4F53-BC76-097D0C1EFB1E")]
public unsafe partial struct CODECAPI_AVEncAdaptiveMode : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncAdaptiveMode));
}