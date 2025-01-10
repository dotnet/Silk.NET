// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct IMAGEHLP_GET_TYPE_INFO_PARAMS
{
    [NativeTypeName("ULONG")]
    public uint SizeOfStruct;

    [NativeTypeName("ULONG")]
    public uint Flags;

    [NativeTypeName("ULONG")]
    public uint NumIds;

    [NativeTypeName("PULONG")]
    public uint* TypeIds;

    [NativeTypeName("ULONG64")]
    public ulong TagFilter;

    [NativeTypeName("ULONG")]
    public uint NumReqs;
    public IMAGEHLP_SYMBOL_TYPE_INFO* ReqKinds;

    [NativeTypeName("PULONG_PTR")]
    public nuint* ReqOffsets;

    [NativeTypeName("PULONG")]
    public uint* ReqSizes;

    [NativeTypeName("ULONG_PTR")]
    public nuint ReqStride;

    [NativeTypeName("ULONG_PTR")]
    public nuint BufferSize;

    [NativeTypeName("PVOID")]
    public void* Buffer;

    [NativeTypeName("ULONG")]
    public uint EntriesMatched;

    [NativeTypeName("ULONG")]
    public uint EntriesFilled;

    [NativeTypeName("ULONG64")]
    public ulong TagsFound;

    [NativeTypeName("ULONG64")]
    public ulong AllReqsValid;

    [NativeTypeName("ULONG")]
    public uint NumReqsValid;

    [NativeTypeName("PULONG64")]
    public ulong* ReqsValid;
}
