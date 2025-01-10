// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SP_SELECTDEVICE_PARAMS_A
{
    public SP_CLASSINSTALL_HEADER ClassInstallHeader;

    [NativeTypeName("CHAR[60]")]
    public _Title_e__FixedBuffer Title;

    [NativeTypeName("CHAR[256]")]
    public _Instructions_e__FixedBuffer Instructions;

    [NativeTypeName("CHAR[30]")]
    public _ListLabel_e__FixedBuffer ListLabel;

    [NativeTypeName("CHAR[256]")]
    public _SubTitle_e__FixedBuffer SubTitle;

    [NativeTypeName("BYTE[2]")]
    public _Reserved_e__FixedBuffer Reserved;

    [InlineArray(60)]
    public partial struct _Title_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(256)]
    public partial struct _Instructions_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(30)]
    public partial struct _ListLabel_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(256)]
    public partial struct _SubTitle_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(2)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
