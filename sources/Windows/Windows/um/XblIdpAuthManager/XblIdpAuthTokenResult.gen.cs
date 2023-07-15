// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;
/// <include file='XblIdpAuthTokenResult.xml' path='doc/member[@name="XblIdpAuthTokenResult"]/*'/>
[Guid("9F493441-744A-410C-AE2B-9A22F7C7731F")]
public unsafe partial struct XblIdpAuthTokenResult : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_XblIdpAuthTokenResult));
}