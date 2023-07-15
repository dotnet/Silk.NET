// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='CMSG_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_RECIPIENT_ENCODE_INFO"]/*'/>
public unsafe partial struct CMSG_RECIPIENT_ENCODE_INFO
{
    /// <include file='CMSG_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_RECIPIENT_ENCODE_INFO.dwRecipientChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRecipientChoice;
    /// <include file='CMSG_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_RECIPIENT_ENCODE_INFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincrypt_L7024_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pKeyTrans"]/*'/>
    [UnscopedRef]
    public ref CMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO* pKeyTrans
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pKeyTrans;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pKeyAgree"]/*'/>
    [UnscopedRef]
    public ref CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO* pKeyAgree
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pKeyAgree;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pMailList"]/*'/>
    [UnscopedRef]
    public ref CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO* pMailList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pMailList;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pKeyTrans"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PCMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO")]
        public CMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO* pKeyTrans;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pKeyAgree"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PCMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO")]
        public CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO* pKeyAgree;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pMailList"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PCMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO")]
        public CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO* pMailList;
    }
}