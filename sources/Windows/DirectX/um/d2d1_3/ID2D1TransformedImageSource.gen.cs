// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1TransformedImageSource.xml' path='doc/member[@name="ID2D1TransformedImageSource"]/*'/>
[Guid("7F1F79E5-2796-416C-8F55-700F911445E5")]
[NativeTypeName("struct ID2D1TransformedImageSource : ID2D1Image")]
[NativeInheritance("ID2D1Image")]
public unsafe partial struct ID2D1TransformedImageSource : ID2D1TransformedImageSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1TransformedImageSource));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1TransformedImageSource*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1TransformedImageSource*, uint> )(lpVtbl[1]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1TransformedImageSource*, uint> )(lpVtbl[2]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Resource.GetFactory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1TransformedImageSource*, ID2D1Factory**, void> )(lpVtbl[3]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), factory);
    }

    /// <include file='ID2D1TransformedImageSource.xml' path='doc/member[@name="ID2D1TransformedImageSource.GetSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void GetSource(ID2D1ImageSource** imageSource)
    {
        ((delegate* unmanaged<ID2D1TransformedImageSource*, ID2D1ImageSource**, void> )(lpVtbl[4]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), imageSource);
    }

    /// <include file='ID2D1TransformedImageSource.xml' path='doc/member[@name="ID2D1TransformedImageSource.GetProperties"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void GetProperties(D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties)
    {
        ((delegate* unmanaged<ID2D1TransformedImageSource*, D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*, void> )(lpVtbl[5]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), properties);
    }

    public interface Interface : ID2D1Image.Interface
    {
        [VtblIndex(4)]
        void GetSource(ID2D1ImageSource** imageSource);
        [VtblIndex(5)]
        void GetProperties(D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Factory**, void> GetFactory;
        [NativeTypeName("void (ID2D1ImageSource **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1ImageSource**, void> GetSource;
        [NativeTypeName("void (D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*, void> GetProperties;
    }
}