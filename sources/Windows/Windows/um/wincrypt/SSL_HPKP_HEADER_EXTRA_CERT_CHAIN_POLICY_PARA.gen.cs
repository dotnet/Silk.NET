// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='SSL_HPKP_HEADER_EXTRA_CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="SSL_HPKP_HEADER_EXTRA_CERT_CHAIN_POLICY_PARA"]/*'/>
public unsafe partial struct SSL_HPKP_HEADER_EXTRA_CERT_CHAIN_POLICY_PARA
{
    /// <include file='SSL_HPKP_HEADER_EXTRA_CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="SSL_HPKP_HEADER_EXTRA_CERT_CHAIN_POLICY_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='SSL_HPKP_HEADER_EXTRA_CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="SSL_HPKP_HEADER_EXTRA_CERT_CHAIN_POLICY_PARA.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
    /// <include file='SSL_HPKP_HEADER_EXTRA_CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="SSL_HPKP_HEADER_EXTRA_CERT_CHAIN_POLICY_PARA.pwszServerName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pwszServerName;
    /// <include file='SSL_HPKP_HEADER_EXTRA_CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="SSL_HPKP_HEADER_EXTRA_CERT_CHAIN_POLICY_PARA.rgpszHpkpValue"]/*'/>
    [NativeTypeName("LPSTR[2]")]
    public _rgpszHpkpValue_e__FixedBuffer rgpszHpkpValue;
    /// <include file='_rgpszHpkpValue_e__FixedBuffer.xml' path='doc/member[@name="_rgpszHpkpValue_e__FixedBuffer"]/*'/>
    public unsafe partial struct _rgpszHpkpValue_e__FixedBuffer
    {
        public sbyte* e0;
        public sbyte* e1;
        public ref sbyte* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (sbyte** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}