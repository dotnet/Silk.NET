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

public static partial class Signer
{
    [NativeTypeName("#define SIGNER_SUBJECT_FILE 0x01")]
    public const int SubjectFile = 0x01;

    [NativeTypeName("#define SIGNER_SUBJECT_BLOB 0x02")]
    public const int SubjectBlob = 0x02;

    [NativeTypeName("#define SIGNER_NO_ATTR 0x00")]
    public const int NoAttr = 0x00;

    [NativeTypeName("#define SIGNER_AUTHCODE_ATTR 0x01")]
    public const int AuthcodeAttr = 0x01;

    [NativeTypeName("#define SIGNER_CERT_POLICY_STORE 0x01")]
    public const int CertPolicyStore = 0x01;

    [NativeTypeName("#define SIGNER_CERT_POLICY_CHAIN 0x02")]
    public const int CertPolicyChain = 0x02;

    [NativeTypeName("#define SIGNER_CERT_POLICY_SPC 0x04")]
    public const int CertPolicySpc = 0x04;

    [NativeTypeName("#define SIGNER_CERT_POLICY_CHAIN_NO_ROOT 0x08")]
    public const int CertPolicyChainNoRoot = 0x08;

    [NativeTypeName("#define SIGNER_CERT_SPC_FILE 0x01")]
    public const int CertSpcFile = 0x01;

    [NativeTypeName("#define SIGNER_CERT_STORE 0x02")]
    public const int CertStore = 0x02;

    [NativeTypeName("#define SIGNER_CERT_SPC_CHAIN 0x03")]
    public const int CertSpcChain = 0x03;
}
