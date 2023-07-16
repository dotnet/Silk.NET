// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='V1WinBioCredentialProvider.xml' path='doc/member[@name="V1WinBioCredentialProvider"]/*'/>
[Guid("AC3AC249-E820-4343-A65B-377AC634DC09")]
public unsafe partial struct V1WinBioCredentialProvider : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_V1WinBioCredentialProvider));
}