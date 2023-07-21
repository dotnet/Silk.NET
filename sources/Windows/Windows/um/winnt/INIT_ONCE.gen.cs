// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='INIT_ONCE.xml' path='doc/member[@name="INIT_ONCE"]/*' />
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct INIT_ONCE
{
    /// <include file='INIT_ONCE.xml' path='doc/member[@name="INIT_ONCE.Ptr"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("PVOID")]
    public void* Ptr;
}
