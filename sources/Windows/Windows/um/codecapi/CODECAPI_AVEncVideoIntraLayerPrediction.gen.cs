// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncVideoIntraLayerPrediction.xml' path='doc/member[@name="CODECAPI_AVEncVideoIntraLayerPrediction"]/*'/>
[Guid("D3AF46B8-BF47-44BB-A283-69F0B0228FF9")]
public unsafe partial struct CODECAPI_AVEncVideoIntraLayerPrediction : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoIntraLayerPrediction));
}