// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;
/// <include file='GdiplusAbort.xml' path='doc/member[@name="GdiplusAbort"]/*'/>
public unsafe partial struct GdiplusAbort : GdiplusAbort.Interface
{
    public void** lpVtbl;
    /// <include file='GdiplusAbort.xml' path='doc/member[@name="GdiplusAbort.Abort"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT Abort()
    {
        return ((delegate* unmanaged<GdiplusAbort*, int> )(lpVtbl[0]))((GdiplusAbort*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT Abort();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Abort;
    }
}