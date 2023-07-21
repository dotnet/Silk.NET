// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='CODECAPI_AVEncDDAtoDConverterType.xml' path='doc/member[@name="CODECAPI_AVEncDDAtoDConverterType"]/*' />
[Guid("719F9612-81A1-47E0-9A05-D94AD5FCA948")]
public unsafe partial struct CODECAPI_AVEncDDAtoDConverterType : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncDDAtoDConverterType));
}
