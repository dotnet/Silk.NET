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
    [Guid("654a6bb3-e1a3-424a-9908-53a43a0dfda0")]
    [NativeName("Name", "IMFMediaEngineSrcElementsEx")]
    public unsafe partial struct IMFMediaEngineSrcElementsEx : IComVtbl<IMFMediaEngineSrcElementsEx>, IComVtbl<IMFMediaEngineSrcElements>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("654a6bb3-e1a3-424a-9908-53a43a0dfda0");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IMFMediaEngineSrcElements(IMFMediaEngineSrcElementsEx val)
            => Unsafe.As<IMFMediaEngineSrcElementsEx, IMFMediaEngineSrcElements>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaEngineSrcElementsEx val)
            => Unsafe.As<IMFMediaEngineSrcElementsEx, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaEngineSrcElementsEx
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
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetLength()
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetURL(uint index, char** pURL)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint, char**, int>)@this->LpVtbl[4])(@this, index, pURL);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetURL(uint index, ref char* pURL)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pURLPtr = &pURL)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint, char**, int>)@this->LpVtbl[4])(@this, index, pURLPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetType(uint index, char** pType)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint, char**, int>)@this->LpVtbl[5])(@this, index, pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetType(uint index, ref char* pType)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint, char**, int>)@this->LpVtbl[5])(@this, index, pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMedia(uint index, char** pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint, char**, int>)@this->LpVtbl[6])(@this, index, pMedia);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMedia(uint index, ref char* pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pMediaPtr = &pMedia)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint, char**, int>)@this->LpVtbl[6])(@this, index, pMediaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement(char* pURL, char* pType, char* pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURL, pType, pMedia);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement(char* pURL, char* pType, ref char pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pMediaPtr = &pMedia)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURL, pType, pMediaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement(char* pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, int>)@this->LpVtbl[7])(@this, pURL, pType, pMediaPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement(char* pURL, ref char pType, char* pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURL, pTypePtr, pMedia);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement(char* pURL, ref char pType, ref char pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTypePtr = &pType)
            {
                fixed (char* pMediaPtr = &pMedia)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURL, pTypePtr, pMediaPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement(char* pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTypePtr = &pType)
            {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, int>)@this->LpVtbl[7])(@this, pURL, pTypePtr, pMediaPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement(char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, int>)@this->LpVtbl[7])(@this, pURL, pTypePtr, pMedia);
            SilkMarshal.Free((nint)pTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement(char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            fixed (char* pMediaPtr = &pMedia)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, int>)@this->LpVtbl[7])(@this, pURL, pTypePtr, pMediaPtr);
            }
            SilkMarshal.Free((nint)pTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement(char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, byte*, int>)@this->LpVtbl[7])(@this, pURL, pTypePtr, pMediaPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement(ref char pURL, char* pType, char* pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pType, pMedia);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement(ref char pURL, char* pType, ref char pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pMediaPtr = &pMedia)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pType, pMediaPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement(ref char pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, int>)@this->LpVtbl[7])(@this, pURLPtr, pType, pMediaPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement(ref char pURL, ref char pType, char* pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pTypePtr = &pType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMedia);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElement(ref char pURL, ref char pType, ref char pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pTypePtr = &pType)
                {
                    fixed (char* pMediaPtr = &pMedia)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElement(ref char pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pTypePtr = &pType)
                {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
            SilkMarshal.Free((nint)pMediaPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement(ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMedia);
            SilkMarshal.Free((nint)pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElement(ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
                fixed (char* pMediaPtr = &pMedia)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
                }
            SilkMarshal.Free((nint)pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElement(ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, byte*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, char* pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pType, pMedia);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, ref char pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pMediaPtr = &pMedia)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pType, pMediaPtr);
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, byte*, int>)@this->LpVtbl[7])(@this, pURLPtr, pType, pMediaPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, char* pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMedia);
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElement([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, ref char pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pTypePtr = &pType)
            {
                fixed (char* pMediaPtr = &pMedia)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
                }
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElement([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pTypePtr = &pType)
            {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, byte*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElement([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, byte*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMedia);
            SilkMarshal.Free((nint)pTypePtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElement([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            fixed (char* pMediaPtr = &pMedia)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, byte*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
            }
            SilkMarshal.Free((nint)pTypePtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElement([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, byte*, byte*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pTypePtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveAllElements()
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, int>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, char* pType, char* pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURL, pType, pMedia, keySystem);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, char* pType, char* pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURL, pType, pMedia, keySystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, char* pType, char* pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURL, pType, pMedia, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, char* pType, ref char pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pMediaPtr = &pMedia)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURL, pType, pMediaPtr, keySystem);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, char* pType, ref char pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pMediaPtr = &pMedia)
            {
                fixed (char* keySystemPtr = &keySystem)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURL, pType, pMediaPtr, keySystemPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, char* pType, ref char pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pMediaPtr = &pMedia)
            {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURL, pType, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURL, pType, pMediaPtr, keySystem);
            SilkMarshal.Free((nint)pMediaPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURL, pType, pMediaPtr, keySystemPtr);
            }
            SilkMarshal.Free((nint)pMediaPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, byte*, int>)@this->LpVtbl[9])(@this, pURL, pType, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, ref char pType, char* pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMedia, keySystem);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, ref char pType, char* pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTypePtr = &pType)
            {
                fixed (char* keySystemPtr = &keySystem)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMedia, keySystemPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, ref char pType, char* pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTypePtr = &pType)
            {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMedia, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, ref char pType, ref char pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTypePtr = &pType)
            {
                fixed (char* pMediaPtr = &pMedia)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMediaPtr, keySystem);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, ref char pType, ref char pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTypePtr = &pType)
            {
                fixed (char* pMediaPtr = &pMedia)
                {
                    fixed (char* keySystemPtr = &keySystem)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMediaPtr, keySystemPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, ref char pType, ref char pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTypePtr = &pType)
            {
                fixed (char* pMediaPtr = &pMedia)
                {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTypePtr = &pType)
            {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMediaPtr, keySystem);
            SilkMarshal.Free((nint)pMediaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTypePtr = &pType)
            {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                fixed (char* keySystemPtr = &keySystem)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMediaPtr, keySystemPtr);
                }
            SilkMarshal.Free((nint)pMediaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTypePtr = &pType)
            {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, byte*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, char*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMedia, keySystem);
            SilkMarshal.Free((nint)pTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, char*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMedia, keySystemPtr);
            }
            SilkMarshal.Free((nint)pTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMedia, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)pTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            fixed (char* pMediaPtr = &pMedia)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, char*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMediaPtr, keySystem);
            }
            SilkMarshal.Free((nint)pTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            fixed (char* pMediaPtr = &pMedia)
            {
                fixed (char* keySystemPtr = &keySystem)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, char*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMediaPtr, keySystemPtr);
                }
            }
            SilkMarshal.Free((nint)pTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            fixed (char* pMediaPtr = &pMedia)
            {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            }
            SilkMarshal.Free((nint)pTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMediaPtr, keySystem);
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMediaPtr, keySystemPtr);
            }
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, byte*, byte*, int>)@this->LpVtbl[9])(@this, pURL, pTypePtr, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, char* pType, char* pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMedia, keySystem);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, char* pType, char* pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* keySystemPtr = &keySystem)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMedia, keySystemPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, char* pType, char* pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMedia, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, char* pType, ref char pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pMediaPtr = &pMedia)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMediaPtr, keySystem);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, char* pType, ref char pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pMediaPtr = &pMedia)
                {
                    fixed (char* keySystemPtr = &keySystem)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMediaPtr, keySystemPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, char* pType, ref char pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pMediaPtr = &pMedia)
                {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMediaPtr, keySystem);
            SilkMarshal.Free((nint)pMediaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                fixed (char* keySystemPtr = &keySystem)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMediaPtr, keySystemPtr);
                }
            SilkMarshal.Free((nint)pMediaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, ref char pType, char* pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pTypePtr = &pType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMedia, keySystem);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, ref char pType, char* pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pTypePtr = &pType)
                {
                    fixed (char* keySystemPtr = &keySystem)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMedia, keySystemPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, ref char pType, char* pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pTypePtr = &pType)
                {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMedia, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, ref char pType, ref char pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pTypePtr = &pType)
                {
                    fixed (char* pMediaPtr = &pMedia)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystem);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx(ref char pURL, ref char pType, ref char pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pTypePtr = &pType)
                {
                    fixed (char* pMediaPtr = &pMedia)
                    {
                        fixed (char* keySystemPtr = &keySystem)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx(ref char pURL, ref char pType, ref char pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pTypePtr = &pType)
                {
                    fixed (char* pMediaPtr = &pMedia)
                    {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pTypePtr = &pType)
                {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystem);
            SilkMarshal.Free((nint)pMediaPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx(ref char pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pTypePtr = &pType)
                {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                    fixed (char* keySystemPtr = &keySystem)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
                    }
            SilkMarshal.Free((nint)pMediaPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx(ref char pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                fixed (char* pTypePtr = &pType)
                {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, char*, byte*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)pMediaPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMedia, keySystem);
            SilkMarshal.Free((nint)pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
                fixed (char* keySystemPtr = &keySystem)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMedia, keySystemPtr);
                }
            SilkMarshal.Free((nint)pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMedia, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
                fixed (char* pMediaPtr = &pMedia)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystem);
                }
            SilkMarshal.Free((nint)pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx(ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
                fixed (char* pMediaPtr = &pMedia)
                {
                    fixed (char* keySystemPtr = &keySystem)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
                    }
                }
            SilkMarshal.Free((nint)pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx(ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
                fixed (char* pMediaPtr = &pMedia)
                {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
                }
            SilkMarshal.Free((nint)pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx(ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystem);
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx(ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                fixed (char* keySystemPtr = &keySystem)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
                }
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx(ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, char*, byte*, byte*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, char* pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMedia, keySystem);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, char* pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMedia, keySystemPtr);
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, char* pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMedia, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, ref char pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pMediaPtr = &pMedia)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMediaPtr, keySystem);
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, ref char pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pMediaPtr = &pMedia)
            {
                fixed (char* keySystemPtr = &keySystem)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMediaPtr, keySystemPtr);
                }
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, ref char pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pMediaPtr = &pMedia)
            {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMediaPtr, keySystem);
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMediaPtr, keySystemPtr);
            }
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, byte*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pType, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, char* pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMedia, keySystem);
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, char* pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pTypePtr = &pType)
            {
                fixed (char* keySystemPtr = &keySystem)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMedia, keySystemPtr);
                }
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, char* pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pTypePtr = &pType)
            {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMedia, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, ref char pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pTypePtr = &pType)
            {
                fixed (char* pMediaPtr = &pMedia)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystem);
                }
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, ref char pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pTypePtr = &pType)
            {
                fixed (char* pMediaPtr = &pMedia)
                {
                    fixed (char* keySystemPtr = &keySystem)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, ref char pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pTypePtr = &pType)
            {
                fixed (char* pMediaPtr = &pMedia)
                {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
                }
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pTypePtr = &pType)
            {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystem);
            SilkMarshal.Free((nint)pMediaPtr);
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pTypePtr = &pType)
            {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                fixed (char* keySystemPtr = &keySystem)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
                }
            SilkMarshal.Free((nint)pMediaPtr);
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            fixed (char* pTypePtr = &pType)
            {
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, char*, byte*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            }
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, byte*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMedia, keySystem);
            SilkMarshal.Free((nint)pTypePtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, byte*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMedia, keySystemPtr);
            }
            SilkMarshal.Free((nint)pTypePtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, byte*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMedia, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)pTypePtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            fixed (char* pMediaPtr = &pMedia)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, byte*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystem);
            }
            SilkMarshal.Free((nint)pTypePtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            fixed (char* pMediaPtr = &pMedia)
            {
                fixed (char* keySystemPtr = &keySystem)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, byte*, char*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
                }
            }
            SilkMarshal.Free((nint)pTypePtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            fixed (char* pMediaPtr = &pMedia)
            {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, byte*, char*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            }
            SilkMarshal.Free((nint)pTypePtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, char* keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, byte*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystem);
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pTypePtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, ref char keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, byte*, byte*, char*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
            }
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pTypePtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddElementEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, byte*, byte*, byte*, byte*, int>)@this->LpVtbl[9])(@this, pURLPtr, pTypePtr, pMediaPtr, keySystemPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)pMediaPtr);
            SilkMarshal.Free((nint)pTypePtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeySystem(uint index, char** pType)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint, char**, int>)@this->LpVtbl[10])(@this, index, pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeySystem(uint index, ref char* pType)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint, char**, int>)@this->LpVtbl[10])(@this, index, pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetURL(uint index, string[] pURLSa)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pURL = (char**) SilkMarshal.StringArrayToPtr(pURLSa);
            var ret = @this->GetURL(index, pURL);
            SilkMarshal.CopyPtrToStringArray((nint) pURL, pURLSa);
            SilkMarshal.Free((nint) pURL);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetType(uint index, string[] pTypeSa)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pType = (char**) SilkMarshal.StringArrayToPtr(pTypeSa);
            var ret = @this->GetType(index, pType);
            SilkMarshal.CopyPtrToStringArray((nint) pType, pTypeSa);
            SilkMarshal.Free((nint) pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMedia(uint index, string[] pMediaSa)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pMedia = (char**) SilkMarshal.StringArrayToPtr(pMediaSa);
            var ret = @this->GetMedia(index, pMedia);
            SilkMarshal.CopyPtrToStringArray((nint) pMedia, pMediaSa);
            SilkMarshal.Free((nint) pMedia);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetKeySystem(uint index, string[] pTypeSa)
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pType = (char**) SilkMarshal.StringArrayToPtr(pTypeSa);
            var ret = @this->GetKeySystem(index, pType);
            SilkMarshal.CopyPtrToStringArray((nint) pType, pTypeSa);
            SilkMarshal.Free((nint) pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineSrcElementsEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
