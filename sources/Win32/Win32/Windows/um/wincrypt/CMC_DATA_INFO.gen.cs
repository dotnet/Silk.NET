// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CMC_DATA_INFO
{
    [NativeTypeName("DWORD")]
    public uint cTaggedAttribute;

    [NativeTypeName("PCMC_TAGGED_ATTRIBUTE")]
    public CMC_TAGGED_ATTRIBUTE* rgTaggedAttribute;

    [NativeTypeName("DWORD")]
    public uint cTaggedRequest;

    [NativeTypeName("PCMC_TAGGED_REQUEST")]
    public CMC_TAGGED_REQUEST* rgTaggedRequest;

    [NativeTypeName("DWORD")]
    public uint cTaggedContentInfo;

    [NativeTypeName("PCMC_TAGGED_CONTENT_INFO")]
    public CMC_TAGGED_CONTENT_INFO* rgTaggedContentInfo;

    [NativeTypeName("DWORD")]
    public uint cTaggedOtherMsg;

    [NativeTypeName("PCMC_TAGGED_OTHER_MSG")]
    public CMC_TAGGED_OTHER_MSG* rgTaggedOtherMsg;
}
