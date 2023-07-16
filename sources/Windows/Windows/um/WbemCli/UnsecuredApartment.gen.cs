// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='UnsecuredApartment.xml' path='doc/member[@name="UnsecuredApartment"]/*'/>
[Guid("49BD2028-1523-11D1-AD79-00C04FD8FDFF")]
public unsafe partial struct UnsecuredApartment : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_UnsecuredApartment));
}