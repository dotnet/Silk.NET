// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='SpTextSelectionInformation.xml' path='doc/member[@name="SpTextSelectionInformation"]/*'/>
[Guid("0F92030A-CBFD-4AB8-A164-FF5985547FF6")]
public unsafe partial struct SpTextSelectionInformation : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_SpTextSelectionInformation));
}