// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='HTMLOptionElementFactory.xml' path='doc/member[@name="HTMLOptionElementFactory"]/*'/>
[Guid("3050F38D-98B5-11CF-BB82-00AA00BDCE0B")]
public unsafe partial struct HTMLOptionElementFactory : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_HTMLOptionElementFactory));
}