// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='IXAudio2EngineCallback.xml' path='doc/member[@name="IXAudio2EngineCallback"]/*'/>
public unsafe partial struct IXAudio2EngineCallback : IXAudio2EngineCallback.Interface
{
    public void** lpVtbl;
    /// <include file='IXAudio2EngineCallback.xml' path='doc/member[@name="IXAudio2EngineCallback.OnProcessingPassStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void OnProcessingPassStart()
    {
        ((delegate* unmanaged<IXAudio2EngineCallback*, void> )(lpVtbl[0]))((IXAudio2EngineCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXAudio2EngineCallback.xml' path='doc/member[@name="IXAudio2EngineCallback.OnProcessingPassEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void OnProcessingPassEnd()
    {
        ((delegate* unmanaged<IXAudio2EngineCallback*, void> )(lpVtbl[1]))((IXAudio2EngineCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXAudio2EngineCallback.xml' path='doc/member[@name="IXAudio2EngineCallback.OnCriticalError"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void OnCriticalError(HRESULT Error)
    {
        ((delegate* unmanaged<IXAudio2EngineCallback*, HRESULT, void> )(lpVtbl[2]))((IXAudio2EngineCallback*)Unsafe.AsPointer(ref this), Error);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        void OnProcessingPassStart();
        [VtblIndex(1)]
        void OnProcessingPassEnd();
        [VtblIndex(2)]
        void OnCriticalError(HRESULT Error);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> OnProcessingPassStart;
        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> OnProcessingPassEnd;
        [NativeTypeName("void (HRESULT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, void> OnCriticalError;
    }
}