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
    [Guid("5cb31c05-61ff-418f-afda-caaf41421a38")]
    [NativeName("Name", "IMFMediaKeys")]
    public unsafe partial struct IMFMediaKeys : IComVtbl<IMFMediaKeys>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("5cb31c05-61ff-418f-afda-caaf41421a38");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaKeys val)
            => Unsafe.As<IMFMediaKeys, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaKeys
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
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customData, cbCustomData, notify, ppSession);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customData, cbCustomData, notify, ppSessionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customData, cbCustomData, notifyPtr, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* customDataPtr = &customData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
            SilkMarshal.Free((nint)customDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
            SilkMarshal.Free((nint)customDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)customDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
            }
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
            }
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            }
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notify, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notify, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notifyPtr, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    fixed (byte* customDataPtr = &customData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    fixed (byte* customDataPtr = &customData)
                    {
                        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
                    fixed (byte* customDataPtr = &customData)
                    {
                        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
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
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                    }
            SilkMarshal.Free((nint)customDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
                fixed (byte* initDataPtr = &initData)
                {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                    }
            SilkMarshal.Free((nint)customDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
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
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
                }
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
                }
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                fixed (byte* customDataPtr = &customData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
                }
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                    }
                }
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                    }
                }
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
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
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* mimeTypePtr = &mimeType)
            {
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
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
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notify, ppSessionPtr);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notifyPtr, ppSession);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* customDataPtr = &customData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                    }
                }
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
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
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            SilkMarshal.Free((nint)customDataPtr);
            }
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            fixed (byte* initDataPtr = &initData)
            {
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
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
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
            }
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
            }
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            }
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            }
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
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
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
            SilkMarshal.Free((nint)customDataPtr);
            SilkMarshal.Free((nint)initDataPtr);
            SilkMarshal.Free((nint)mimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
            var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
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
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char**, int>)@this->LpVtbl[4])(@this, keySystem);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeySystem(ref char* keySystem)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, char**, int>)@this->LpVtbl[4])(@this, keySystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Shutdown()
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, int>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSuspendNotify(IMFCdmSuspendNotify** notify)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, IMFCdmSuspendNotify**, int>)@this->LpVtbl[6])(@this, notify);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSuspendNotify(ref IMFCdmSuspendNotify* notify)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFCdmSuspendNotify** notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys*, IMFCdmSuspendNotify**, int>)@this->LpVtbl[6])(@this, notifyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>(ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSession<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetKeySystem(string[] keySystemSa)
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSuspendNotify((IMFCdmSuspendNotify**) notify.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeys*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
