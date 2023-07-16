// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows;
/// <include file='UIAnimationTransitionFactory.xml' path='doc/member[@name="UIAnimationTransitionFactory"]/*'/>
[Guid("8A9B1CDD-FCD7-419C-8B44-42FD17DB1887")]
public unsafe partial struct UIAnimationTransitionFactory : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_UIAnimationTransitionFactory));
}