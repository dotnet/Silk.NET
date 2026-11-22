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
    [Guid("2f69d622-20b5-41e9-afdf-89ced1dda04e")]
    [NativeName("Name", "IMFMediaEngineExtension")]
    public unsafe partial struct IMFMediaEngineExtension : IComVtbl<IMFMediaEngineExtension>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("2f69d622-20b5-41e9-afdf-89ced1dda04e");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaEngineExtension val)
            => Unsafe.As<IMFMediaEngineExtension, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaEngineExtension
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
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanPlayType(Silk.NET.Core.Bool32 AudioOnly, char* MimeType, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Bool32, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, AudioOnly, MimeType, pAnswer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanPlayType(Silk.NET.Core.Bool32 AudioOnly, char* MimeType, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Bool32, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, AudioOnly, MimeType, pAnswerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanPlayType(Silk.NET.Core.Bool32 AudioOnly, ref char MimeType, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* MimeTypePtr = &MimeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Bool32, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, AudioOnly, MimeTypePtr, pAnswer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CanPlayType(Silk.NET.Core.Bool32 AudioOnly, ref char MimeType, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* MimeTypePtr = &MimeType)
            {
                fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Bool32, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, AudioOnly, MimeTypePtr, pAnswerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanPlayType(Silk.NET.Core.Bool32 AudioOnly, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string MimeType, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var MimeTypePtr = (byte*) SilkMarshal.StringToPtr(MimeType, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Bool32, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, AudioOnly, MimeTypePtr, pAnswer);
            SilkMarshal.Free((nint)MimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CanPlayType(Silk.NET.Core.Bool32 AudioOnly, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string MimeType, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var MimeTypePtr = (byte*) SilkMarshal.StringToPtr(MimeType, NativeStringEncoding.BStr);
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Bool32, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, AudioOnly, MimeTypePtr, pAnswerPtr);
            }
            SilkMarshal.Free((nint)MimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookie, pCallbackPtr, punkState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookie, pCallbackPtr, punkStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookiePtr, pCallback, punkState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookiePtr, pCallback, punkStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallback, punkState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallback, punkStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallbackPtr, punkState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallbackPtr, punkStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallback, punkState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallback, punkStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkState);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                    {
                        fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkStatePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallbackPtr, punkState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallbackPtr, punkStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallback, punkState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallback, punkStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkState);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                    {
                        fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkStatePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallback, punkState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallback, punkStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
                {
                    fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallbackPtr, punkState);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
                {
                    fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                    {
                        fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallbackPtr, punkStatePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
                {
                    fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallback, punkState);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
                {
                    fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                    {
                        fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallback, punkStatePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
                {
                    fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                    {
                        fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkState);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject(ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrURLPtr = &bstrURL)
            {
                fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
                {
                    fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                    {
                        fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                        {
                            fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkStatePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkState);
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkStatePtr);
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallbackPtr, punkState);
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallbackPtr, punkStatePtr);
                }
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallback, punkState);
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallback, punkStatePtr);
                }
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkState);
                }
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkStatePtr);
                    }
                }
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallback, punkState);
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallback, punkStatePtr);
                }
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallbackPtr, punkState);
                }
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallbackPtr, punkStatePtr);
                    }
                }
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallback, punkState);
                }
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallback, punkStatePtr);
                    }
                }
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkState);
                    }
                }
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                    {
                        fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkStatePtr);
                        }
                    }
                }
            }
            SilkMarshal.Free((nint)bstrURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CancelObjectCreation(Silk.NET.Core.Native.IUnknown* pIUnknownCancelCookie)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, pIUnknownCancelCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CancelObjectCreation(ref Silk.NET.Core.Native.IUnknown pIUnknownCancelCookie)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pIUnknownCancelCookiePtr = &pIUnknownCancelCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, pIUnknownCancelCookiePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndCreateObject(IMFAsyncResult* pResult, Silk.NET.Core.Native.IUnknown** ppObject)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, IMFAsyncResult*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pResult, ppObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndCreateObject(IMFAsyncResult* pResult, ref Silk.NET.Core.Native.IUnknown* ppObject)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppObjectPtr = &ppObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, IMFAsyncResult*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pResult, ppObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndCreateObject(ref IMFAsyncResult pResult, Silk.NET.Core.Native.IUnknown** ppObject)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFAsyncResult* pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, IMFAsyncResult*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pResultPtr, ppObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndCreateObject(ref IMFAsyncResult pResult, ref Silk.NET.Core.Native.IUnknown* ppObject)
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFAsyncResult* pResultPtr = &pResult)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppObjectPtr = &ppObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, IMFAsyncResult*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pResultPtr, ppObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0, TI1>(char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, ref punkState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0, TI1>(char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, ref punkState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0, TI1>(char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, ref punkState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0, TI1>(char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, ref punkState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, ref pByteStream, type, ref ppIUnknownCancelCookie, pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, ref pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0, TI1>(ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(ref bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(ref bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, ref punkState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0, TI1>(ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(ref bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(ref bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, ref punkState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(ref bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(ref bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0, TI1>(ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(ref bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(ref bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, ref punkState);
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginCreateObject<TI0, TI1>(ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(ref bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginCreateObject<TI0>(ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(ref bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, ref punkState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(ref bstrURL, ref pByteStream, type, ref ppIUnknownCancelCookie, pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>(ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(ref bstrURL, ref pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, ref punkState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, ref punkState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, ref punkState);
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginCreateObject<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginCreateObject<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, ref punkState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, ref pByteStream, type, ref ppIUnknownCancelCookie, pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginCreateObject<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginCreateObject(bstrURL, ref pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int CancelObjectCreation<TI0>(ComPtr<TI0> pIUnknownCancelCookie) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CancelObjectCreation((Silk.NET.Core.Native.IUnknown*) pIUnknownCancelCookie.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndCreateObject<TI0>(IMFAsyncResult* pResult, ref ComPtr<TI0> ppObject) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EndCreateObject(pResult, (Silk.NET.Core.Native.IUnknown**) ppObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int EndCreateObject<TI0>(ref IMFAsyncResult pResult, ref ComPtr<TI0> ppObject) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EndCreateObject(ref pResult, (Silk.NET.Core.Native.IUnknown**) ppObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
