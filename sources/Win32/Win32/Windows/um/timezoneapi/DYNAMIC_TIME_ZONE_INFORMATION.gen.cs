// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/timezoneapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DYNAMIC_TIME_ZONE_INFORMATION
{
    [NativeTypeName("LONG")]
    public int Bias;

    [NativeTypeName("WCHAR[32]")]
    public _StandardName_e__FixedBuffer StandardName;
    public SYSTEMTIME StandardDate;

    [NativeTypeName("LONG")]
    public int StandardBias;

    [NativeTypeName("WCHAR[32]")]
    public _DaylightName_e__FixedBuffer DaylightName;
    public SYSTEMTIME DaylightDate;

    [NativeTypeName("LONG")]
    public int DaylightBias;

    [NativeTypeName("WCHAR[128]")]
    public _TimeZoneKeyName_e__FixedBuffer TimeZoneKeyName;

    [NativeTypeName("BOOLEAN")]
    public byte DynamicDaylightTimeDisabled;

    [InlineArray(32)]
    public partial struct _StandardName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(32)]
    public partial struct _DaylightName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(128)]
    public partial struct _TimeZoneKeyName_e__FixedBuffer
    {
        public ushort e0;
    }
}
