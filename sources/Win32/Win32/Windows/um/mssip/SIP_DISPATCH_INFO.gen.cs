// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mssip.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SIP_DISPATCH_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public HANDLE hSIP;

    [NativeTypeName("pCryptSIPGetSignedDataMsg")]
    public delegate* unmanaged<SIP_SUBJECTINFO*, uint*, uint, uint*, byte*, BOOL> pfGet;

    [NativeTypeName("pCryptSIPPutSignedDataMsg")]
    public delegate* unmanaged<SIP_SUBJECTINFO*, uint, uint*, uint, byte*, BOOL> pfPut;

    [NativeTypeName("pCryptSIPCreateIndirectData")]
    public delegate* unmanaged<SIP_SUBJECTINFO*, uint*, SIP_INDIRECT_DATA*, BOOL> pfCreate;

    [NativeTypeName("pCryptSIPVerifyIndirectData")]
    public delegate* unmanaged<SIP_SUBJECTINFO*, SIP_INDIRECT_DATA*, BOOL> pfVerify;

    [NativeTypeName("pCryptSIPRemoveSignedDataMsg")]
    public delegate* unmanaged<SIP_SUBJECTINFO*, uint, BOOL> pfRemove;
}
