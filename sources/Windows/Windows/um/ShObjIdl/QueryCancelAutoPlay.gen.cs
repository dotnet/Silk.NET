// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='QueryCancelAutoPlay.xml' path='doc/member[@name="QueryCancelAutoPlay"]/*'/>
[Guid("331F1768-05A9-4DDD-B86E-DAE34DDC998A")]
public unsafe partial struct QueryCancelAutoPlay : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_QueryCancelAutoPlay));
}