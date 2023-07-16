// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class RPI
{
    [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_TIMEWARP 0x00000002")]
    public const int RPI_FLAG_SMB2_SHARECAP_TIMEWARP = 0x00000002;
    [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_DFS 0x00000008")]
    public const int RPI_FLAG_SMB2_SHARECAP_DFS = 0x00000008;
    [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_CONTINUOUS_AVAILABILITY 0x00000010")]
    public const int RPI_FLAG_SMB2_SHARECAP_CONTINUOUS_AVAILABILITY = 0x00000010;
    [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_SCALEOUT 0x00000020")]
    public const int RPI_FLAG_SMB2_SHARECAP_SCALEOUT = 0x00000020;
    [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_CLUSTER 0x00000040")]
    public const int RPI_FLAG_SMB2_SHARECAP_CLUSTER = 0x00000040;
    [NativeTypeName("#define RPI_SMB2_SHAREFLAG_ENCRYPT_DATA 0x00000001")]
    public const int RPI_SMB2_SHAREFLAG_ENCRYPT_DATA = 0x00000001;
    [NativeTypeName("#define RPI_SMB2_SHAREFLAG_COMPRESS_DATA 0x00000002")]
    public const int RPI_SMB2_SHAREFLAG_COMPRESS_DATA = 0x00000002;
    [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_DFS 0x00000001")]
    public const int RPI_SMB2_FLAG_SERVERCAP_DFS = 0x00000001;
    [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_LEASING 0x00000002")]
    public const int RPI_SMB2_FLAG_SERVERCAP_LEASING = 0x00000002;
    [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_LARGEMTU 0x00000004")]
    public const int RPI_SMB2_FLAG_SERVERCAP_LARGEMTU = 0x00000004;
    [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_MULTICHANNEL 0x00000008")]
    public const int RPI_SMB2_FLAG_SERVERCAP_MULTICHANNEL = 0x00000008;
    [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_PERSISTENT_HANDLES 0x00000010")]
    public const int RPI_SMB2_FLAG_SERVERCAP_PERSISTENT_HANDLES = 0x00000010;
    [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_DIRECTORY_LEASING 0x00000020")]
    public const int RPI_SMB2_FLAG_SERVERCAP_DIRECTORY_LEASING = 0x00000020;
}