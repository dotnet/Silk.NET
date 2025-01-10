// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO
{
    [NativeTypeName("__AnonymousRecord_SoftPub_L133_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("PCCERT_CHAIN_CONTEXT")]
    public CERT_CHAIN_CONTEXT* pChainContext;

    [NativeTypeName("DWORD")]
    public uint dwSignerType;

    [NativeTypeName("PCMSG_SIGNER_INFO")]
    public CMSG_SIGNER_INFO* pMsgSignerInfo;

    [NativeTypeName("DWORD")]
    public uint dwError;

    [NativeTypeName("DWORD")]
    public uint cCounterSigner;

    [NativeTypeName("PWTD_GENERIC_CHAIN_POLICY_SIGNER_INFO *")]
    public WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO** rgpCounterSigner;

    [UnscopedRef]
    public ref uint cbStruct
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.cbStruct; }
    }

    [UnscopedRef]
    public ref uint cbSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.cbSize; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cbSize;
    }
}
