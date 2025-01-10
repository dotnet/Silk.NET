// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FS_BPIO_RESULTS
{
    [NativeTypeName("DWORD")]
    public uint OpStatus;

    [NativeTypeName("WORD")]
    public ushort FailingDriverNameLen;

    [NativeTypeName("WCHAR[32]")]
    public _FailingDriverName_e__FixedBuffer FailingDriverName;

    [NativeTypeName("WORD")]
    public ushort FailureReasonLen;

    [NativeTypeName("WCHAR[128]")]
    public _FailureReason_e__FixedBuffer FailureReason;

    [InlineArray(32)]
    public partial struct _FailingDriverName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(128)]
    public partial struct _FailureReason_e__FixedBuffer
    {
        public ushort e0;
    }
}
