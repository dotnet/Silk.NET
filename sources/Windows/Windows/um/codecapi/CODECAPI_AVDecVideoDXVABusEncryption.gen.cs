// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_AVDecVideoDXVABusEncryption.xml' path='doc/member[@name="CODECAPI_AVDecVideoDXVABusEncryption"]/*'/>
[Guid("42153C8B-FD0B-4765-A462-DDD9E8BCC388")]
public unsafe partial struct CODECAPI_AVDecVideoDXVABusEncryption : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVDecVideoDXVABusEncryption));
}