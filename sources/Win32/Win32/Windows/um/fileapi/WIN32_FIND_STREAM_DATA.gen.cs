// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct WIN32_FIND_STREAM_DATA
{
    public LARGE_INTEGER StreamSize;

    [NativeTypeName("WCHAR[296]")]
    public _cStreamName_e__FixedBuffer cStreamName;

    [InlineArray(296)]
    public partial struct _cStreamName_e__FixedBuffer
    {
        public ushort e0;
    }
}
