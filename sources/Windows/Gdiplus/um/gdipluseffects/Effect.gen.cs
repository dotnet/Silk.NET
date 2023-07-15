// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Gdiplus.Gdiplus;

namespace TerraFX.Interop.Gdiplus;
/// <include file='Effect.xml' path='doc/member[@name="Effect"]/*'/>
public unsafe partial struct Effect : Effect.Interface
{
    public void** lpVtbl;
    /// <include file='Effect.xml' path='doc/member[@name="Effect.nativeEffect"]/*'/>
    [NativeTypeName("Gdiplus::CGpEffect *")]
    public CGpEffect* nativeEffect;
    /// <include file='Effect.xml' path='doc/member[@name="Effect.auxDataSize"]/*'/>
    public int auxDataSize;
    /// <include file='Effect.xml' path='doc/member[@name="Effect.auxData"]/*'/>
    public void* auxData;
    /// <include file='Effect.xml' path='doc/member[@name="Effect.useAuxData"]/*'/>
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
    public GpStatus SetParameters([NativeTypeName("const void *")] void* @params, [NativeTypeName("const UINT")] uint size)
    {
        return GdipSetEffectParameters(nativeEffect, @params, size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public GpStatus GetParameters(uint* size, void* @params)
    {
        return GdipGetEffectParameters(nativeEffect, size, @params);
    }

    /// <include file='Effect.xml' path='doc/member[@name="Effect.Dispose"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void Dispose()
    {
        ((delegate* unmanaged<Effect*, void> )(lpVtbl[0]))((Effect*)Unsafe.AsPointer(ref this));
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