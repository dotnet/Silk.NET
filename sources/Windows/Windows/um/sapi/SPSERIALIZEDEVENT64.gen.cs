// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace Silk.NET.Windows;

/// <include file='SPSERIALIZEDEVENT64.xml' path='doc/member[@name="SPSERIALIZEDEVENT64"]/*' />
public partial struct SPSERIALIZEDEVENT64
{
    public int _bitfield;

    /// <include file='SPSERIALIZEDEVENT64.xml' path='doc/member[@name="SPSERIALIZEDEVENT64.eEventId"]/*' />
    [NativeTypeName("SPEVENTENUM : 16")]
    public SPEVENTENUM eEventId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (SPEVENTENUM)(_bitfield & 0xFFFF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0xFFFF) | ((int)(value) & 0xFFFF);
        }
    }

    /// <include file='SPSERIALIZEDEVENT64.xml' path='doc/member[@name="SPSERIALIZEDEVENT64.elParamType"]/*' />
    [NativeTypeName("SPEVENTLPARAMTYPE : 16")]
    public SPEVENTLPARAMTYPE elParamType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (SPEVENTLPARAMTYPE)((_bitfield >> 16) & 0xFFFF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0xFFFF << 16)) | (((int)(value) & 0xFFFF) << 16);
        }
    }

    /// <include file='SPSERIALIZEDEVENT64.xml' path='doc/member[@name="SPSERIALIZEDEVENT64.ulStreamNum"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulStreamNum;

    /// <include file='SPSERIALIZEDEVENT64.xml' path='doc/member[@name="SPSERIALIZEDEVENT64.ullAudioStreamOffset"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullAudioStreamOffset;

    /// <include file='SPSERIALIZEDEVENT64.xml' path='doc/member[@name="SPSERIALIZEDEVENT64.SerializedwParam"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SerializedwParam;

    /// <include file='SPSERIALIZEDEVENT64.xml' path='doc/member[@name="SPSERIALIZEDEVENT64.SerializedlParam"]/*' />
    [NativeTypeName("LONGLONG")]
    public long SerializedlParam;
}
