// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='PasswordCredentialProvider.xml' path='doc/member[@name="PasswordCredentialProvider"]/*'/>
[Guid("60B78E88-EAD8-445C-9CFD-0B87F74EA6CD")]
public unsafe partial struct PasswordCredentialProvider : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_PasswordCredentialProvider));
}