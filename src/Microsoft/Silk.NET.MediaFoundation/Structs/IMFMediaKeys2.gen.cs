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
    [Guid("45892507-ad66-4de2-83a2-acbb13cd8d43")]
    [NativeName("Name", "IMFMediaKeys2")]
    public unsafe partial struct IMFMediaKeys2 : IComVtbl<IMFMediaKeys2>, IComVtbl<IMFMediaKeys>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("45892507-ad66-4de2-83a2-acbb13cd8d43");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IMFMediaKeys(IMFMediaKeys2 val)
            => Unsafe.As<IMFMediaKeys2, IMFMediaKeys>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaKeys2 val)
            => Unsafe.As<IMFMediaKeys2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaKeys2
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
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customData, cbCustomData, notify, ppSession);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customData, cbCustomData, notify, ppSessionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customData, cbCustomData, notifyPtr, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* customDataPtr = &customData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
            SilkMarshal.Free((nint)customDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
            SilkMarshal.Free((nint)customDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)customDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
            }
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
            }
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            }
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notify, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notify, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notifyPtr, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    fixed (byte* customDataPtr = &customData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    fixed (byte* customDataPtr = &customData)
                    {
                        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    fixed (byte* customDataPtr = &customData)
                    {
                        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    fixed (byte* customDataPtr = &customData)
                    {
                        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                        {
                            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                    }
            SilkMarshal.Free((nint)customDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                    }
            SilkMarshal.Free((nint)customDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                        }
                    }
            SilkMarshal.Free((nint)customDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
                }
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
                }
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                fixed (byte* customDataPtr = &customData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
                }
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                    }
                }
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                    }
                }
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                        }
                    }
                }
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notify, ppSessionPtr);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notifyPtr, ppSession);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* customDataPtr = &customData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                    }
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                        }
                    }
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
            }
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
            }
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            }
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeySystem(char** keySystem)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char**, int>)@this->LpVtbl[4])(@this, keySystem);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeySystem(ref char* keySystem)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char**, int>)@this->LpVtbl[4])(@this, keySystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Shutdown()
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, int>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSuspendNotify(IMFCdmSuspendNotify** notify)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, IMFCdmSuspendNotify**, int>)@this->LpVtbl[6])(@this, notify);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSuspendNotify(ref IMFCdmSuspendNotify* notify)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFCdmSuspendNotify** notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, IMFCdmSuspendNotify**, int>)@this->LpVtbl[6])(@this, notifyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession2(MF_MEDIAKEYSESSION_TYPE eSessionType, IMFMediaKeySessionNotify2* pMFMediaKeySessionNotify2, IMFMediaKeySession2** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, MF_MEDIAKEYSESSION_TYPE, IMFMediaKeySessionNotify2*, IMFMediaKeySession2**, int>)@this->LpVtbl[7])(@this, eSessionType, pMFMediaKeySessionNotify2, ppSession);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession2(MF_MEDIAKEYSESSION_TYPE eSessionType, IMFMediaKeySessionNotify2* pMFMediaKeySessionNotify2, ref IMFMediaKeySession2* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaKeySession2** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, MF_MEDIAKEYSESSION_TYPE, IMFMediaKeySessionNotify2*, IMFMediaKeySession2**, int>)@this->LpVtbl[7])(@this, eSessionType, pMFMediaKeySessionNotify2, ppSessionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession2(MF_MEDIAKEYSESSION_TYPE eSessionType, ref IMFMediaKeySessionNotify2 pMFMediaKeySessionNotify2, IMFMediaKeySession2** ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaKeySessionNotify2* pMFMediaKeySessionNotify2Ptr = &pMFMediaKeySessionNotify2)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, MF_MEDIAKEYSESSION_TYPE, IMFMediaKeySessionNotify2*, IMFMediaKeySession2**, int>)@this->LpVtbl[7])(@this, eSessionType, pMFMediaKeySessionNotify2Ptr, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession2(MF_MEDIAKEYSESSION_TYPE eSessionType, ref IMFMediaKeySessionNotify2 pMFMediaKeySessionNotify2, ref IMFMediaKeySession2* ppSession)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaKeySessionNotify2* pMFMediaKeySessionNotify2Ptr = &pMFMediaKeySessionNotify2)
            {
                fixed (IMFMediaKeySession2** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, MF_MEDIAKEYSESSION_TYPE, IMFMediaKeySessionNotify2*, IMFMediaKeySession2**, int>)@this->LpVtbl[7])(@this, eSessionType, pMFMediaKeySessionNotify2Ptr, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetServerCertificate([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbServerCertificate, uint cb)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, uint, int>)@this->LpVtbl[8])(@this, pbServerCertificate, cb);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetServerCertificate([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbServerCertificate, uint cb)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbServerCertificatePtr = &pbServerCertificate)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, uint, int>)@this->LpVtbl[8])(@this, pbServerCertificatePtr, cb);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetServerCertificate([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbServerCertificate, uint cb)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbServerCertificatePtr = (byte*) SilkMarshal.StringToPtr(pbServerCertificate, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, uint, int>)@this->LpVtbl[8])(@this, pbServerCertificatePtr, cb);
            SilkMarshal.Free((nint)pbServerCertificatePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDOMException(int systemCode, int* code)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, int, int*, int>)@this->LpVtbl[9])(@this, systemCode, code);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDOMException(int systemCode, ref int code)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* codePtr = &code)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, int, int*, int>)@this->LpVtbl[9])(@this, systemCode, codePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetKeySystem(string[] keySystemSa)
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var keySystem = (char**) SilkMarshal.StringArrayToPtr(keySystemSa);
            var ret = @this->GetKeySystem(keySystem);
            SilkMarshal.CopyPtrToStringArray((nint) keySystem, keySystemSa);
            SilkMarshal.Free((nint) keySystem);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSuspendNotify<TI0>(ref ComPtr<TI0> notify) where TI0 : unmanaged, IComVtbl<IMFCdmSuspendNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSuspendNotify((IMFCdmSuspendNotify**) notify.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession2<TI0, TI1>(MF_MEDIAKEYSESSION_TYPE eSessionType, ComPtr<TI0> pMFMediaKeySessionNotify2, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify2>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession2>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession2(eSessionType, (IMFMediaKeySessionNotify2*) pMFMediaKeySessionNotify2.Handle, (IMFMediaKeySession2**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession2<TI0>(MF_MEDIAKEYSESSION_TYPE eSessionType, ComPtr<TI0> pMFMediaKeySessionNotify2, ref IMFMediaKeySession2* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify2>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession2(eSessionType, (IMFMediaKeySessionNotify2*) pMFMediaKeySessionNotify2.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession2<TI0>(MF_MEDIAKEYSESSION_TYPE eSessionType, ref IMFMediaKeySessionNotify2 pMFMediaKeySessionNotify2, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession2>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession2(eSessionType, ref pMFMediaKeySessionNotify2, (IMFMediaKeySession2**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
