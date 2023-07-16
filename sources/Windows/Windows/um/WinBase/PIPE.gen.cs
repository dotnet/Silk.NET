// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class PIPE
{
    [NativeTypeName("#define PIPE_ACCESS_INBOUND 0x00000001")]
    public const int PIPE_ACCESS_INBOUND = 0x00000001;
    [NativeTypeName("#define PIPE_ACCESS_OUTBOUND 0x00000002")]
    public const int PIPE_ACCESS_OUTBOUND = 0x00000002;
    [NativeTypeName("#define PIPE_ACCESS_DUPLEX 0x00000003")]
    public const int PIPE_ACCESS_DUPLEX = 0x00000003;
    [NativeTypeName("#define PIPE_CLIENT_END 0x00000000")]
    public const int PIPE_CLIENT_END = 0x00000000;
    [NativeTypeName("#define PIPE_SERVER_END 0x00000001")]
    public const int PIPE_SERVER_END = 0x00000001;
    [NativeTypeName("#define PIPE_WAIT 0x00000000")]
    public const int PIPE_WAIT = 0x00000000;
    [NativeTypeName("#define PIPE_NOWAIT 0x00000001")]
    public const int PIPE_NOWAIT = 0x00000001;
    [NativeTypeName("#define PIPE_READMODE_BYTE 0x00000000")]
    public const int PIPE_READMODE_BYTE = 0x00000000;
    [NativeTypeName("#define PIPE_READMODE_MESSAGE 0x00000002")]
    public const int PIPE_READMODE_MESSAGE = 0x00000002;
    [NativeTypeName("#define PIPE_TYPE_BYTE 0x00000000")]
    public const int PIPE_TYPE_BYTE = 0x00000000;
    [NativeTypeName("#define PIPE_TYPE_MESSAGE 0x00000004")]
    public const int PIPE_TYPE_MESSAGE = 0x00000004;
    [NativeTypeName("#define PIPE_ACCEPT_REMOTE_CLIENTS 0x00000000")]
    public const int PIPE_ACCEPT_REMOTE_CLIENTS = 0x00000000;
    [NativeTypeName("#define PIPE_REJECT_REMOTE_CLIENTS 0x00000008")]
    public const int PIPE_REJECT_REMOTE_CLIENTS = 0x00000008;
    [NativeTypeName("#define PIPE_UNLIMITED_INSTANCES 255")]
    public const int PIPE_UNLIMITED_INSTANCES = 255;
}