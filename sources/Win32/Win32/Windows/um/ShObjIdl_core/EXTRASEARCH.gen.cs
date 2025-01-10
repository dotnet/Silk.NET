// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct EXTRASEARCH
{
    public Guid guidSearch;

    [NativeTypeName("WCHAR[80]")]
    public _wszFriendlyName_e__FixedBuffer wszFriendlyName;

    [NativeTypeName("WCHAR[2084]")]
    public _wszUrl_e__FixedBuffer wszUrl;

    [InlineArray(80)]
    public partial struct _wszFriendlyName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(2084)]
    public partial struct _wszUrl_e__FixedBuffer
    {
        public ushort e0;
    }
}
