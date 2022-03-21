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

namespace Silk.NET.DirectStorage
{
    [Guid("6924ea0c-c3cd-4826-b10a-f64f4ed927c1")]
    [NativeName("Name", "IDStorageFactory")]
    public unsafe partial struct IDStorageFactory
    {
        public static readonly Guid Guid = new("6924ea0c-c3cd-4826-b10a-f64f4ed927c1");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDStorageFactory val)
            => Unsafe.As<IDStorageFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDStorageFactory
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
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDStorageFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] QueueDesc* desc, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, desc, riid, ppv);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, desc, riid, ppv);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, desc, riid, ppv);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] QueueDesc* desc, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, desc, riid, ppvPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, desc, riid, ppvPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, desc, riid, ppvPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] QueueDesc* desc, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, desc, riidPtr, ppv);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, desc, riidPtr, ppv);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, desc, riidPtr, ppv);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] QueueDesc* desc, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, desc, riidPtr, ppvPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, desc, riidPtr, ppvPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, desc, riidPtr, ppvPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] in QueueDesc desc, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueueDesc* descPtr = &desc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, descPtr, riid, ppv);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, descPtr, riid, ppv);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, descPtr, riid, ppv);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] in QueueDesc desc, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueueDesc* descPtr = &desc)
            {
                fixed (void** ppvPtr = &ppv)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, descPtr, riid, ppvPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, descPtr, riid, ppvPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, descPtr, riid, ppvPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] in QueueDesc desc, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueueDesc* descPtr = &desc)
            {
                fixed (Guid* riidPtr = &riid)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, descPtr, riidPtr, ppv);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, descPtr, riidPtr, ppv);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, descPtr, riidPtr, ppv);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] in QueueDesc desc, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueueDesc* descPtr = &desc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, descPtr, riidPtr, ppvPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, descPtr, riidPtr, ppvPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)LpVtbl[3])(@this, descPtr, riidPtr, ppvPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(char* path, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, path, riid, ppv);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, path, riid, ppv);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, path, riid, ppv);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(char* path, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, path, riid, ppvPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, path, riid, ppvPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, path, riid, ppvPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(char* path, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, path, riidPtr, ppv);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, path, riidPtr, ppv);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, path, riidPtr, ppv);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(char* path, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, path, riidPtr, ppvPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, path, riidPtr, ppvPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, path, riidPtr, ppvPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(ref char path, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pathPtr = &path)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riid, ppv);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riid, ppv);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riid, ppv);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(ref char path, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pathPtr = &path)
            {
                fixed (void** ppvPtr = &ppv)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riid, ppvPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riid, ppvPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riid, ppvPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(ref char path, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pathPtr = &path)
            {
                fixed (Guid* riidPtr = &riid)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riidPtr, ppv);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riidPtr, ppv);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riidPtr, ppv);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(ref char path, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pathPtr = &path)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riidPtr, ppvPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riidPtr, ppvPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, char*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riidPtr, ppvPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDStorageFactory*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riid, ppv);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riid, ppv);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riid, ppv);
            }
            #endif
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (void** ppvPtr = &ppv)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riid, ppvPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riid, ppvPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riid, ppvPtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riidPtr, ppv);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riidPtr, ppv);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riidPtr, ppv);
                }
            #endif
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageFactory*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riidPtr, ppvPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riidPtr, ppvPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, pathPtr, riidPtr, ppvPtr);
                    }
            #endif
                }
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, byte* name, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, name, riid, ppv);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, name, riid, ppv);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, name, riid, ppv);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, byte* name, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, name, riid, ppvPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, name, riid, ppvPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, name, riid, ppvPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, byte* name, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, name, riidPtr, ppv);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, name, riidPtr, ppv);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, name, riidPtr, ppv);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, byte* name, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, name, riidPtr, ppvPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, name, riidPtr, ppvPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, name, riidPtr, ppvPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, ref byte name, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riid, ppv);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riid, ppv);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riid, ppv);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, ref byte name, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                fixed (void** ppvPtr = &ppv)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riid, ppvPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riid, ppvPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riid, ppvPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, ref byte name, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                fixed (Guid* riidPtr = &riid)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppv);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppv);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppv);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, ref byte name, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppvPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppvPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppvPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riid, ppv);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riid, ppv);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riid, ppv);
            }
            #endif
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (void** ppvPtr = &ppv)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riid, ppvPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riid, ppvPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riid, ppvPtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppv);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppv);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppv);
                }
            #endif
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppvPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppvPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppvPtr);
                    }
            #endif
                }
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDebugFlags(uint flags)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDStorageFactory*, uint, void>)LpVtbl[6])(@this, flags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, void>)LpVtbl[6])(@this, flags);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDStorageFactory*, uint, void>)LpVtbl[6])(@this, flags);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStagingBufferSize(uint size)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDStorageFactory*, uint, int>)LpVtbl[7])(@this, size);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, int>)LpVtbl[7])(@this, size);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDStorageFactory*, uint, int>)LpVtbl[7])(@this, size);
            }
            #endif
            return ret;
        }

    }
}
