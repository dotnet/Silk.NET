// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows;
/// <include file='MSDiscRecorderObj.xml' path='doc/member[@name="MSDiscRecorderObj"]/*'/>
[Guid("520CCA61-51A5-11D3-9144-00104BA11C5E")]
public unsafe partial struct MSDiscRecorderObj : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_MSDiscRecorderObj));
}