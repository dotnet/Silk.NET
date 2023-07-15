// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='SPEVENT.xml' path='doc/member[@name="SPEVENT"]/*'/>
public partial struct SPEVENT
{
    public int _bitfield;
    /// <include file='SPEVENT.xml' path='doc/member[@name="SPEVENT.eEventId"]/*'/>
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

    /// <include file='SPEVENT.xml' path='doc/member[@name="SPEVENT.elParamType"]/*'/>
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

    /// <include file='SPEVENT.xml' path='doc/member[@name="SPEVENT.ulStreamNum"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulStreamNum;
    /// <include file='SPEVENT.xml' path='doc/member[@name="SPEVENT.ullAudioStreamOffset"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ullAudioStreamOffset;
    /// <include file='SPEVENT.xml' path='doc/member[@name="SPEVENT.wParam"]/*'/>
    public WPARAM wParam;
    /// <include file='SPEVENT.xml' path='doc/member[@name="SPEVENT.lParam"]/*'/>
    public LPARAM lParam;
}