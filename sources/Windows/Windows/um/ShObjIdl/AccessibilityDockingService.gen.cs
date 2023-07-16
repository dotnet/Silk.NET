// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='AccessibilityDockingService.xml' path='doc/member[@name="AccessibilityDockingService"]/*'/>
[Guid("29CE1D46-B481-4AA0-A08A-D3EBC8ACA402")]
public unsafe partial struct AccessibilityDockingService : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_AccessibilityDockingService));
}