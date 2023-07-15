// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='SPEVENTEX.xml' path='doc/member[@name="SPEVENTEX"]/*'/>
public partial struct SPEVENTEX
{
    public int _bitfield;
    /// <include file='SPEVENTEX.xml' path='doc/member[@name="SPEVENTEX.eEventId"]/*'/>
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

    /// <include file='SPEVENTEX.xml' path='doc/member[@name="SPEVENTEX.elParamType"]/*'/>
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

    /// <include file='SPEVENTEX.xml' path='doc/member[@name="SPEVENTEX.ulStreamNum"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulStreamNum;
    /// <include file='SPEVENTEX.xml' path='doc/member[@name="SPEVENTEX.ullAudioStreamOffset"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ullAudioStreamOffset;
    /// <include file='SPEVENTEX.xml' path='doc/member[@name="SPEVENTEX.wParam"]/*'/>
    public WPARAM wParam;
    /// <include file='SPEVENTEX.xml' path='doc/member[@name="SPEVENTEX.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='SPEVENTEX.xml' path='doc/member[@name="SPEVENTEX.ullAudioTimeOffset"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ullAudioTimeOffset;
}