// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE"]/*'/>
public enum MFT_MESSAGE_TYPE
{
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_COMMAND_FLUSH"]/*'/>
    MFT_MESSAGE_COMMAND_FLUSH = 0,
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_COMMAND_DRAIN"]/*'/>
    MFT_MESSAGE_COMMAND_DRAIN = 0x1,
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_SET_D3D_MANAGER"]/*'/>
    MFT_MESSAGE_SET_D3D_MANAGER = 0x2,
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_DROP_SAMPLES"]/*'/>
    MFT_MESSAGE_DROP_SAMPLES = 0x3,
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_COMMAND_TICK"]/*'/>
    MFT_MESSAGE_COMMAND_TICK = 0x4,
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_NOTIFY_BEGIN_STREAMING"]/*'/>
    MFT_MESSAGE_NOTIFY_BEGIN_STREAMING = 0x10000000,
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_NOTIFY_END_STREAMING"]/*'/>
    MFT_MESSAGE_NOTIFY_END_STREAMING = 0x10000001,
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_NOTIFY_END_OF_STREAM"]/*'/>
    MFT_MESSAGE_NOTIFY_END_OF_STREAM = 0x10000002,
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_NOTIFY_START_OF_STREAM"]/*'/>
    MFT_MESSAGE_NOTIFY_START_OF_STREAM = 0x10000003,
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_NOTIFY_RELEASE_RESOURCES"]/*'/>
    MFT_MESSAGE_NOTIFY_RELEASE_RESOURCES = 0x10000004,
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_NOTIFY_REACQUIRE_RESOURCES"]/*'/>
    MFT_MESSAGE_NOTIFY_REACQUIRE_RESOURCES = 0x10000005,
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_NOTIFY_EVENT"]/*'/>
    MFT_MESSAGE_NOTIFY_EVENT = 0x10000006,
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_COMMAND_SET_OUTPUT_STREAM_STATE"]/*'/>
    MFT_MESSAGE_COMMAND_SET_OUTPUT_STREAM_STATE = 0x10000007,
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_COMMAND_FLUSH_OUTPUT_STREAM"]/*'/>
    MFT_MESSAGE_COMMAND_FLUSH_OUTPUT_STREAM = 0x10000008,
    /// <include file='MFT_MESSAGE_TYPE.xml' path='doc/member[@name="MFT_MESSAGE_TYPE.MFT_MESSAGE_COMMAND_MARKER"]/*'/>
    MFT_MESSAGE_COMMAND_MARKER = 0x20000000,
}