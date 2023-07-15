// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_AVEncMPVSceneDetection.xml' path='doc/member[@name="CODECAPI_AVEncMPVSceneDetection"]/*'/>
[Guid("552799F1-DB4C-405B-8A3A-C93F2D0674DC")]
public unsafe partial struct CODECAPI_AVEncMPVSceneDetection : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncMPVSceneDetection));
}