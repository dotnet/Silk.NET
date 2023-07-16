// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_AVEncVideoRateControlParams.xml' path='doc/member[@name="CODECAPI_AVEncVideoRateControlParams"]/*'/>
[Guid("87D43767-7645-44EC-B438-D3322FBCA29F")]
public unsafe partial struct CODECAPI_AVEncVideoRateControlParams : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoRateControlParams));
}