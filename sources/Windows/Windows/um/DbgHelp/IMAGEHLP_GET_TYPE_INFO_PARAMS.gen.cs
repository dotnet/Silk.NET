// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS"]/*' />
public unsafe partial struct IMAGEHLP_GET_TYPE_INFO_PARAMS
{
    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.SizeOfStruct"]/*' />
    [NativeTypeName("ULONG")]
    public uint SizeOfStruct;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.NumIds"]/*' />
    [NativeTypeName("ULONG")]
    public uint NumIds;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.TypeIds"]/*' />
    [NativeTypeName("PULONG")]
    public uint* TypeIds;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.TagFilter"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong TagFilter;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.NumReqs"]/*' />
    [NativeTypeName("ULONG")]
    public uint NumReqs;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.ReqKinds"]/*' />
    public IMAGEHLP_SYMBOL_TYPE_INFO* ReqKinds;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.ReqOffsets"]/*' />
    [NativeTypeName("PULONG_PTR")]
    public nuint* ReqOffsets;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.ReqSizes"]/*' />
    [NativeTypeName("PULONG")]
    public uint* ReqSizes;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.ReqStride"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint ReqStride;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.BufferSize"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint BufferSize;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.Buffer"]/*' />
    [NativeTypeName("PVOID")]
    public void* Buffer;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.EntriesMatched"]/*' />
    [NativeTypeName("ULONG")]
    public uint EntriesMatched;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.EntriesFilled"]/*' />
    [NativeTypeName("ULONG")]
    public uint EntriesFilled;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.TagsFound"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong TagsFound;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.AllReqsValid"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong AllReqsValid;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.NumReqsValid"]/*' />
    [NativeTypeName("ULONG")]
    public uint NumReqsValid;

    /// <include file='IMAGEHLP_GET_TYPE_INFO_PARAMS.xml' path='doc/member[@name="IMAGEHLP_GET_TYPE_INFO_PARAMS.ReqsValid"]/*' />
    [NativeTypeName("PULONG64")]
    public ulong* ReqsValid;
}
