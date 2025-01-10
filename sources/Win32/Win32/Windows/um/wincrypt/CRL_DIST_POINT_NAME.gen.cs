// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CRL_DIST_POINT_NAME
{
    [NativeTypeName("DWORD")]
    public uint dwDistPointNameChoice;

    [NativeTypeName("__AnonymousRecord_wincrypt_L4472_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref CERT_ALT_NAME_INFO FullName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.FullName; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public CERT_ALT_NAME_INFO FullName;
    }
}
