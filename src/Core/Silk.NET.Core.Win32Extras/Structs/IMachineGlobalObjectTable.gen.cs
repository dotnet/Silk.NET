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
    [Guid("26d709ac-f70b-4421-a96f-d2878fafb00d")]
    [NativeName("Name", "IMachineGlobalObjectTable")]
    public unsafe partial struct IMachineGlobalObjectTable
    {
        public static readonly Guid Guid = new("26d709ac-f70b-4421-a96f-d2878fafb00d");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMachineGlobalObjectTable val)
            => Unsafe.As<IMachineGlobalObjectTable, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMachineGlobalObjectTable
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
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, char* identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsid, identifier, @object, token);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, char* identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsid, identifier, @object, tokenPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, char* identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsid, identifier, @objectPtr, token);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, char* identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
            {
                fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsid, identifier, @objectPtr, tokenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, ref char identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsid, identifierPtr, @object, token);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, ref char identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsid, identifierPtr, @object, tokenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, ref char identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsid, identifierPtr, @objectPtr, token);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, ref char identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                {
                    fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsid, identifierPtr, @objectPtr, tokenPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsid, identifierPtr, @object, token);
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsid, identifierPtr, @object, tokenPtr);
            }
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsid, identifierPtr, @objectPtr, token);
            }
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
            {
                fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsid, identifierPtr, @objectPtr, tokenPtr);
                }
            }
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, char* identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsidPtr, identifier, @object, token);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, char* identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsidPtr, identifier, @object, tokenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, char* identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsidPtr, identifier, @objectPtr, token);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, char* identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                {
                    fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsidPtr, identifier, @objectPtr, tokenPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, ref char identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (char* identifierPtr = &identifier)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsidPtr, identifierPtr, @object, token);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, ref char identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (char* identifierPtr = &identifier)
                {
                    fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsidPtr, identifierPtr, @object, tokenPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, ref char identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (char* identifierPtr = &identifier)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsidPtr, identifierPtr, @objectPtr, token);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, ref char identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (char* identifierPtr = &identifier)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                    {
                        fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsidPtr, identifierPtr, @objectPtr, tokenPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsidPtr, identifierPtr, @object, token);
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
                fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsidPtr, identifierPtr, @object, tokenPtr);
                }
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
                fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsidPtr, identifierPtr, @objectPtr, token);
                }
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
                fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                {
                    fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)LpVtbl[3])(@this, clsidPtr, identifierPtr, @objectPtr, tokenPtr);
                    }
                }
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, char* identifier, Guid* riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsid, identifier, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, char* identifier, Guid* riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsid, identifier, riid, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, char* identifier, ref Guid riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsid, identifier, riidPtr, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, char* identifier, ref Guid riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsid, identifier, riidPtr, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, ref char identifier, Guid* riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsid, identifierPtr, riid, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, ref char identifier, Guid* riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsid, identifierPtr, riid, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, ref char identifier, ref Guid riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsid, identifierPtr, riidPtr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, ref char identifier, ref Guid riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsid, identifierPtr, riidPtr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Guid* riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, clsid, identifierPtr, riid, ppv);
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Guid* riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, clsid, identifierPtr, riid, ppvPtr);
            }
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Guid riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, clsid, identifierPtr, riidPtr, ppv);
            }
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Guid riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, clsid, identifierPtr, riidPtr, ppvPtr);
                }
            }
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, char* identifier, Guid* riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsidPtr, identifier, riid, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, char* identifier, Guid* riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsidPtr, identifier, riid, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, char* identifier, ref Guid riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsidPtr, identifier, riidPtr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, char* identifier, ref Guid riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsidPtr, identifier, riidPtr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, ref char identifier, Guid* riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (char* identifierPtr = &identifier)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsidPtr, identifierPtr, riid, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, ref char identifier, Guid* riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (char* identifierPtr = &identifier)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsidPtr, identifierPtr, riid, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, ref char identifier, ref Guid riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (char* identifierPtr = &identifier)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsidPtr, identifierPtr, riidPtr, ppv);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, ref char identifier, ref Guid riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (char* identifierPtr = &identifier)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvPtr = &ppv)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)LpVtbl[4])(@this, clsidPtr, identifierPtr, riidPtr, ppvPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Guid* riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, clsidPtr, identifierPtr, riid, ppv);
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Guid* riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, clsidPtr, identifierPtr, riid, ppvPtr);
                }
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Guid riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, clsidPtr, identifierPtr, riidPtr, ppv);
                }
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Guid riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)LpVtbl[4])(@this, clsidPtr, identifierPtr, riidPtr, ppvPtr);
                    }
                }
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RevokeObject(MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, MachineGlobalObjectTableRegistrationToken*, int>)LpVtbl[5])(@this, token);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RevokeObject(ref MachineGlobalObjectTableRegistrationToken token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MachineGlobalObjectTableRegistrationToken* tokenPtr = &token)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, MachineGlobalObjectTableRegistrationToken*, int>)LpVtbl[5])(@this, tokenPtr);
            }
            return ret;
        }

    }
}
