// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGE_PROLOGUE_DYNAMIC_RELOCATION_HEADER.xml' path='doc/member[@name="IMAGE_PROLOGUE_DYNAMIC_RELOCATION_HEADER"]/*' />
public partial struct IMAGE_PROLOGUE_DYNAMIC_RELOCATION_HEADER
{
    /// <include file='IMAGE_PROLOGUE_DYNAMIC_RELOCATION_HEADER.xml' path='doc/member[@name="IMAGE_PROLOGUE_DYNAMIC_RELOCATION_HEADER.PrologueByteCount"]/*' />
    public byte PrologueByteCount;
}
