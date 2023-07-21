// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='CODECAPI_AVEncMPVGOPSInSeq.xml' path='doc/member[@name="CODECAPI_AVEncMPVGOPSInSeq"]/*' />
[Guid("993410D4-2691-4192-9978-98DC2603669F")]
public unsafe partial struct CODECAPI_AVEncMPVGOPSInSeq : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncMPVGOPSInSeq));
}
