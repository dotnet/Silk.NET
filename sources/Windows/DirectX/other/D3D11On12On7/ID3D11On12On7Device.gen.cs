// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D11On12On7.h in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License
using Silk.NET.Windows;
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;
/// <include file='ID3D11On12On7Device.xml' path='doc/member[@name="ID3D11On12On7Device"]/*'/>
public unsafe partial struct ID3D11On12On7Device : ID3D11On12On7Device.Interface
{
    public void** lpVtbl;
    /// <include file='ID3D11On12On7Device.xml' path='doc/member[@name="ID3D11On12On7Device.AcquireResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT AcquireResource([NativeTypeName("ID3D11On12On7Resource*")] void* pResource, D3D12_RESOURCE_STATES state)
    {
        return ((delegate* unmanaged<ID3D11On12On7Device*, void*, D3D12_RESOURCE_STATES, int> )(lpVtbl[0]))((ID3D11On12On7Device*)Unsafe.AsPointer(ref this), pResource, state);
    }

    /// <include file='ID3D11On12On7Device.xml' path='doc/member[@name="ID3D11On12On7Device.ReleaseResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT ReleaseResource([NativeTypeName("ID3D11On12On7Resource*")] void* pResource, D3D12_RESOURCE_STATES state)
    {
        return ((delegate* unmanaged<ID3D11On12On7Device*, void*, D3D12_RESOURCE_STATES, int> )(lpVtbl[1]))((ID3D11On12On7Device*)Unsafe.AsPointer(ref this), pResource, state);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT AcquireResource([NativeTypeName("ID3D11On12On7Resource*")] void* pResource, D3D12_RESOURCE_STATES state);
        [VtblIndex(1)]
        HRESULT ReleaseResource([NativeTypeName("ID3D11On12On7Resource*")] void* pResource, D3D12_RESOURCE_STATES state);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (ID3D11On12On7Resource *, D3D12_RESOURCE_STATES) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, D3D12_RESOURCE_STATES, int> AcquireResource;
        [NativeTypeName("HRESULT (ID3D11On12On7Resource *, D3D12_RESOURCE_STATES) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, D3D12_RESOURCE_STATES, int> ReleaseResource;
    }
}