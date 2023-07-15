// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVDecVideoAcceleration_H264.xml' path='doc/member[@name="CODECAPI_AVDecVideoAcceleration_H264"]/*'/>
[Guid("F7DB8A2F-4F48-4EE8-AE31-8B6EBE558AE2")]
public unsafe partial struct CODECAPI_AVDecVideoAcceleration_H264 : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVDecVideoAcceleration_H264));
}