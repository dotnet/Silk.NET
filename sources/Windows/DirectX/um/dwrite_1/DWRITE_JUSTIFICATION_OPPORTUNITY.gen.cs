// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_JUSTIFICATION_OPPORTUNITY.xml' path='doc/member[@name="DWRITE_JUSTIFICATION_OPPORTUNITY"]/*'/>
public partial struct DWRITE_JUSTIFICATION_OPPORTUNITY
{
    /// <include file='DWRITE_JUSTIFICATION_OPPORTUNITY.xml' path='doc/member[@name="DWRITE_JUSTIFICATION_OPPORTUNITY.expansionMinimum"]/*'/>
    public float expansionMinimum;
    /// <include file='DWRITE_JUSTIFICATION_OPPORTUNITY.xml' path='doc/member[@name="DWRITE_JUSTIFICATION_OPPORTUNITY.expansionMaximum"]/*'/>
    public float expansionMaximum;
    /// <include file='DWRITE_JUSTIFICATION_OPPORTUNITY.xml' path='doc/member[@name="DWRITE_JUSTIFICATION_OPPORTUNITY.compressionMaximum"]/*'/>
    public float compressionMaximum;
    public uint _bitfield;
    /// <include file='DWRITE_JUSTIFICATION_OPPORTUNITY.xml' path='doc/member[@name="DWRITE_JUSTIFICATION_OPPORTUNITY.expansionPriority"]/*'/>
    [NativeTypeName("UINT32 : 8")]
    public uint expansionPriority
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return _bitfield & 0xFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0xFFu) | (value & 0xFFu);
        }
    }

    /// <include file='DWRITE_JUSTIFICATION_OPPORTUNITY.xml' path='doc/member[@name="DWRITE_JUSTIFICATION_OPPORTUNITY.compressionPriority"]/*'/>
    [NativeTypeName("UINT32 : 8")]
    public uint compressionPriority
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 8) & 0xFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0xFFu << 8)) | ((value & 0xFFu) << 8);
        }
    }

    /// <include file='DWRITE_JUSTIFICATION_OPPORTUNITY.xml' path='doc/member[@name="DWRITE_JUSTIFICATION_OPPORTUNITY.allowResidualExpansion"]/*'/>
    [NativeTypeName("UINT32 : 1")]
    public uint allowResidualExpansion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 16) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16);
        }
    }

    /// <include file='DWRITE_JUSTIFICATION_OPPORTUNITY.xml' path='doc/member[@name="DWRITE_JUSTIFICATION_OPPORTUNITY.allowResidualCompression"]/*'/>
    [NativeTypeName("UINT32 : 1")]
    public uint allowResidualCompression
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 17) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 17)) | ((value & 0x1u) << 17);
        }
    }

    /// <include file='DWRITE_JUSTIFICATION_OPPORTUNITY.xml' path='doc/member[@name="DWRITE_JUSTIFICATION_OPPORTUNITY.applyToLeadingEdge"]/*'/>
    [NativeTypeName("UINT32 : 1")]
    public uint applyToLeadingEdge
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 18) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 18)) | ((value & 0x1u) << 18);
        }
    }

    /// <include file='DWRITE_JUSTIFICATION_OPPORTUNITY.xml' path='doc/member[@name="DWRITE_JUSTIFICATION_OPPORTUNITY.applyToTrailingEdge"]/*'/>
    [NativeTypeName("UINT32 : 1")]
    public uint applyToTrailingEdge
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 19) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 19)) | ((value & 0x1u) << 19);
        }
    }

    /// <include file='DWRITE_JUSTIFICATION_OPPORTUNITY.xml' path='doc/member[@name="DWRITE_JUSTIFICATION_OPPORTUNITY.reserved"]/*'/>
    [NativeTypeName("UINT32 : 12")]
    public uint reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 20) & 0xFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0xFFFu << 20)) | ((value & 0xFFFu) << 20);
        }
    }
}