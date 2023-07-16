// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;
/// <include file='DWRITE_SCRIPT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SCRIPT_PROPERTIES"]/*'/>
public partial struct DWRITE_SCRIPT_PROPERTIES
{
    /// <include file='DWRITE_SCRIPT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SCRIPT_PROPERTIES.isoScriptCode"]/*'/>
    [NativeTypeName("UINT32")]
    public uint isoScriptCode;
    /// <include file='DWRITE_SCRIPT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SCRIPT_PROPERTIES.isoScriptNumber"]/*'/>
    [NativeTypeName("UINT32")]
    public uint isoScriptNumber;
    /// <include file='DWRITE_SCRIPT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SCRIPT_PROPERTIES.clusterLookahead"]/*'/>
    [NativeTypeName("UINT32")]
    public uint clusterLookahead;
    /// <include file='DWRITE_SCRIPT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SCRIPT_PROPERTIES.justificationCharacter"]/*'/>
    [NativeTypeName("UINT32")]
    public uint justificationCharacter;
    public uint _bitfield;
    /// <include file='DWRITE_SCRIPT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SCRIPT_PROPERTIES.restrictCaretToClusters"]/*'/>
    [NativeTypeName("UINT32 : 1")]
    public uint restrictCaretToClusters
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return _bitfield & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
        }
    }

    /// <include file='DWRITE_SCRIPT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SCRIPT_PROPERTIES.usesWordDividers"]/*'/>
    [NativeTypeName("UINT32 : 1")]
    public uint usesWordDividers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 1) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
        }
    }

    /// <include file='DWRITE_SCRIPT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SCRIPT_PROPERTIES.isDiscreteWriting"]/*'/>
    [NativeTypeName("UINT32 : 1")]
    public uint isDiscreteWriting
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 2) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
        }
    }

    /// <include file='DWRITE_SCRIPT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SCRIPT_PROPERTIES.isBlockWriting"]/*'/>
    [NativeTypeName("UINT32 : 1")]
    public uint isBlockWriting
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 3) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
        }
    }

    /// <include file='DWRITE_SCRIPT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SCRIPT_PROPERTIES.isDistributedWithinCluster"]/*'/>
    [NativeTypeName("UINT32 : 1")]
    public uint isDistributedWithinCluster
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 4) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
        }
    }

    /// <include file='DWRITE_SCRIPT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SCRIPT_PROPERTIES.isConnectedWriting"]/*'/>
    [NativeTypeName("UINT32 : 1")]
    public uint isConnectedWriting
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 5) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
        }
    }

    /// <include file='DWRITE_SCRIPT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SCRIPT_PROPERTIES.isCursiveWriting"]/*'/>
    [NativeTypeName("UINT32 : 1")]
    public uint isCursiveWriting
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 6) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
        }
    }

    /// <include file='DWRITE_SCRIPT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SCRIPT_PROPERTIES.reserved"]/*'/>
    [NativeTypeName("UINT32 : 25")]
    public uint reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 7) & 0x1FFFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1FFFFFFu << 7)) | ((value & 0x1FFFFFFu) << 7);
        }
    }
}