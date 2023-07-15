// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_GUID_AVEncDTS.xml' path='doc/member[@name="CODECAPI_GUID_AVEncDTS"]/*'/>
[Guid("45FBCAA2-5E6E-4AB0-8893-5903BEE93ACF")]
public unsafe partial struct CODECAPI_GUID_AVEncDTS : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_GUID_AVEncDTS));
}