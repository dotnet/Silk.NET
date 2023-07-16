// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_AVDecVideoThumbnailGenerationMode.xml' path='doc/member[@name="CODECAPI_AVDecVideoThumbnailGenerationMode"]/*'/>
[Guid("2EFD8EEE-1150-4328-9CF5-66DCE933FCF4")]
public unsafe partial struct CODECAPI_AVDecVideoThumbnailGenerationMode : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVDecVideoThumbnailGenerationMode));
}