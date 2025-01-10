// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
using static Silk.NET.Gdiplus.Gdiplus;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public unsafe partial struct Effect : Effect.Interface
{
    public void*** lpVtbl;

    [NativeTypeName("Gdiplus::CGpEffect *")]
    public CGpEffect* nativeEffect;
    public int auxDataSize;
    public void* auxData;
    public BOOL useAuxData;

    public int GetAuxDataSize()
    {
        return auxDataSize;
    }

    public void* GetAuxData()
    {
        return auxData;
    }

    public void UseAuxData([NativeTypeName("const BOOL")] BOOL useAuxDataFlag)
    {
        useAuxData = useAuxDataFlag;
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public GpStatus GetParameterSize(uint* size)
    {
        return GdipGetEffectParameterSize(nativeEffect, size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public GpStatus SetParameters(
        [NativeTypeName("const void *")] void* @params,
        [NativeTypeName("const UINT")] uint size
    )
    {
        return GdipSetEffectParameters(nativeEffect, @params, size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public GpStatus GetParameters(uint* size, void* @params)
    {
        return GdipGetEffectParameters(nativeEffect, size, @params);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void Dispose()
    {
        ((delegate* unmanaged<Effect*, void>)((*lpVtbl)[0]))((Effect*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        void Dispose();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged<TSelf*, void> Dispose;
    }
}
