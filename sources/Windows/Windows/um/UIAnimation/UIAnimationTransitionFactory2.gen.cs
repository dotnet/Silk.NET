// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;
/// <include file='UIAnimationTransitionFactory2.xml' path='doc/member[@name="UIAnimationTransitionFactory2"]/*'/>
[Guid("84302F97-7F7B-4040-B190-72AC9D18E420")]
public unsafe partial struct UIAnimationTransitionFactory2 : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_UIAnimationTransitionFactory2));
}