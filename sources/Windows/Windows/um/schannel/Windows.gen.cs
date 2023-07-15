// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SslEmptyCacheA"]/*'/>
    [DllImport("schannel", ExactSpelling = true)]
    public static extern BOOL SslEmptyCacheA([NativeTypeName("LPSTR")] sbyte* pszTargetName, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SslEmptyCacheW"]/*'/>
    [DllImport("schannel", ExactSpelling = true)]
    public static extern BOOL SslEmptyCacheW([NativeTypeName("LPWSTR")] ushort* pszTargetName, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SslCrackCertificate"]/*'/>
    [DllImport("schannel", ExactSpelling = true)]
    public static extern BOOL SslCrackCertificate([NativeTypeName("PUCHAR")] byte* pbCertificate, [NativeTypeName("DWORD")] uint cbCertificate, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PX509Certificate *")] X509Certificate** ppCertificate);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SslFreeCertificate"]/*'/>
    [DllImport("schannel", ExactSpelling = true)]
    public static extern void SslFreeCertificate([NativeTypeName("PX509Certificate")] X509Certificate* pCertificate);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SslGetServerIdentity"]/*'/>
    [DllImport("schannel", ExactSpelling = true)]
    [return: NativeTypeName("SECURITY_STATUS")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int SslGetServerIdentity([NativeTypeName("PBYTE")] byte* ClientHello, [NativeTypeName("DWORD")] uint ClientHelloSize, [NativeTypeName("PBYTE *")] byte** ServerIdentity, [NativeTypeName("PDWORD")] uint* ServerIdentitySize, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SslDeserializeCertificateStore"]/*'/>
    [DllImport("schannel", ExactSpelling = true)]
    [return: NativeTypeName("SECURITY_STATUS")]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern int SslDeserializeCertificateStore([NativeTypeName("CERT_BLOB")] CRYPT_DATA_BLOB SerializedCertificateStore, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppCertContext);
    [NativeTypeName("#define UNISP_NAME_A \"Microsoft Unified Security Protocol Provider\"")]
    public static ReadOnlySpan<byte> UNISP_NAME_A => "Microsoft Unified Security Protocol Provider"u8;

    [NativeTypeName("#define UNISP_NAME_W L\"Microsoft Unified Security Protocol Provider\"")]
    public const string UNISP_NAME_W = "Microsoft Unified Security Protocol Provider";
    [NativeTypeName("#define SSL2SP_NAME_A \"Microsoft SSL 2.0\"")]
    public static ReadOnlySpan<byte> SSL2SP_NAME_A => "Microsoft SSL 2.0"u8;

    [NativeTypeName("#define SSL2SP_NAME_W L\"Microsoft SSL 2.0\"")]
    public const string SSL2SP_NAME_W = "Microsoft SSL 2.0";
    [NativeTypeName("#define SSL3SP_NAME_A \"Microsoft SSL 3.0\"")]
    public static ReadOnlySpan<byte> SSL3SP_NAME_A => "Microsoft SSL 3.0"u8;

    [NativeTypeName("#define SSL3SP_NAME_W L\"Microsoft SSL 3.0\"")]
    public const string SSL3SP_NAME_W = "Microsoft SSL 3.0";
    [NativeTypeName("#define TLS1SP_NAME_A \"Microsoft TLS 1.0\"")]
    public static ReadOnlySpan<byte> TLS1SP_NAME_A => "Microsoft TLS 1.0"u8;

    [NativeTypeName("#define TLS1SP_NAME_W L\"Microsoft TLS 1.0\"")]
    public const string TLS1SP_NAME_W = "Microsoft TLS 1.0";
    [NativeTypeName("#define PCT1SP_NAME_A \"Microsoft PCT 1.0\"")]
    public static ReadOnlySpan<byte> PCT1SP_NAME_A => "Microsoft PCT 1.0"u8;

    [NativeTypeName("#define PCT1SP_NAME_W L\"Microsoft PCT 1.0\"")]
    public const string PCT1SP_NAME_W = "Microsoft PCT 1.0";
    [NativeTypeName("#define UNISP_NAME UNISP_NAME_W")]
    public const string UNISP_NAME = "Microsoft Unified Security Protocol Provider";
    [NativeTypeName("#define PCT1SP_NAME PCT1SP_NAME_W")]
    public const string PCT1SP_NAME = "Microsoft PCT 1.0";
    [NativeTypeName("#define SSL2SP_NAME SSL2SP_NAME_W")]
    public const string SSL2SP_NAME = "Microsoft SSL 2.0";
    [NativeTypeName("#define SSL3SP_NAME SSL3SP_NAME_W")]
    public const string SSL3SP_NAME = "Microsoft SSL 3.0";
    [NativeTypeName("#define TLS1SP_NAME TLS1SP_NAME_W")]
    public const string TLS1SP_NAME = "Microsoft TLS 1.0";
    [NativeTypeName("#define UNISP_RPC_ID 14")]
    public const int UNISP_RPC_ID = 14;
    [NativeTypeName("#define RCRED_STATUS_NOCRED 0x00000000")]
    public const int RCRED_STATUS_NOCRED = 0x00000000;
    [NativeTypeName("#define RCRED_CRED_EXISTS 0x00000001")]
    public const int RCRED_CRED_EXISTS = 0x00000001;
    [NativeTypeName("#define RCRED_STATUS_UNKNOWN_ISSUER 0x00000002")]
    public const int RCRED_STATUS_UNKNOWN_ISSUER = 0x00000002;
    [NativeTypeName("#define LCRED_STATUS_NOCRED 0x00000000")]
    public const int LCRED_STATUS_NOCRED = 0x00000000;
    [NativeTypeName("#define LCRED_CRED_EXISTS 0x00000001")]
    public const int LCRED_CRED_EXISTS = 0x00000001;
    [NativeTypeName("#define LCRED_STATUS_UNKNOWN_ISSUER 0x00000002")]
    public const int LCRED_STATUS_UNKNOWN_ISSUER = 0x00000002;
    [NativeTypeName("#define SECPKGCONTEXT_CONNECTION_INFO_EX_V1 1")]
    public const int SECPKGCONTEXT_CONNECTION_INFO_EX_V1 = 1;
    [NativeTypeName("#define SECPKGCONTEXT_CIPHERINFO_V1 1")]
    public const int SECPKGCONTEXT_CIPHERINFO_V1 = 1;
    [NativeTypeName("#define KERN_CONTEXT_CERT_INFO_V1 0x00000000")]
    public const int KERN_CONTEXT_CERT_INFO_V1 = 0x00000000;
    [NativeTypeName("#define SslEmptyCache SslEmptyCacheW")]
    public static delegate*<ushort*, uint, BOOL> SslEmptyCache => &SslEmptyCacheW;
}