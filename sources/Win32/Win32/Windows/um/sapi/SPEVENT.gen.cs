// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SPEVENT
{
    public int _bitfield;

    [NativeTypeName("SPEVENTENUM : 16")]
    public SPEVENTENUM eEventId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (SPEVENTENUM)((_bitfield << 16) >> 16); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~0xFFFF) | ((int)(value) & 0xFFFF); }
    }

    [NativeTypeName("SPEVENTLPARAMTYPE : 16")]
    public SPEVENTLPARAMTYPE elParamType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (SPEVENTLPARAMTYPE)((_bitfield << 0) >> 16); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0xFFFF << 16)) | (((int)(value) & 0xFFFF) << 16); }
    }

    [NativeTypeName("ULONG")]
    public uint ulStreamNum;

    [NativeTypeName("ULONGLONG")]
    public ulong ullAudioStreamOffset;
    public WPARAM wParam;
    public LPARAM lParam;
}
