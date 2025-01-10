// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.CLSCTX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SpeechTokenContext
{
    STCInprocServer = CLSCTX_INPROC_SERVER,
    STCInprocHandler = CLSCTX_INPROC_HANDLER,
    STCLocalServer = CLSCTX_LOCAL_SERVER,
    STCRemoteServer = CLSCTX_REMOTE_SERVER,
    STCAll =
        (
            ((CLSCTX_INPROC_SERVER | CLSCTX_INPROC_HANDLER) | CLSCTX_LOCAL_SERVER)
            | CLSCTX_REMOTE_SERVER
        ),
}
