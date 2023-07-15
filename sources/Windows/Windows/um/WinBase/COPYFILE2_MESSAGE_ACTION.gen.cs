// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='COPYFILE2_MESSAGE_ACTION.xml' path='doc/member[@name="COPYFILE2_MESSAGE_ACTION"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum COPYFILE2_MESSAGE_ACTION
{
    /// <include file='COPYFILE2_MESSAGE_ACTION.xml' path='doc/member[@name="COPYFILE2_MESSAGE_ACTION.COPYFILE2_PROGRESS_CONTINUE"]/*'/>
    COPYFILE2_PROGRESS_CONTINUE = 0,
    /// <include file='COPYFILE2_MESSAGE_ACTION.xml' path='doc/member[@name="COPYFILE2_MESSAGE_ACTION.COPYFILE2_PROGRESS_CANCEL"]/*'/>
    COPYFILE2_PROGRESS_CANCEL,
    /// <include file='COPYFILE2_MESSAGE_ACTION.xml' path='doc/member[@name="COPYFILE2_MESSAGE_ACTION.COPYFILE2_PROGRESS_STOP"]/*'/>
    COPYFILE2_PROGRESS_STOP,
    /// <include file='COPYFILE2_MESSAGE_ACTION.xml' path='doc/member[@name="COPYFILE2_MESSAGE_ACTION.COPYFILE2_PROGRESS_QUIET"]/*'/>
    COPYFILE2_PROGRESS_QUIET,
    /// <include file='COPYFILE2_MESSAGE_ACTION.xml' path='doc/member[@name="COPYFILE2_MESSAGE_ACTION.COPYFILE2_PROGRESS_PAUSE"]/*'/>
    COPYFILE2_PROGRESS_PAUSE,
}