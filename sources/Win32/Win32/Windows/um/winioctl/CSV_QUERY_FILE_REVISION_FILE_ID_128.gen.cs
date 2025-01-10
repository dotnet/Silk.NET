// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CSV_QUERY_FILE_REVISION_FILE_ID_128
{
    public FILE_ID_128 FileId;

    [NativeTypeName("LONGLONG[3]")]
    public _FileRevision_e__FixedBuffer FileRevision;

    [InlineArray(3)]
    public partial struct _FileRevision_e__FixedBuffer
    {
        public long e0;
    }
}
