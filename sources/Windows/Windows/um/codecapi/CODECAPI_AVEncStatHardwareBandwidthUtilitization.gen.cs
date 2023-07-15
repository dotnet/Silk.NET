// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncStatHardwareBandwidthUtilitization.xml' path='doc/member[@name="CODECAPI_AVEncStatHardwareBandwidthUtilitization"]/*'/>
[Guid("0124BA9B-DC41-4826-B45F-18AC01B3D5A8")]
public unsafe partial struct CODECAPI_AVEncStatHardwareBandwidthUtilitization : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncStatHardwareBandwidthUtilitization));
}