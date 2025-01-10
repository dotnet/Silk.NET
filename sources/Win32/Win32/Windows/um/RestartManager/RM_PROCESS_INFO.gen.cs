// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct RM_PROCESS_INFO
{
    public RM_UNIQUE_PROCESS Process;

    [NativeTypeName("WCHAR[256]")]
    public _strAppName_e__FixedBuffer strAppName;

    [NativeTypeName("WCHAR[64]")]
    public _strServiceShortName_e__FixedBuffer strServiceShortName;
    public RM_APP_TYPE ApplicationType;

    [NativeTypeName("ULONG")]
    public uint AppStatus;

    [NativeTypeName("DWORD")]
    public uint TSSessionId;
    public BOOL bRestartable;

    [InlineArray(256)]
    public partial struct _strAppName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(64)]
    public partial struct _strServiceShortName_e__FixedBuffer
    {
        public ushort e0;
    }
}
