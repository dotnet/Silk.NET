// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='EnumerableObjectCollection.xml' path='doc/member[@name="EnumerableObjectCollection"]/*'/>
[Guid("2D3468C1-36A7-43B6-AC24-D3F02FD9607A")]
public unsafe partial struct EnumerableObjectCollection : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_EnumerableObjectCollection));
}