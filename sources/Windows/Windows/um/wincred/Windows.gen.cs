// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredWriteW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredWriteW([NativeTypeName("PCREDENTIALW")] CREDENTIALW* Credential, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredWriteA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredWriteA([NativeTypeName("PCREDENTIALA")] CREDENTIALA* Credential, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredReadW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredReadW([NativeTypeName("LPCWSTR")] ushort* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIALW *")] CREDENTIALW** Credential);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredReadA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredReadA([NativeTypeName("LPCSTR")] sbyte* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIALA *")] CREDENTIALA** Credential);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredEnumerateW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredEnumerateW([NativeTypeName("LPCWSTR")] ushort* Filter, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD *")] uint* Count, [NativeTypeName("PCREDENTIALW **")] CREDENTIALW*** Credential);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredEnumerateA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredEnumerateA([NativeTypeName("LPCSTR")] sbyte* Filter, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD *")] uint* Count, [NativeTypeName("PCREDENTIALA **")] CREDENTIALA*** Credential);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredWriteDomainCredentialsW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredWriteDomainCredentialsW([NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONW")] CREDENTIAL_TARGET_INFORMATIONW* TargetInfo, [NativeTypeName("PCREDENTIALW")] CREDENTIALW* Credential, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredWriteDomainCredentialsA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredWriteDomainCredentialsA([NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONA")] CREDENTIAL_TARGET_INFORMATIONA* TargetInfo, [NativeTypeName("PCREDENTIALA")] CREDENTIALA* Credential, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredReadDomainCredentialsW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredReadDomainCredentialsW([NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONW")] CREDENTIAL_TARGET_INFORMATIONW* TargetInfo, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD *")] uint* Count, [NativeTypeName("PCREDENTIALW **")] CREDENTIALW*** Credential);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredReadDomainCredentialsA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredReadDomainCredentialsA([NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONA")] CREDENTIAL_TARGET_INFORMATIONA* TargetInfo, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD *")] uint* Count, [NativeTypeName("PCREDENTIALA **")] CREDENTIALA*** Credential);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredDeleteW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredDeleteW([NativeTypeName("LPCWSTR")] ushort* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredDeleteA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredDeleteA([NativeTypeName("LPCSTR")] sbyte* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredRenameW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredRenameW([NativeTypeName("LPCWSTR")] ushort* OldTargetName, [NativeTypeName("LPCWSTR")] ushort* NewTargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredRenameA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredRenameA([NativeTypeName("LPCSTR")] sbyte* OldTargetName, [NativeTypeName("LPCSTR")] sbyte* NewTargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredGetTargetInfoW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredGetTargetInfoW([NativeTypeName("LPCWSTR")] ushort* TargetName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONW *")] CREDENTIAL_TARGET_INFORMATIONW** TargetInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredGetTargetInfoA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredGetTargetInfoA([NativeTypeName("LPCSTR")] sbyte* TargetName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONA *")] CREDENTIAL_TARGET_INFORMATIONA** TargetInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredMarshalCredentialW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredMarshalCredentialW(CRED_MARSHAL_TYPE CredType, [NativeTypeName("PVOID")] void* Credential, [NativeTypeName("LPWSTR *")] ushort** MarshaledCredential);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredMarshalCredentialA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredMarshalCredentialA(CRED_MARSHAL_TYPE CredType, [NativeTypeName("PVOID")] void* Credential, [NativeTypeName("LPSTR *")] sbyte** MarshaledCredential);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUnmarshalCredentialW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredUnmarshalCredentialW([NativeTypeName("LPCWSTR")] ushort* MarshaledCredential, [NativeTypeName("PCRED_MARSHAL_TYPE")] CRED_MARSHAL_TYPE* CredType, [NativeTypeName("PVOID *")] void** Credential);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUnmarshalCredentialA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredUnmarshalCredentialA([NativeTypeName("LPCSTR")] sbyte* MarshaledCredential, [NativeTypeName("PCRED_MARSHAL_TYPE")] CRED_MARSHAL_TYPE* CredType, [NativeTypeName("PVOID *")] void** Credential);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredIsMarshaledCredentialW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    public static extern BOOL CredIsMarshaledCredentialW([NativeTypeName("LPCWSTR")] ushort* MarshaledCredential);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredIsMarshaledCredentialA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    public static extern BOOL CredIsMarshaledCredentialA([NativeTypeName("LPCSTR")] sbyte* MarshaledCredential);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUnPackAuthenticationBufferW"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredUnPackAuthenticationBufferW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID")] void* pAuthBuffer, [NativeTypeName("DWORD")] uint cbAuthBuffer, [NativeTypeName("LPWSTR")] ushort* pszUserName, [NativeTypeName("DWORD *")] uint* pcchMaxUserName, [NativeTypeName("LPWSTR")] ushort* pszDomainName, [NativeTypeName("DWORD *")] uint* pcchMaxDomainName, [NativeTypeName("LPWSTR")] ushort* pszPassword, [NativeTypeName("DWORD *")] uint* pcchMaxPassword);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUnPackAuthenticationBufferA"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredUnPackAuthenticationBufferA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID")] void* pAuthBuffer, [NativeTypeName("DWORD")] uint cbAuthBuffer, [NativeTypeName("LPSTR")] sbyte* pszUserName, [NativeTypeName("DWORD *")] uint* pcchlMaxUserName, [NativeTypeName("LPSTR")] sbyte* pszDomainName, [NativeTypeName("DWORD *")] uint* pcchMaxDomainName, [NativeTypeName("LPSTR")] sbyte* pszPassword, [NativeTypeName("DWORD *")] uint* pcchMaxPassword);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredPackAuthenticationBufferW"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredPackAuthenticationBufferW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszUserName, [NativeTypeName("LPWSTR")] ushort* pszPassword, [NativeTypeName("PBYTE")] byte* pPackedCredentials, [NativeTypeName("DWORD *")] uint* pcbPackedCredentials);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredPackAuthenticationBufferA"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredPackAuthenticationBufferA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* pszUserName, [NativeTypeName("LPSTR")] sbyte* pszPassword, [NativeTypeName("PBYTE")] byte* pPackedCredentials, [NativeTypeName("DWORD *")] uint* pcbPackedCredentials);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredProtectW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredProtectW(BOOL fAsSelf, [NativeTypeName("LPWSTR")] ushort* pszCredentials, [NativeTypeName("DWORD")] uint cchCredentials, [NativeTypeName("LPWSTR")] ushort* pszProtectedCredentials, [NativeTypeName("DWORD *")] uint* pcchMaxChars, CRED_PROTECTION_TYPE* ProtectionType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredProtectA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredProtectA(BOOL fAsSelf, [NativeTypeName("LPSTR")] sbyte* pszCredentials, [NativeTypeName("DWORD")] uint cchCredentials, [NativeTypeName("LPSTR")] sbyte* pszProtectedCredentials, [NativeTypeName("DWORD *")] uint* pcchMaxChars, CRED_PROTECTION_TYPE* ProtectionType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUnprotectW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredUnprotectW(BOOL fAsSelf, [NativeTypeName("LPWSTR")] ushort* pszProtectedCredentials, [NativeTypeName("DWORD")] uint cchProtectedCredentials, [NativeTypeName("LPWSTR")] ushort* pszCredentials, [NativeTypeName("DWORD *")] uint* pcchMaxChars);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUnprotectA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredUnprotectA(BOOL fAsSelf, [NativeTypeName("LPSTR")] sbyte* pszProtectedCredentials, [NativeTypeName("DWORD")] uint cchProtectedCredentials, [NativeTypeName("LPSTR")] sbyte* pszCredentials, [NativeTypeName("DWORD *")] uint* pcchMaxChars);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredIsProtectedW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredIsProtectedW([NativeTypeName("LPWSTR")] ushort* pszProtectedCredentials, CRED_PROTECTION_TYPE* pProtectionType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredIsProtectedA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredIsProtectedA([NativeTypeName("LPSTR")] sbyte* pszProtectedCredentials, CRED_PROTECTION_TYPE* pProtectionType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredFindBestCredentialW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredFindBestCredentialW([NativeTypeName("LPCWSTR")] ushort* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIALW *")] CREDENTIALW** Credential);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredFindBestCredentialA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredFindBestCredentialA([NativeTypeName("LPCSTR")] sbyte* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIALA *")] CREDENTIALA** Credential);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredGetSessionTypes"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CredGetSessionTypes([NativeTypeName("DWORD")] uint MaximumPersistCount, [NativeTypeName("LPDWORD")] uint* MaximumPersist);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredFree"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void CredFree([NativeTypeName("PVOID")] void* Buffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUIPromptForCredentialsW"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CredUIPromptForCredentialsW([NativeTypeName("PCREDUI_INFOW")] CREDUI_INFOW* pUiInfo, [NativeTypeName("PCWSTR")] ushort* pszTargetName, [NativeTypeName("PCtxtHandle")] SecHandle* pContext, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("PWSTR")] ushort* pszUserName, [NativeTypeName("ULONG")] uint ulUserNameBufferSize, [NativeTypeName("PWSTR")] ushort* pszPassword, [NativeTypeName("ULONG")] uint ulPasswordBufferSize, BOOL* save, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUIPromptForCredentialsA"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CredUIPromptForCredentialsA([NativeTypeName("PCREDUI_INFOA")] CREDUI_INFOA* pUiInfo, [NativeTypeName("PCSTR")] sbyte* pszTargetName, [NativeTypeName("PCtxtHandle")] SecHandle* pContext, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("PSTR")] sbyte* pszUserName, [NativeTypeName("ULONG")] uint ulUserNameBufferSize, [NativeTypeName("PSTR")] sbyte* pszPassword, [NativeTypeName("ULONG")] uint ulPasswordBufferSize, BOOL* save, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUIPromptForWindowsCredentialsW"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CredUIPromptForWindowsCredentialsW([NativeTypeName("PCREDUI_INFOW")] CREDUI_INFOW* pUiInfo, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("ULONG *")] uint* pulAuthPackage, [NativeTypeName("LPCVOID")] void* pvInAuthBuffer, [NativeTypeName("ULONG")] uint ulInAuthBufferSize, [NativeTypeName("LPVOID *")] void** ppvOutAuthBuffer, [NativeTypeName("ULONG *")] uint* pulOutAuthBufferSize, BOOL* pfSave, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUIPromptForWindowsCredentialsA"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CredUIPromptForWindowsCredentialsA([NativeTypeName("PCREDUI_INFOA")] CREDUI_INFOA* pUiInfo, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("ULONG *")] uint* pulAuthPackage, [NativeTypeName("LPCVOID")] void* pvInAuthBuffer, [NativeTypeName("ULONG")] uint ulInAuthBufferSize, [NativeTypeName("LPVOID *")] void** ppvOutAuthBuffer, [NativeTypeName("ULONG *")] uint* pulOutAuthBufferSize, BOOL* pfSave, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUIParseUserNameW"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CredUIParseUserNameW([NativeTypeName("PCWSTR")] ushort* UserName, [NativeTypeName("WCHAR *")] ushort* user, [NativeTypeName("ULONG")] uint userBufferSize, [NativeTypeName("WCHAR *")] ushort* domain, [NativeTypeName("ULONG")] uint domainBufferSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUIParseUserNameA"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CredUIParseUserNameA([NativeTypeName("PCSTR")] sbyte* userName, [NativeTypeName("CHAR *")] sbyte* user, [NativeTypeName("ULONG")] uint userBufferSize, [NativeTypeName("CHAR *")] sbyte* domain, [NativeTypeName("ULONG")] uint domainBufferSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUICmdLinePromptForCredentialsW"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CredUICmdLinePromptForCredentialsW([NativeTypeName("PCWSTR")] ushort* pszTargetName, [NativeTypeName("PCtxtHandle")] SecHandle* pContext, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("PWSTR")] ushort* UserName, [NativeTypeName("ULONG")] uint ulUserBufferSize, [NativeTypeName("PWSTR")] ushort* pszPassword, [NativeTypeName("ULONG")] uint ulPasswordBufferSize, [NativeTypeName("PBOOL")] BOOL* pfSave, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUICmdLinePromptForCredentialsA"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CredUICmdLinePromptForCredentialsA([NativeTypeName("PCSTR")] sbyte* pszTargetName, [NativeTypeName("PCtxtHandle")] SecHandle* pContext, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("PSTR")] sbyte* UserName, [NativeTypeName("ULONG")] uint ulUserBufferSize, [NativeTypeName("PSTR")] sbyte* pszPassword, [NativeTypeName("ULONG")] uint ulPasswordBufferSize, [NativeTypeName("PBOOL")] BOOL* pfSave, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUIConfirmCredentialsW"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CredUIConfirmCredentialsW([NativeTypeName("PCWSTR")] ushort* pszTargetName, BOOL bConfirm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUIConfirmCredentialsA"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CredUIConfirmCredentialsA([NativeTypeName("PCSTR")] sbyte* pszTargetName, BOOL bConfirm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUIStoreSSOCredW"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CredUIStoreSSOCredW([NativeTypeName("PCWSTR")] ushort* pszRealm, [NativeTypeName("PCWSTR")] ushort* pszUsername, [NativeTypeName("PCWSTR")] ushort* pszPassword, BOOL bPersist);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CredUIReadSSOCredW"]/*'/>
    [DllImport("credui", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CredUIReadSSOCredW([NativeTypeName("PCWSTR")] ushort* pszRealm, [NativeTypeName("PWSTR *")] ushort** ppszUsername);
    [NativeTypeName("#define CredWrite CredWriteW")]
    public static delegate*<CREDENTIALW*, uint, BOOL> CredWrite => &CredWriteW;

    [NativeTypeName("#define CredRead CredReadW")]
    public static delegate*<ushort*, uint, uint, CREDENTIALW**, BOOL> CredRead => &CredReadW;

    [NativeTypeName("#define CredEnumerate CredEnumerateW")]
    public static delegate*<ushort*, uint, uint*, CREDENTIALW***, BOOL> CredEnumerate => &CredEnumerateW;

    [NativeTypeName("#define CredWriteDomainCredentials CredWriteDomainCredentialsW")]
    public static delegate*<CREDENTIAL_TARGET_INFORMATIONW*, CREDENTIALW*, uint, BOOL> CredWriteDomainCredentials => &CredWriteDomainCredentialsW;

    [NativeTypeName("#define CredReadDomainCredentials CredReadDomainCredentialsW")]
    public static delegate*<CREDENTIAL_TARGET_INFORMATIONW*, uint, uint*, CREDENTIALW***, BOOL> CredReadDomainCredentials => &CredReadDomainCredentialsW;

    [NativeTypeName("#define CredDelete CredDeleteW")]
    public static delegate*<ushort*, uint, uint, BOOL> CredDelete => &CredDeleteW;

    [NativeTypeName("#define CredRename CredRenameW")]
    public static delegate*<ushort*, ushort*, uint, uint, BOOL> CredRename => &CredRenameW;

    [NativeTypeName("#define CredGetTargetInfo CredGetTargetInfoW")]
    public static delegate*<ushort*, uint, CREDENTIAL_TARGET_INFORMATIONW**, BOOL> CredGetTargetInfo => &CredGetTargetInfoW;

    [NativeTypeName("#define CredMarshalCredential CredMarshalCredentialW")]
    public static delegate*<CRED_MARSHAL_TYPE, void*, ushort**, BOOL> CredMarshalCredential => &CredMarshalCredentialW;

    [NativeTypeName("#define CredUnmarshalCredential CredUnmarshalCredentialW")]
    public static delegate*<ushort*, CRED_MARSHAL_TYPE*, void**, BOOL> CredUnmarshalCredential => &CredUnmarshalCredentialW;

    [NativeTypeName("#define CredIsMarshaledCredential CredIsMarshaledCredentialW")]
    public static delegate*<ushort*, BOOL> CredIsMarshaledCredential => &CredIsMarshaledCredentialW;

    [NativeTypeName("#define CredUnPackAuthenticationBuffer CredUnPackAuthenticationBufferW")]
    public static delegate*<uint, void*, uint, ushort*, uint*, ushort*, uint*, ushort*, uint*, BOOL> CredUnPackAuthenticationBuffer => &CredUnPackAuthenticationBufferW;

    [NativeTypeName("#define CredPackAuthenticationBuffer CredPackAuthenticationBufferW")]
    public static delegate*<uint, ushort*, ushort*, byte*, uint*, BOOL> CredPackAuthenticationBuffer => &CredPackAuthenticationBufferW;

    [NativeTypeName("#define CredProtect CredProtectW")]
    public static delegate*<BOOL, ushort*, uint, ushort*, uint*, CRED_PROTECTION_TYPE*, BOOL> CredProtect => &CredProtectW;

    [NativeTypeName("#define CredUnprotect CredUnprotectW")]
    public static delegate*<BOOL, ushort*, uint, ushort*, uint*, BOOL> CredUnprotect => &CredUnprotectW;

    [NativeTypeName("#define CredIsProtected CredIsProtectedW")]
    public static delegate*<ushort*, CRED_PROTECTION_TYPE*, BOOL> CredIsProtected => &CredIsProtectedW;

    [NativeTypeName("#define CredFindBestCredential CredFindBestCredentialW")]
    public static delegate*<ushort*, uint, uint, CREDENTIALW**, BOOL> CredFindBestCredential => &CredFindBestCredentialW;

    [NativeTypeName("#define CredUIPromptForCredentials CredUIPromptForCredentialsW")]
    public static delegate*<CREDUI_INFOW*, ushort*, SecHandle*, uint, ushort*, uint, ushort*, uint, BOOL*, uint, uint> CredUIPromptForCredentials => &CredUIPromptForCredentialsW;

    [NativeTypeName("#define CredUIPromptForWindowsCredentials CredUIPromptForWindowsCredentialsW")]
    public static delegate*<CREDUI_INFOW*, uint, uint*, void*, uint, void**, uint*, BOOL*, uint, uint> CredUIPromptForWindowsCredentials => &CredUIPromptForWindowsCredentialsW;

    [NativeTypeName("#define CredUIParseUserName CredUIParseUserNameW")]
    public static delegate*<ushort*, ushort*, uint, ushort*, uint, uint> CredUIParseUserName => &CredUIParseUserNameW;

    [NativeTypeName("#define CredUICmdLinePromptForCredentials CredUICmdLinePromptForCredentialsW")]
    public static delegate*<ushort*, SecHandle*, uint, ushort*, uint, ushort*, uint, BOOL*, uint, uint> CredUICmdLinePromptForCredentials => &CredUICmdLinePromptForCredentialsW;

    [NativeTypeName("#define CredUIConfirmCredentials CredUIConfirmCredentialsW")]
    public static delegate*<ushort*, BOOL, uint> CredUIConfirmCredentials => &CredUIConfirmCredentialsW;
}