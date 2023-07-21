// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows;

/// <include file='XblIdpAuthManager.xml' path='doc/member[@name="XblIdpAuthManager"]/*' />
[Guid("CE23534B-56D8-4978-86A2-7EE570640468")]
public unsafe partial struct XblIdpAuthManager : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_XblIdpAuthManager));
}
