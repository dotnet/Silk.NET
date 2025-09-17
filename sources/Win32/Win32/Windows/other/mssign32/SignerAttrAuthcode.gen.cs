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
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <include file='SIGNER_ATTR_AUTHCODE.xml' path='doc/member[@name="SIGNER_ATTR_AUTHCODE"]/*'/>
public unsafe partial struct SignerAttrAuthcode
{
    /// <include file='SIGNER_ATTR_AUTHCODE.xml' path='doc/member[@name="SIGNER_ATTR_AUTHCODE.cbSize"]/*'/>

    [NativeTypeName("DWORD")]
    public uint CbSize;

    /// <include file='SIGNER_ATTR_AUTHCODE.xml' path='doc/member[@name="SIGNER_ATTR_AUTHCODE.fCommercial"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> FCommercial;

    /// <include file='SIGNER_ATTR_AUTHCODE.xml' path='doc/member[@name="SIGNER_ATTR_AUTHCODE.fIndividual"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> FIndividual;

    /// <include file='SIGNER_ATTR_AUTHCODE.xml' path='doc/member[@name="SIGNER_ATTR_AUTHCODE.pwszName"]/*'/>

    [NativeTypeName("LPCWSTR")]
    public ushort* PwszName;

    /// <include file='SIGNER_ATTR_AUTHCODE.xml' path='doc/member[@name="SIGNER_ATTR_AUTHCODE.pwszInfo"]/*'/>

    [NativeTypeName("LPCWSTR")]
    public ushort* PwszInfo;
}
