// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_GUID_AVEncCommonFormatHighMPV.xml' path='doc/member[@name="CODECAPI_GUID_AVEncCommonFormatHighMPV"]/*'/>
[Guid("A2D25DB8-B8F9-42C2-8BC7-0B93CF604788")]
public unsafe partial struct CODECAPI_GUID_AVEncCommonFormatHighMPV : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_GUID_AVEncCommonFormatHighMPV));
}