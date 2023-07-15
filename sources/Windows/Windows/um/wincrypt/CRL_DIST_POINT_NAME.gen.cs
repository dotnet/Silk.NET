// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='CRL_DIST_POINT_NAME.xml' path='doc/member[@name="CRL_DIST_POINT_NAME"]/*'/>
public partial struct CRL_DIST_POINT_NAME
{
    /// <include file='CRL_DIST_POINT_NAME.xml' path='doc/member[@name="CRL_DIST_POINT_NAME.dwDistPointNameChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDistPointNameChoice;
    /// <include file='CRL_DIST_POINT_NAME.xml' path='doc/member[@name="CRL_DIST_POINT_NAME.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincrypt_L4440_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FullName"]/*'/>
    [UnscopedRef]
    public ref CERT_ALT_NAME_INFO FullName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.FullName;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FullName"]/*'/>
        [FieldOffset(0)]
        public CERT_ALT_NAME_INFO FullName;
    }
}