// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='InternetExplorerMedium.xml' path='doc/member[@name="InternetExplorerMedium"]/*' />
[Guid("D5E8041D-920F-45E9-B8FB-B1DEB82C6E5E")]
public unsafe partial struct InternetExplorerMedium : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_InternetExplorerMedium));
}
