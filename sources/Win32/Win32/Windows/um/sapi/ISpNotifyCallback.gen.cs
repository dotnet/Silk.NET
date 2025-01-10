// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct ISpNotifyCallback : ISpNotifyCallback.Interface
{
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT NotifyCallback(WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<ISpNotifyCallback*, WPARAM, LPARAM, int>)((*lpVtbl)[0]))(
            (ISpNotifyCallback*)Unsafe.AsPointer(ref this),
            wParam,
            lParam
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT NotifyCallback(WPARAM wParam, LPARAM lParam);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WPARAM, LPARAM, int> NotifyCallback;
    }
}
