// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_GUID_AVEndMPEG4Video.xml' path='doc/member[@name="CODECAPI_GUID_AVEndMPEG4Video"]/*'/>
[Guid("DD37B12A-9503-4F8B-B8D0-324A00C0A1CF")]
public unsafe partial struct CODECAPI_GUID_AVEndMPEG4Video : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_GUID_AVEndMPEG4Video));
}