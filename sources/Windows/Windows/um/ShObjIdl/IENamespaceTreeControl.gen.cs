// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IENamespaceTreeControl.xml' path='doc/member[@name="IENamespaceTreeControl"]/*'/>
[Guid("ACE52D03-E5CD-4B20-82FF-E71B11BEAE1D")]
public unsafe partial struct IENamespaceTreeControl : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IENamespaceTreeControl));
}