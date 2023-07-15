// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVDecDDDynamicRangeScaleLow.xml' path='doc/member[@name="CODECAPI_AVDecDDDynamicRangeScaleLow"]/*'/>
[Guid("044E62E4-11A5-42D5-A3B2-3BB2C7C2D7CF")]
public unsafe partial struct CODECAPI_AVDecDDDynamicRangeScaleLow : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVDecDDDynamicRangeScaleLow));
}