// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='OnexPlapSmartcardCredentialProvider.xml' path='doc/member[@name="OnexPlapSmartcardCredentialProvider"]/*' />
[Guid("33C86CD6-705F-4BA1-9ADB-67070B837775")]
public unsafe partial struct OnexPlapSmartcardCredentialProvider : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_OnexPlapSmartcardCredentialProvider));
}
