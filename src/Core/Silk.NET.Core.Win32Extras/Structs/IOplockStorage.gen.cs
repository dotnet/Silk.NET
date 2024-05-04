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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("8d19c834-8879-11d1-83e9-00c04fc2c6d4")]
    [NativeName("Name", "IOplockStorage")]
    public unsafe partial struct IOplockStorage : IComVtbl<IOplockStorage>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("8d19c834-8879-11d1-83e9-00c04fc2c6d4");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IOplockStorage val)
            => Unsafe.As<IOplockStorage, Silk.NET.Core.Native.IUnknown>(ref val);

        public IOplockStorage
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
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, void** ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, ref void* ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppstgOpenPtr = &ppstgOpen)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpenPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, void** ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpen);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, ref void* ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppstgOpenPtr = &ppstgOpen)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, void** ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pwcsNamePtr = &pwcsName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, ref void* ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pwcsNamePtr = &pwcsName)
            {
                fixed (void** ppstgOpenPtr = &ppstgOpen)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, void** ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pwcsNamePtr = &pwcsName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpen);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, ref void* ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pwcsNamePtr = &pwcsName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppstgOpenPtr = &ppstgOpen)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpenPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, void** ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
            SilkMarshal.Free((nint)pwcsNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, ref void* ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
            fixed (void** ppstgOpenPtr = &ppstgOpen)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpenPtr);
            }
            SilkMarshal.Free((nint)pwcsNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, void** ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpen);
            }
            SilkMarshal.Free((nint)pwcsNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, ref void* ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppstgOpenPtr = &ppstgOpen)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpenPtr);
                }
            }
            SilkMarshal.Free((nint)pwcsNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, void** ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, ref void* ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppstgOpenPtr = &ppstgOpen)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpenPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, void** ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpen);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, ref void* ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppstgOpenPtr = &ppstgOpen)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, void** ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pwcsNamePtr = &pwcsName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, ref void* ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pwcsNamePtr = &pwcsName)
            {
                fixed (void** ppstgOpenPtr = &ppstgOpen)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, void** ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pwcsNamePtr = &pwcsName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpen);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, ref void* ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pwcsNamePtr = &pwcsName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppstgOpenPtr = &ppstgOpen)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpenPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, void** ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
            SilkMarshal.Free((nint)pwcsNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, ref void* ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
            fixed (void** ppstgOpenPtr = &ppstgOpen)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpenPtr);
            }
            SilkMarshal.Free((nint)pwcsNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, void** ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpen);
            }
            SilkMarshal.Free((nint)pwcsNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenStorageEx([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, ref void* ppstgOpen)
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppstgOpenPtr = &ppstgOpen)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpenPtr);
                }
            }
            SilkMarshal.Free((nint)pwcsNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStorageEx<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, out ComPtr<TI0> ppstgOpen) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppstgOpen = default;
            return @this->CreateStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppstgOpen.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateStorageEx<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, out ComPtr<TI0> ppstgOpen) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppstgOpen = default;
            return @this->CreateStorageEx(in pwcsName, grfMode, stgfmt, grfAttrs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppstgOpen.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateStorageEx<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, out ComPtr<TI0> ppstgOpen) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppstgOpen = default;
            return @this->CreateStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppstgOpen.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenStorageEx<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, out ComPtr<TI0> ppstgOpen) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppstgOpen = default;
            return @this->OpenStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppstgOpen.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int OpenStorageEx<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, out ComPtr<TI0> ppstgOpen) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppstgOpen = default;
            return @this->OpenStorageEx(in pwcsName, grfMode, stgfmt, grfAttrs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppstgOpen.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int OpenStorageEx<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, out ComPtr<TI0> ppstgOpen) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppstgOpen = default;
            return @this->OpenStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppstgOpen.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateStorageEx<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateStorageEx<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateStorageEx(in pwcsName, grfMode, stgfmt, grfAttrs, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateStorageEx<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> OpenStorageEx<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->OpenStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> OpenStorageEx<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->OpenStorageEx(in pwcsName, grfMode, stgfmt, grfAttrs, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> OpenStorageEx<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOplockStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->OpenStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
