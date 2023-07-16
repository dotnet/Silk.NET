// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_AVEncMP12PktzStreamID.xml' path='doc/member[@name="CODECAPI_AVEncMP12PktzStreamID"]/*'/>
[Guid("C834D038-F5E8-4408-9B60-88F36493FEDF")]
public unsafe partial struct CODECAPI_AVEncMP12PktzStreamID : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncMP12PktzStreamID));
}