// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='NetworkExplorerFolder.xml' path='doc/member[@name="NetworkExplorerFolder"]/*'/>
[Guid("F02C1A0D-BE21-4350-88B0-7367FC96EF3C")]
public unsafe partial struct NetworkExplorerFolder : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_NetworkExplorerFolder));
}