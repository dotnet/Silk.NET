// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='LocalThumbnailCache.xml' path='doc/member[@name="LocalThumbnailCache"]/*'/>
[Guid("50EF4544-AC9F-4A8E-B21B-8A26180DB13F")]
public unsafe partial struct LocalThumbnailCache : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_LocalThumbnailCache));
}