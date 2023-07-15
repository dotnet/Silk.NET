// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_GUID_AVDecAudioInputDTS.xml' path='doc/member[@name="CODECAPI_GUID_AVDecAudioInputDTS"]/*'/>
[Guid("600BC0CA-6A1F-4E91-B241-1BBEB1CB19E0")]
public unsafe partial struct CODECAPI_GUID_AVDecAudioInputDTS : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_GUID_AVDecAudioInputDTS));
}