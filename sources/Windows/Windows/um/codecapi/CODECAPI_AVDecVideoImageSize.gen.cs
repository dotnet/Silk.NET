// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='CODECAPI_AVDecVideoImageSize.xml' path='doc/member[@name="CODECAPI_AVDecVideoImageSize"]/*' />
[Guid("5EE5747C-6801-4CAB-AAF1-6248FA841BA4")]
public unsafe partial struct CODECAPI_AVDecVideoImageSize : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVDecVideoImageSize));
}
