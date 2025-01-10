// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT
{
    [NativeTypeName("DWORDLONG")]
    public ulong VetoedFromAltitudeIntegral;

    [NativeTypeName("DWORDLONG")]
    public ulong VetoedFromAltitudeDecimal;

    [NativeTypeName("WCHAR[256]")]
    public _Reason_e__FixedBuffer Reason;

    [InlineArray(256)]
    public partial struct _Reason_e__FixedBuffer
    {
        public ushort e0;
    }
}
