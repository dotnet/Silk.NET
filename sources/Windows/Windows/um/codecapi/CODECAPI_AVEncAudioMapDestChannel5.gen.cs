// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncAudioMapDestChannel5.xml' path='doc/member[@name="CODECAPI_AVEncAudioMapDestChannel5"]/*'/>
[Guid("BC5D0B65-DF6A-4E16-9803-B82007A30C8D")]
public unsafe partial struct CODECAPI_AVEncAudioMapDestChannel5 : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncAudioMapDestChannel5));
}