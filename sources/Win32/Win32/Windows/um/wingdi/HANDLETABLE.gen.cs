// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct HANDLETABLE
{
    [NativeTypeName("HGDIOBJ[1]")]
    public _objectHandle_e__FixedBuffer objectHandle;

    public unsafe partial struct _objectHandle_e__FixedBuffer
    {
        public HGDIOBJ e0;
        public ref HGDIOBJ this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (HGDIOBJ* pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
