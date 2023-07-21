// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='CODECAPI_AVEncVideoMaxCTBSize.xml' path='doc/member[@name="CODECAPI_AVEncVideoMaxCTBSize"]/*' />
[Guid("822363FF-CEC8-43E5-92FD-E097488485E9")]
public unsafe partial struct CODECAPI_AVEncVideoMaxCTBSize : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoMaxCTBSize));
}
