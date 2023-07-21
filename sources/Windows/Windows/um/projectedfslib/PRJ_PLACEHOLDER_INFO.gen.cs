// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PRJ_PLACEHOLDER_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_INFO"]/*' />
[SupportedOSPlatform("windows10.0.17763.0")]
public unsafe partial struct PRJ_PLACEHOLDER_INFO
{
    /// <include file='PRJ_PLACEHOLDER_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_INFO.FileBasicInfo"]/*' />
    public PRJ_FILE_BASIC_INFO FileBasicInfo;

    /// <include file='PRJ_PLACEHOLDER_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_INFO.EaInformation"]/*' />
    [NativeTypeName("__AnonymousRecord_projectedfslib_L212_C5")]
    public _EaInformation_e__Struct EaInformation;

    /// <include file='PRJ_PLACEHOLDER_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_INFO.SecurityInformation"]/*' />
    [NativeTypeName("__AnonymousRecord_projectedfslib_L218_C5")]
    public _SecurityInformation_e__Struct SecurityInformation;

    /// <include file='PRJ_PLACEHOLDER_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_INFO.StreamsInformation"]/*' />
    [NativeTypeName("__AnonymousRecord_projectedfslib_L224_C5")]
    public _StreamsInformation_e__Struct StreamsInformation;

    /// <include file='PRJ_PLACEHOLDER_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_INFO.VersionInfo"]/*' />
    public PRJ_PLACEHOLDER_VERSION_INFO VersionInfo;

    /// <include file='PRJ_PLACEHOLDER_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_INFO.VariableData"]/*' />
    [NativeTypeName("UINT8[1]")]
    public fixed byte VariableData[1];

    /// <include file='_EaInformation_e__Struct.xml' path='doc/member[@name="_EaInformation_e__Struct"]/*' />
    public partial struct _EaInformation_e__Struct
    {
        /// <include file='_EaInformation_e__Struct.xml' path='doc/member[@name="_EaInformation_e__Struct.EaBufferSize"]/*' />
        [NativeTypeName("UINT32")]
        public uint EaBufferSize;

        /// <include file='_EaInformation_e__Struct.xml' path='doc/member[@name="_EaInformation_e__Struct.OffsetToFirstEa"]/*' />
        [NativeTypeName("UINT32")]
        public uint OffsetToFirstEa;
    }

    /// <include file='_SecurityInformation_e__Struct.xml' path='doc/member[@name="_SecurityInformation_e__Struct"]/*' />
    public partial struct _SecurityInformation_e__Struct
    {
        /// <include file='_SecurityInformation_e__Struct.xml' path='doc/member[@name="_SecurityInformation_e__Struct.SecurityBufferSize"]/*' />
        [NativeTypeName("UINT32")]
        public uint SecurityBufferSize;

        /// <include file='_SecurityInformation_e__Struct.xml' path='doc/member[@name="_SecurityInformation_e__Struct.OffsetToSecurityDescriptor"]/*' />
        [NativeTypeName("UINT32")]
        public uint OffsetToSecurityDescriptor;
    }

    /// <include file='_StreamsInformation_e__Struct.xml' path='doc/member[@name="_StreamsInformation_e__Struct"]/*' />
    public partial struct _StreamsInformation_e__Struct
    {
        /// <include file='_StreamsInformation_e__Struct.xml' path='doc/member[@name="_StreamsInformation_e__Struct.StreamsInfoBufferSize"]/*' />
        [NativeTypeName("UINT32")]
        public uint StreamsInfoBufferSize;

        /// <include file='_StreamsInformation_e__Struct.xml' path='doc/member[@name="_StreamsInformation_e__Struct.OffsetToFirstStreamInfo"]/*' />
        [NativeTypeName("UINT32")]
        public uint OffsetToFirstStreamInfo;
    }
}
