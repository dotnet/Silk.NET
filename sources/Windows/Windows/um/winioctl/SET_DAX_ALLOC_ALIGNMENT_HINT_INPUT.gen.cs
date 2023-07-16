// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT.xml' path='doc/member[@name="SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT"]/*'/>
public partial struct SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT
{
    /// <include file='SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT.xml' path='doc/member[@name="SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT.xml' path='doc/member[@name="SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT.AlignmentShift"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AlignmentShift;
    /// <include file='SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT.xml' path='doc/member[@name="SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT.FileOffsetToAlign"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong FileOffsetToAlign;
    /// <include file='SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT.xml' path='doc/member[@name="SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT.FallbackAlignmentShift"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FallbackAlignmentShift;
}