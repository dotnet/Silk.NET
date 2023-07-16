// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DVD_CMD_FLAGS.xml' path='doc/member[@name="DVD_CMD_FLAGS"]/*'/>
public enum DVD_CMD_FLAGS
{
    /// <include file='DVD_CMD_FLAGS.xml' path='doc/member[@name="DVD_CMD_FLAGS.DVD_CMD_FLAG_None"]/*'/>
    DVD_CMD_FLAG_None = 0,
    /// <include file='DVD_CMD_FLAGS.xml' path='doc/member[@name="DVD_CMD_FLAGS.DVD_CMD_FLAG_Flush"]/*'/>
    DVD_CMD_FLAG_Flush = 0x1,
    /// <include file='DVD_CMD_FLAGS.xml' path='doc/member[@name="DVD_CMD_FLAGS.DVD_CMD_FLAG_SendEvents"]/*'/>
    DVD_CMD_FLAG_SendEvents = 0x2,
    /// <include file='DVD_CMD_FLAGS.xml' path='doc/member[@name="DVD_CMD_FLAGS.DVD_CMD_FLAG_Block"]/*'/>
    DVD_CMD_FLAG_Block = 0x4,
    /// <include file='DVD_CMD_FLAGS.xml' path='doc/member[@name="DVD_CMD_FLAGS.DVD_CMD_FLAG_StartWhenRendered"]/*'/>
    DVD_CMD_FLAG_StartWhenRendered = 0x8,
    /// <include file='DVD_CMD_FLAGS.xml' path='doc/member[@name="DVD_CMD_FLAGS.DVD_CMD_FLAG_EndAfterRendered"]/*'/>
    DVD_CMD_FLAG_EndAfterRendered = 0x10,
}