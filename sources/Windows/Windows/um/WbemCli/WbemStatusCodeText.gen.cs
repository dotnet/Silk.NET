// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='WbemStatusCodeText.xml' path='doc/member[@name="WbemStatusCodeText"]/*'/>
[Guid("EB87E1BD-3233-11D2-AEC9-00C04FB68820")]
public unsafe partial struct WbemStatusCodeText : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_WbemStatusCodeText));
}