// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;
/// <include file='XMLHTTPRequest.xml' path='doc/member[@name="XMLHTTPRequest"]/*'/>
[Guid("ED8C108E-4349-11D2-91A4-00C04F7969E8")]
public unsafe partial struct XMLHTTPRequest : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_XMLHTTPRequest));
}