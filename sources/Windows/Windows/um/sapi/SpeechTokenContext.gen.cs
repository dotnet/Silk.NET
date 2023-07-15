// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.CLSCTX;

namespace TerraFX.Interop.Windows;
/// <include file='SpeechTokenContext.xml' path='doc/member[@name="SpeechTokenContext"]/*'/>
public enum SpeechTokenContext
{
    /// <include file='SpeechTokenContext.xml' path='doc/member[@name="SpeechTokenContext.STCInprocServer"]/*'/>
    STCInprocServer = CLSCTX_INPROC_SERVER,
    /// <include file='SpeechTokenContext.xml' path='doc/member[@name="SpeechTokenContext.STCInprocHandler"]/*'/>
    STCInprocHandler = CLSCTX_INPROC_HANDLER,
    /// <include file='SpeechTokenContext.xml' path='doc/member[@name="SpeechTokenContext.STCLocalServer"]/*'/>
    STCLocalServer = CLSCTX_LOCAL_SERVER,
    /// <include file='SpeechTokenContext.xml' path='doc/member[@name="SpeechTokenContext.STCRemoteServer"]/*'/>
    STCRemoteServer = CLSCTX_REMOTE_SERVER,
    /// <include file='SpeechTokenContext.xml' path='doc/member[@name="SpeechTokenContext.STCAll"]/*'/>
    STCAll = (((CLSCTX_INPROC_SERVER | CLSCTX_INPROC_HANDLER) | CLSCTX_LOCAL_SERVER) | CLSCTX_REMOTE_SERVER),
}