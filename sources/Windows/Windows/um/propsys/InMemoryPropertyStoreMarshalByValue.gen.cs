// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;
/// <include file='InMemoryPropertyStoreMarshalByValue.xml' path='doc/member[@name="InMemoryPropertyStoreMarshalByValue"]/*'/>
[Guid("D4CA0E2D-6DA7-4B75-A97C-5F306F0EAEDC")]
public unsafe partial struct InMemoryPropertyStoreMarshalByValue : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_InMemoryPropertyStoreMarshalByValue));
}