// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows;
/// <include file='PrintDocumentPackageTargetFactory.xml' path='doc/member[@name="PrintDocumentPackageTargetFactory"]/*'/>
[Guid("348EF17D-6C81-4982-92B4-EE188A43867A")]
public unsafe partial struct PrintDocumentPackageTargetFactory : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_PrintDocumentPackageTargetFactory));
}