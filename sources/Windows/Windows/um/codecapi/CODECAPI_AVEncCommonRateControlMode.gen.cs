// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_AVEncCommonRateControlMode.xml' path='doc/member[@name="CODECAPI_AVEncCommonRateControlMode"]/*'/>
[Guid("1C0608E9-370C-4710-8A58-CB6181C42423")]
public unsafe partial struct CODECAPI_AVEncCommonRateControlMode : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncCommonRateControlMode));
}