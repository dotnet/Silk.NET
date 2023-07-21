// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/davclnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DavAddConnection"]/*' />
    [DllImport("netapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DavAddConnection(HANDLE* ConnectionHandle, [NativeTypeName("LPCWSTR")] ushort* RemoteName, [NativeTypeName("LPCWSTR")] ushort* UserName, [NativeTypeName("LPCWSTR")] ushort* Password, [NativeTypeName("PBYTE")] byte* ClientCert, [NativeTypeName("DWORD")] uint CertSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DavDeleteConnection"]/*' />
    [DllImport("netapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DavDeleteConnection(HANDLE ConnectionHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DavGetUNCFromHTTPPath"]/*' />
    [DllImport("netapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DavGetUNCFromHTTPPath([NativeTypeName("LPCWSTR")] ushort* Url, [NativeTypeName("LPWSTR")] ushort* UncPath, [NativeTypeName("LPDWORD")] uint* lpSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DavGetHTTPFromUNCPath"]/*' />
    [DllImport("netapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DavGetHTTPFromUNCPath([NativeTypeName("LPCWSTR")] ushort* UncPath, [NativeTypeName("LPWSTR")] ushort* Url, [NativeTypeName("LPDWORD")] uint* lpSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DavGetTheLockOwnerOfTheFile"]/*' />
    [DllImport("davclnt", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DavGetTheLockOwnerOfTheFile([NativeTypeName("LPCWSTR")] ushort* FileName, [NativeTypeName("PWSTR")] ushort* LockOwnerName, [NativeTypeName("PULONG")] uint* LockOwnerNameLengthInBytes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DavGetExtendedError"]/*' />
    [DllImport("netapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DavGetExtendedError(HANDLE hFile, [NativeTypeName("DWORD *")] uint* ExtError, [NativeTypeName("LPWSTR")] ushort* ExtErrorString, [NativeTypeName("DWORD *")] uint* cChSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DavFlushFile"]/*' />
    [DllImport("netapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DavFlushFile(HANDLE hFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DavInvalidateCache"]/*' />
    [DllImport("davclnt", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DavInvalidateCache([NativeTypeName("LPCWSTR")] ushort* URLName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DavCancelConnectionsToServer"]/*' />
    [DllImport("davclnt", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DavCancelConnectionsToServer([NativeTypeName("LPWSTR")] ushort* lpName, BOOL fForce);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DavRegisterAuthCallback"]/*' />
    [DllImport("davclnt", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DavRegisterAuthCallback([NativeTypeName("PFNDAVAUTHCALLBACK")] delegate* unmanaged<ushort*, ushort*, uint, uint, DAV_CALLBACK_CRED*, AUTHNEXTSTEP*, delegate* unmanaged<void*, uint>*, uint> CallBack, [NativeTypeName("ULONG")] uint Version);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DavUnregisterAuthCallback"]/*' />
    [DllImport("davclnt", ExactSpelling = true)]
    public static extern void DavUnregisterAuthCallback([NativeTypeName("DWORD")] uint hCallback);

    [NativeTypeName("#define DAV_AUTHN_SCHEME_BASIC 0x00000001")]
    public const int DAV_AUTHN_SCHEME_BASIC = 0x00000001;

    [NativeTypeName("#define DAV_AUTHN_SCHEME_NTLM 0x00000002")]
    public const int DAV_AUTHN_SCHEME_NTLM = 0x00000002;

    [NativeTypeName("#define DAV_AUTHN_SCHEME_PASSPORT 0x00000004")]
    public const int DAV_AUTHN_SCHEME_PASSPORT = 0x00000004;

    [NativeTypeName("#define DAV_AUTHN_SCHEME_DIGEST 0x00000008")]
    public const int DAV_AUTHN_SCHEME_DIGEST = 0x00000008;

    [NativeTypeName("#define DAV_AUTHN_SCHEME_NEGOTIATE 0x00000010")]
    public const int DAV_AUTHN_SCHEME_NEGOTIATE = 0x00000010;

    [NativeTypeName("#define DAV_AUTHN_SCHEME_CERT 0x00010000")]
    public const int DAV_AUTHN_SCHEME_CERT = 0x00010000;

    [NativeTypeName("#define DAV_AUTHN_SCHEME_FBA 0x00100000")]
    public const int DAV_AUTHN_SCHEME_FBA = 0x00100000;
}
