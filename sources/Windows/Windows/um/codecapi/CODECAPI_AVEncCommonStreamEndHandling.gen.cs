// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='CODECAPI_AVEncCommonStreamEndHandling.xml' path='doc/member[@name="CODECAPI_AVEncCommonStreamEndHandling"]/*' />
[Guid("6AAD30AF-6BA8-4CCC-8FCA-18D19BEAEB1C")]
public unsafe partial struct CODECAPI_AVEncCommonStreamEndHandling : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncCommonStreamEndHandling));
}
