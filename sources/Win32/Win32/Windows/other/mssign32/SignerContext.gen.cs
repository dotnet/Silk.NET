// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <include file='SIGNER_CONTEXT.xml' path='doc/member[@name="SIGNER_CONTEXT"]/*'/>
public unsafe partial struct SignerContext
{
    /// <include file='SIGNER_CONTEXT.xml' path='doc/member[@name="SIGNER_CONTEXT.cbSize"]/*'/>

    [NativeTypeName("DWORD")]
    public uint CbSize;

    /// <include file='SIGNER_CONTEXT.xml' path='doc/member[@name="SIGNER_CONTEXT.cbBlob"]/*'/>

    [NativeTypeName("DWORD")]
    public uint CbBlob;

    /// <include file='SIGNER_CONTEXT.xml' path='doc/member[@name="SIGNER_CONTEXT.pbBlob"]/*'/>

    public byte* PbBlob;
}
