// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CMC_DATA_INFO.xml' path='doc/member[@name="CMC_DATA_INFO"]/*'/>
public unsafe partial struct CMC_DATA_INFO
{
    /// <include file='CMC_DATA_INFO.xml' path='doc/member[@name="CMC_DATA_INFO.cTaggedAttribute"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cTaggedAttribute;
    /// <include file='CMC_DATA_INFO.xml' path='doc/member[@name="CMC_DATA_INFO.rgTaggedAttribute"]/*'/>
    [NativeTypeName("PCMC_TAGGED_ATTRIBUTE")]
    public CMC_TAGGED_ATTRIBUTE* rgTaggedAttribute;
    /// <include file='CMC_DATA_INFO.xml' path='doc/member[@name="CMC_DATA_INFO.cTaggedRequest"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cTaggedRequest;
    /// <include file='CMC_DATA_INFO.xml' path='doc/member[@name="CMC_DATA_INFO.rgTaggedRequest"]/*'/>
    [NativeTypeName("PCMC_TAGGED_REQUEST")]
    public CMC_TAGGED_REQUEST* rgTaggedRequest;
    /// <include file='CMC_DATA_INFO.xml' path='doc/member[@name="CMC_DATA_INFO.cTaggedContentInfo"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cTaggedContentInfo;
    /// <include file='CMC_DATA_INFO.xml' path='doc/member[@name="CMC_DATA_INFO.rgTaggedContentInfo"]/*'/>
    [NativeTypeName("PCMC_TAGGED_CONTENT_INFO")]
    public CMC_TAGGED_CONTENT_INFO* rgTaggedContentInfo;
    /// <include file='CMC_DATA_INFO.xml' path='doc/member[@name="CMC_DATA_INFO.cTaggedOtherMsg"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cTaggedOtherMsg;
    /// <include file='CMC_DATA_INFO.xml' path='doc/member[@name="CMC_DATA_INFO.rgTaggedOtherMsg"]/*'/>
    [NativeTypeName("PCMC_TAGGED_OTHER_MSG")]
    public CMC_TAGGED_OTHER_MSG* rgTaggedOtherMsg;
}