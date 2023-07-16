// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows;
/// <include file='SpNullPhoneConverter.xml' path='doc/member[@name="SpNullPhoneConverter"]/*'/>
[Guid("455F24E9-7396-4A16-9715-7C0FDBE3EFE3")]
public unsafe partial struct SpNullPhoneConverter : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_SpNullPhoneConverter));
}