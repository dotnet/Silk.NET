// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CERT_LOGOTYPE_INFO
{
    [NativeTypeName("DWORD")]
    public uint dwLogotypeInfoChoice;

    [NativeTypeName("__AnonymousRecord_wincrypt_L5555_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref CERT_LOGOTYPE_DATA* pLogotypeDirectInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pLogotypeDirectInfo; }
    }

    [UnscopedRef]
    public ref CERT_LOGOTYPE_REFERENCE* pLogotypeIndirectInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pLogotypeIndirectInfo; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PCERT_LOGOTYPE_DATA")]
        public CERT_LOGOTYPE_DATA* pLogotypeDirectInfo;

        [FieldOffset(0)]
        [NativeTypeName("PCERT_LOGOTYPE_REFERENCE")]
        public CERT_LOGOTYPE_REFERENCE* pLogotypeIndirectInfo;
    }
}
