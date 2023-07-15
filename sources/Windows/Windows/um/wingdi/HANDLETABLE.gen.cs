// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='HANDLETABLE.xml' path='doc/member[@name="HANDLETABLE"]/*'/>
public partial struct HANDLETABLE
{
    /// <include file='HANDLETABLE.xml' path='doc/member[@name="HANDLETABLE.objectHandle"]/*'/>
    [NativeTypeName("HGDIOBJ[1]")]
    public _objectHandle_e__FixedBuffer objectHandle;
    /// <include file='_objectHandle_e__FixedBuffer.xml' path='doc/member[@name="_objectHandle_e__FixedBuffer"]/*'/>
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