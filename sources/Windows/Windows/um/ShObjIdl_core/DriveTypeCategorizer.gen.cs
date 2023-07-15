// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='DriveTypeCategorizer.xml' path='doc/member[@name="DriveTypeCategorizer"]/*'/>
[Guid("B0A8F3CF-4333-4BAB-8873-1CCB1CADA48B")]
public unsafe partial struct DriveTypeCategorizer : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_DriveTypeCategorizer));
}