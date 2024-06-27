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
    public unsafe partial struct IMachineGlobalObjectTable : IComVtbl<IMachineGlobalObjectTable>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("26d709ac-f70b-4421-a96f-d2878fafb00d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

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
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifier, @object, token);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifier, @object, tokenPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifier, @objectPtr, token);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
            {
                fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifier, @objectPtr, tokenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @object, token);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @object, tokenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @objectPtr, token);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                {
                    fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @objectPtr, tokenPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @object, token);
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @object, tokenPtr);
            }
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @objectPtr, token);
            }
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
            {
                fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @objectPtr, tokenPtr);
                }
            }
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifier, @object, token);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifier, @object, tokenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifier, @objectPtr, token);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                {
                    fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifier, @objectPtr, tokenPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (char* identifierPtr = &identifier)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @object, token);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (char* identifierPtr = &identifier)
                {
                    fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @object, tokenPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (char* identifierPtr = &identifier)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @objectPtr, token);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
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
                            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @objectPtr, tokenPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @object, token);
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
                fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @object, tokenPtr);
                }
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
                fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @objectPtr, token);
                }
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
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
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @objectPtr, tokenPtr);
                    }
                }
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Guid* riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifier, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Guid* riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifier, riid, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Guid riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifier, riidPtr, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Guid riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifier, riidPtr, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Guid* riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riid, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Guid* riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riid, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Guid riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riidPtr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Guid riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* identifierPtr = &identifier)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riidPtr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Guid* riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riid, ppv);
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Guid* riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riid, ppvPtr);
            }
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Guid riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riidPtr, ppv);
            }
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Guid riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riidPtr, ppvPtr);
                }
            }
            SilkMarshal.Free((nint)identifierPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Guid* riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifier, riid, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Guid* riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifier, riid, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Guid riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifier, riidPtr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Guid riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifier, riidPtr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Guid* riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (char* identifierPtr = &identifier)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riid, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Guid* riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (char* identifierPtr = &identifier)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riid, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Guid riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (char* identifierPtr = &identifier)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riidPtr, ppv);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Guid riid, ref void* ppv)
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
                            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riidPtr, ppvPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Guid* riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riid, ppv);
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Guid* riid, ref void* ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riid, ppvPtr);
                }
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Guid riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
            var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riidPtr, ppv);
                }
            SilkMarshal.Free((nint)identifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Guid riid, ref void* ppv)
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
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riidPtr, ppvPtr);
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
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, MachineGlobalObjectTableRegistrationToken*, int>)@this->LpVtbl[5])(@this, token);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RevokeObject(ref MachineGlobalObjectTableRegistrationToken token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MachineGlobalObjectTableRegistrationToken* tokenPtr = &token)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, MachineGlobalObjectTableRegistrationToken*, int>)@this->LpVtbl[5])(@this, tokenPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject<TI0>(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ComPtr<TI0> @object, MachineGlobalObjectTableRegistrationToken** token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObject(clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, token);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject<TI0>(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ComPtr<TI0> @object, ref MachineGlobalObjectTableRegistrationToken* token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObject(clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, ref token);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject<TI0>(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ComPtr<TI0> @object, MachineGlobalObjectTableRegistrationToken** token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObject(clsid, in identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, token);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject<TI0>(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ComPtr<TI0> @object, ref MachineGlobalObjectTableRegistrationToken* token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObject(clsid, in identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, ref token);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject<TI0>(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ComPtr<TI0> @object, MachineGlobalObjectTableRegistrationToken** token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObject(clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, token);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject<TI0>(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ComPtr<TI0> @object, ref MachineGlobalObjectTableRegistrationToken* token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObject(clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, ref token);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject<TI0>(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ComPtr<TI0> @object, MachineGlobalObjectTableRegistrationToken** token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObject(ref clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, token);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject<TI0>(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ComPtr<TI0> @object, ref MachineGlobalObjectTableRegistrationToken* token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObject(ref clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, ref token);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject<TI0>(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ComPtr<TI0> @object, MachineGlobalObjectTableRegistrationToken** token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObject(ref clsid, in identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, token);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject<TI0>(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ComPtr<TI0> @object, ref MachineGlobalObjectTableRegistrationToken* token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObject(ref clsid, in identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, ref token);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject<TI0>(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ComPtr<TI0> @object, MachineGlobalObjectTableRegistrationToken** token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObject(ref clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, token);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject<TI0>(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ComPtr<TI0> @object, ref MachineGlobalObjectTableRegistrationToken* token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObject(ref clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, ref token);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA<TI0>(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->GetObjectA(clsid, identifier, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA<TI0>(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->GetObjectA(clsid, in identifier, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA<TI0>(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->GetObjectA(clsid, identifier, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA<TI0>(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->GetObjectA(ref clsid, identifier, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetObjectA<TI0>(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->GetObjectA(ref clsid, in identifier, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetObjectA<TI0>(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->GetObjectA(ref clsid, identifier, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> GetObjectA<TI0>(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetObjectA(clsid, identifier, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> GetObjectA<TI0>(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetObjectA(clsid, in identifier, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> GetObjectA<TI0>(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetObjectA(clsid, identifier, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> GetObjectA<TI0>(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetObjectA(ref clsid, identifier, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetObjectA<TI0>(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetObjectA(ref clsid, in identifier, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetObjectA<TI0>(ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetObjectA(ref clsid, identifier, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
