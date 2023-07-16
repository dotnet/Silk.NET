// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STREAMS_ASSOCIATE_ID_INPUT_BUFFER.xml' path='doc/member[@name="STREAMS_ASSOCIATE_ID_INPUT_BUFFER"]/*'/>
public partial struct STREAMS_ASSOCIATE_ID_INPUT_BUFFER
{
    /// <include file='STREAMS_ASSOCIATE_ID_INPUT_BUFFER.xml' path='doc/member[@name="STREAMS_ASSOCIATE_ID_INPUT_BUFFER.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='STREAMS_ASSOCIATE_ID_INPUT_BUFFER.xml' path='doc/member[@name="STREAMS_ASSOCIATE_ID_INPUT_BUFFER.StreamId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StreamId;
}