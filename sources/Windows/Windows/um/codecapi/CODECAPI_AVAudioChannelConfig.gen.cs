// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_AVAudioChannelConfig.xml' path='doc/member[@name="CODECAPI_AVAudioChannelConfig"]/*'/>
[Guid("17F89CB3-C38D-4368-9EDE-63B94D177F9F")]
public unsafe partial struct CODECAPI_AVAudioChannelConfig : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVAudioChannelConfig));
}