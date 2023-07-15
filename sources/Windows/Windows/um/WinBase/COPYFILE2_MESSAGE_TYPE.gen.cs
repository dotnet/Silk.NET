// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum COPYFILE2_MESSAGE_TYPE
{
    /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_NONE"]/*'/>
    COPYFILE2_CALLBACK_NONE = 0,
    /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_CHUNK_STARTED"]/*'/>
    COPYFILE2_CALLBACK_CHUNK_STARTED,
    /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_CHUNK_FINISHED"]/*'/>
    COPYFILE2_CALLBACK_CHUNK_FINISHED,
    /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_STREAM_STARTED"]/*'/>
    COPYFILE2_CALLBACK_STREAM_STARTED,
    /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_STREAM_FINISHED"]/*'/>
    COPYFILE2_CALLBACK_STREAM_FINISHED,
    /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_POLL_CONTINUE"]/*'/>
    COPYFILE2_CALLBACK_POLL_CONTINUE,
    /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_ERROR"]/*'/>
    COPYFILE2_CALLBACK_ERROR,
    /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_MAX"]/*'/>
    COPYFILE2_CALLBACK_MAX,
}