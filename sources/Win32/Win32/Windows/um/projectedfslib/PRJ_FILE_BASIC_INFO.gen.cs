// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct PRJ_FILE_BASIC_INFO
{
    [NativeTypeName("BOOLEAN")]
    public byte IsDirectory;

    [NativeTypeName("INT64")]
    public long FileSize;
    public LARGE_INTEGER CreationTime;
    public LARGE_INTEGER LastAccessTime;
    public LARGE_INTEGER LastWriteTime;
    public LARGE_INTEGER ChangeTime;

    [NativeTypeName("UINT32")]
    public uint FileAttributes;
}
