// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ApplicationAssociationRegistration.xml' path='doc/member[@name="ApplicationAssociationRegistration"]/*' />
[Guid("591209C7-767B-42B2-9FBA-44EE4615F2C7")]
public unsafe partial struct ApplicationAssociationRegistration : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ApplicationAssociationRegistration));
}
