// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncMPAEnableRedundancyProtection.xml' path='doc/member[@name="CODECAPI_AVEncMPAEnableRedundancyProtection"]/*'/>
[Guid("5E54B09E-B2E7-4973-A89B-0B3650A3BEDA")]
public unsafe partial struct CODECAPI_AVEncMPAEnableRedundancyProtection : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncMPAEnableRedundancyProtection));
}