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
    [Guid("332ec562-3758-468d-a784-e38f23552128")]
    [NativeName("Name", "IMFExtendedDRMTypeSupport")]
    public unsafe partial struct IMFExtendedDRMTypeSupport : IComVtbl<IMFExtendedDRMTypeSupport>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("332ec562-3758-468d-a784-e38f23552128");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFExtendedDRMTypeSupport val)
            => Unsafe.As<IMFExtendedDRMTypeSupport, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFExtendedDRMTypeSupport
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
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupportedEx(char* type, char* keySystem, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, type, keySystem, pAnswer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupportedEx(char* type, char* keySystem, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, type, keySystem, pAnswerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupportedEx(char* type, ref char keySystem, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, type, keySystemPtr, pAnswer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupportedEx(char* type, ref char keySystem, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, type, keySystemPtr, pAnswerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupportedEx(char* type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, type, keySystemPtr, pAnswer);
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupportedEx(char* type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, type, keySystemPtr, pAnswerPtr);
            }
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupportedEx(ref char type, char* keySystem, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystem, pAnswer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupportedEx(ref char type, char* keySystem, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
                fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystem, pAnswerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupportedEx(ref char type, ref char keySystem, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
                fixed (char* keySystemPtr = &keySystem)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsTypeSupportedEx(ref char type, ref char keySystem, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
                fixed (char* keySystemPtr = &keySystem)
                {
                    fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswerPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupportedEx(ref char type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswer);
            SilkMarshal.Free((nint)keySystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsTypeSupportedEx(ref char type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswerPtr);
                }
            SilkMarshal.Free((nint)keySystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupportedEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, char* keySystem, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, byte*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystem, pAnswer);
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupportedEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, char* keySystem, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, byte*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystem, pAnswerPtr);
            }
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupportedEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref char keySystem, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, byte*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswer);
            }
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsTypeSupportedEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref char keySystem, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, byte*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswerPtr);
                }
            }
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupportedEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, byte*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswer);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsTypeSupportedEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, byte*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswerPtr);
            }
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFExtendedDRMTypeSupport*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
