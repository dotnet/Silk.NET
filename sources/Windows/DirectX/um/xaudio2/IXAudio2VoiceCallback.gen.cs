// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='IXAudio2VoiceCallback.xml' path='doc/member[@name="IXAudio2VoiceCallback"]/*'/>
public unsafe partial struct IXAudio2VoiceCallback : IXAudio2VoiceCallback.Interface
{
    public void** lpVtbl;
    /// <include file='IXAudio2VoiceCallback.xml' path='doc/member[@name="IXAudio2VoiceCallback.OnVoiceProcessingPassStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void OnVoiceProcessingPassStart([NativeTypeName("UINT32")] uint BytesRequired)
    {
        ((delegate* unmanaged<IXAudio2VoiceCallback*, uint, void> )(lpVtbl[0]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), BytesRequired);
    }

    /// <include file='IXAudio2VoiceCallback.xml' path='doc/member[@name="IXAudio2VoiceCallback.OnVoiceProcessingPassEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void OnVoiceProcessingPassEnd()
    {
        ((delegate* unmanaged<IXAudio2VoiceCallback*, void> )(lpVtbl[1]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXAudio2VoiceCallback.xml' path='doc/member[@name="IXAudio2VoiceCallback.OnStreamEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void OnStreamEnd()
    {
        ((delegate* unmanaged<IXAudio2VoiceCallback*, void> )(lpVtbl[2]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXAudio2VoiceCallback.xml' path='doc/member[@name="IXAudio2VoiceCallback.OnBufferStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void OnBufferStart(void* pBufferContext)
    {
        ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, void> )(lpVtbl[3]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
    }

    /// <include file='IXAudio2VoiceCallback.xml' path='doc/member[@name="IXAudio2VoiceCallback.OnBufferEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void OnBufferEnd(void* pBufferContext)
    {
        ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, void> )(lpVtbl[4]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
    }

    /// <include file='IXAudio2VoiceCallback.xml' path='doc/member[@name="IXAudio2VoiceCallback.OnLoopEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void OnLoopEnd(void* pBufferContext)
    {
        ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, void> )(lpVtbl[5]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
    }

    /// <include file='IXAudio2VoiceCallback.xml' path='doc/member[@name="IXAudio2VoiceCallback.OnVoiceError"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void OnVoiceError(void* pBufferContext, HRESULT Error)
    {
        ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, HRESULT, void> )(lpVtbl[6]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext, Error);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        void OnVoiceProcessingPassStart([NativeTypeName("UINT32")] uint BytesRequired);
        [VtblIndex(1)]
        void OnVoiceProcessingPassEnd();
        [VtblIndex(2)]
        void OnStreamEnd();
        [VtblIndex(3)]
        void OnBufferStart(void* pBufferContext);
        [VtblIndex(4)]
        void OnBufferEnd(void* pBufferContext);
        [VtblIndex(5)]
        void OnLoopEnd(void* pBufferContext);
        [VtblIndex(6)]
        void OnVoiceError(void* pBufferContext, HRESULT Error);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> OnVoiceProcessingPassStart;
        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> OnVoiceProcessingPassEnd;
        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> OnStreamEnd;
        [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, void> OnBufferStart;
        [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, void> OnBufferEnd;
        [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, void> OnLoopEnd;
        [NativeTypeName("void (void *, HRESULT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, HRESULT, void> OnVoiceError;
    }
}