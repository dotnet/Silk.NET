// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [Guid("e467b94e-a713-4562-a802-816a42e9008a")]
    [NativeName("Name", "IMFMediaSourceExtension")]
    public unsafe partial struct IMFMediaSourceExtension : IComVtbl<IMFMediaSourceExtension>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("e467b94e-a713-4562-a802-816a42e9008a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaSourceExtension val)
            => Unsafe.As<IMFMediaSourceExtension, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaSourceExtension
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IMFSourceBufferList* GetSourceBuffers()
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IMFSourceBufferList* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, IMFSourceBufferList*>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IMFSourceBufferList* GetActiveSourceBuffers()
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IMFSourceBufferList* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, IMFSourceBufferList*>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly MseReady GetReadyState()
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            MseReady ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, MseReady>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetDuration()
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, double>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDuration(double duration)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, double, int>)@this->LpVtbl[7])(@this, duration);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer(char* type, IMFSourceBufferNotify* pNotify, IMFSourceBuffer** ppSourceBuffer)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, type, pNotify, ppSourceBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer(char* type, IMFSourceBufferNotify* pNotify, ref IMFSourceBuffer* ppSourceBuffer)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFSourceBuffer** ppSourceBufferPtr = &ppSourceBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, type, pNotify, ppSourceBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer(char* type, ref IMFSourceBufferNotify pNotify, IMFSourceBuffer** ppSourceBuffer)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFSourceBufferNotify* pNotifyPtr = &pNotify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, type, pNotifyPtr, ppSourceBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer(char* type, ref IMFSourceBufferNotify pNotify, ref IMFSourceBuffer* ppSourceBuffer)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFSourceBufferNotify* pNotifyPtr = &pNotify)
            {
                fixed (IMFSourceBuffer** ppSourceBufferPtr = &ppSourceBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, type, pNotifyPtr, ppSourceBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer(ref char type, IMFSourceBufferNotify* pNotify, IMFSourceBuffer** ppSourceBuffer)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotify, ppSourceBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer(ref char type, IMFSourceBufferNotify* pNotify, ref IMFSourceBuffer* ppSourceBuffer)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
                fixed (IMFSourceBuffer** ppSourceBufferPtr = &ppSourceBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotify, ppSourceBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer(ref char type, ref IMFSourceBufferNotify pNotify, IMFSourceBuffer** ppSourceBuffer)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
                fixed (IMFSourceBufferNotify* pNotifyPtr = &pNotify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotifyPtr, ppSourceBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer(ref char type, ref IMFSourceBufferNotify pNotify, ref IMFSourceBuffer* ppSourceBuffer)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
                fixed (IMFSourceBufferNotify* pNotifyPtr = &pNotify)
                {
                    fixed (IMFSourceBuffer** ppSourceBufferPtr = &ppSourceBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotifyPtr, ppSourceBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, IMFSourceBufferNotify* pNotify, IMFSourceBuffer** ppSourceBuffer)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, byte*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotify, ppSourceBuffer);
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, IMFSourceBufferNotify* pNotify, ref IMFSourceBuffer* ppSourceBuffer)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            fixed (IMFSourceBuffer** ppSourceBufferPtr = &ppSourceBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, byte*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotify, ppSourceBufferPtr);
            }
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref IMFSourceBufferNotify pNotify, IMFSourceBuffer** ppSourceBuffer)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            fixed (IMFSourceBufferNotify* pNotifyPtr = &pNotify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, byte*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotifyPtr, ppSourceBuffer);
            }
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref IMFSourceBufferNotify pNotify, ref IMFSourceBuffer* ppSourceBuffer)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            fixed (IMFSourceBufferNotify* pNotifyPtr = &pNotify)
            {
                fixed (IMFSourceBuffer** ppSourceBufferPtr = &ppSourceBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, byte*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotifyPtr, ppSourceBufferPtr);
                }
            }
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RemoveSourceBuffer(IMFSourceBuffer* pSourceBuffer)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, IMFSourceBuffer*, int>)@this->LpVtbl[9])(@this, pSourceBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveSourceBuffer(ref IMFSourceBuffer pSourceBuffer)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFSourceBuffer* pSourceBufferPtr = &pSourceBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, IMFSourceBuffer*, int>)@this->LpVtbl[9])(@this, pSourceBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetEndOfStream(MseError error)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, MseError, int>)@this->LpVtbl[10])(@this, error);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe Silk.NET.Core.Bool32 IsTypeSupported(char* type)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, Silk.NET.Core.Bool32>)@this->LpVtbl[11])(@this, type);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsTypeSupported(ref char type)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            fixed (char* typePtr = &type)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, Silk.NET.Core.Bool32>)@this->LpVtbl[11])(@this, typePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsTypeSupported([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, byte*, Silk.NET.Core.Bool32>)@this->LpVtbl[11])(@this, typePtr);
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IMFSourceBuffer* GetSourceBuffer(uint dwStreamIndex)
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IMFSourceBuffer* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, uint, IMFSourceBuffer*>)@this->LpVtbl[12])(@this, dwStreamIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer<TI0, TI1>(char* type, ComPtr<TI0> pNotify, ref ComPtr<TI1> ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBufferNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFSourceBuffer>, IComVtbl<TI1>
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddSourceBuffer(type, (IMFSourceBufferNotify*) pNotify.Handle, (IMFSourceBuffer**) ppSourceBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer<TI0>(char* type, ComPtr<TI0> pNotify, ref IMFSourceBuffer* ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBufferNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddSourceBuffer(type, (IMFSourceBufferNotify*) pNotify.Handle, ref ppSourceBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer<TI0>(char* type, ref IMFSourceBufferNotify pNotify, ref ComPtr<TI0> ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBuffer>, IComVtbl<TI0>
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddSourceBuffer(type, ref pNotify, (IMFSourceBuffer**) ppSourceBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int AddSourceBuffer<TI0, TI1>(ref char type, ComPtr<TI0> pNotify, ref ComPtr<TI1> ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBufferNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFSourceBuffer>, IComVtbl<TI1>
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddSourceBuffer(ref type, (IMFSourceBufferNotify*) pNotify.Handle, (IMFSourceBuffer**) ppSourceBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer<TI0>(ref char type, ComPtr<TI0> pNotify, ref IMFSourceBuffer* ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBufferNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddSourceBuffer(ref type, (IMFSourceBufferNotify*) pNotify.Handle, ref ppSourceBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly int AddSourceBuffer<TI0>(ref char type, ref IMFSourceBufferNotify pNotify, ref ComPtr<TI0> ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBuffer>, IComVtbl<TI0>
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddSourceBuffer(ref type, ref pNotify, (IMFSourceBuffer**) ppSourceBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int AddSourceBuffer<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ComPtr<TI0> pNotify, ref ComPtr<TI1> ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBufferNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFSourceBuffer>, IComVtbl<TI1>
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddSourceBuffer(type, (IMFSourceBufferNotify*) pNotify.Handle, (IMFSourceBuffer**) ppSourceBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSourceBuffer<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ComPtr<TI0> pNotify, ref IMFSourceBuffer* ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBufferNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddSourceBuffer(type, (IMFSourceBufferNotify*) pNotify.Handle, ref ppSourceBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly int AddSourceBuffer<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref IMFSourceBufferNotify pNotify, ref ComPtr<TI0> ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBuffer>, IComVtbl<TI0>
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddSourceBuffer(type, ref pNotify, (IMFSourceBuffer**) ppSourceBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveSourceBuffer<TI0>(ComPtr<TI0> pSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBuffer>, IComVtbl<TI0>
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RemoveSourceBuffer((IMFSourceBuffer*) pSourceBuffer.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaSourceExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
