// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows;
/// <include file='PrintDocumentPackageTarget.xml' path='doc/member[@name="PrintDocumentPackageTarget"]/*'/>
[Guid("4842669E-9947-46EA-8BA2-D8CCE432C2CA")]
public unsafe partial struct PrintDocumentPackageTarget : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_PrintDocumentPackageTarget));
}