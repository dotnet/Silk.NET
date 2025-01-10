// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CMSG_CMS_RECIPIENT_INFO
{
    [NativeTypeName("DWORD")]
    public uint dwRecipientChoice;

    [NativeTypeName("__AnonymousRecord_wincrypt_L7872_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref CMSG_KEY_TRANS_RECIPIENT_INFO* pKeyTrans
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pKeyTrans; }
    }

    [UnscopedRef]
    public ref CMSG_KEY_AGREE_RECIPIENT_INFO* pKeyAgree
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pKeyAgree; }
    }

    [UnscopedRef]
    public ref CMSG_MAIL_LIST_RECIPIENT_INFO* pMailList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pMailList; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PCMSG_KEY_TRANS_RECIPIENT_INFO")]
        public CMSG_KEY_TRANS_RECIPIENT_INFO* pKeyTrans;

        [FieldOffset(0)]
        [NativeTypeName("PCMSG_KEY_AGREE_RECIPIENT_INFO")]
        public CMSG_KEY_AGREE_RECIPIENT_INFO* pKeyAgree;

        [FieldOffset(0)]
        [NativeTypeName("PCMSG_MAIL_LIST_RECIPIENT_INFO")]
        public CMSG_MAIL_LIST_RECIPIENT_INFO* pMailList;
    }
}
