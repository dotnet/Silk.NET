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
    [Guid("c3a9e92a-da88-46b0-a110-6cf953026cb9")]
    [NativeName("Name", "IMFMediaKeySessionNotify2")]
    public unsafe partial struct IMFMediaKeySessionNotify2 : IComVtbl<IMFMediaKeySessionNotify2>, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c3a9e92a-da88-46b0-a110-6cf953026cb9");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IMFMediaKeySessionNotify(IMFMediaKeySessionNotify2 val)
            => Unsafe.As<IMFMediaKeySessionNotify2, IMFMediaKeySessionNotify>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaKeySessionNotify2 val)
            => Unsafe.As<IMFMediaKeySessionNotify2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaKeySessionNotify2
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
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void KeyMessage(char* destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message, uint cb)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, char*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURL, message, cb);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void KeyMessage(char* destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte message, uint cb)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* messagePtr = &message)
            {
                ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, char*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURL, messagePtr, cb);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void KeyMessage(char* destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message, uint cb)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var messagePtr = (byte*) SilkMarshal.StringToPtr(message, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, char*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURL, messagePtr, cb);
            SilkMarshal.Free((nint)messagePtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void KeyMessage(ref char destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message, uint cb)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* destinationURLPtr = &destinationURL)
            {
                ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, char*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURLPtr, message, cb);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void KeyMessage(ref char destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte message, uint cb)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* destinationURLPtr = &destinationURL)
            {
                fixed (byte* messagePtr = &message)
                {
                    ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, char*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURLPtr, messagePtr, cb);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void KeyMessage(ref char destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message, uint cb)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* destinationURLPtr = &destinationURL)
            {
            var messagePtr = (byte*) SilkMarshal.StringToPtr(message, NativeStringEncoding.UTF8);
                ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, char*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURLPtr, messagePtr, cb);
            SilkMarshal.Free((nint)messagePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void KeyMessage([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message, uint cb)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var destinationURLPtr = (byte*) SilkMarshal.StringToPtr(destinationURL, NativeStringEncoding.BStr);
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, byte*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURLPtr, message, cb);
            SilkMarshal.Free((nint)destinationURLPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void KeyMessage([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte message, uint cb)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var destinationURLPtr = (byte*) SilkMarshal.StringToPtr(destinationURL, NativeStringEncoding.BStr);
            fixed (byte* messagePtr = &message)
            {
                ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, byte*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURLPtr, messagePtr, cb);
            }
            SilkMarshal.Free((nint)destinationURLPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void KeyMessage([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message, uint cb)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var destinationURLPtr = (byte*) SilkMarshal.StringToPtr(destinationURL, NativeStringEncoding.BStr);
            var messagePtr = (byte*) SilkMarshal.StringToPtr(message, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, byte*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURLPtr, messagePtr, cb);
            SilkMarshal.Free((nint)messagePtr);
            SilkMarshal.Free((nint)destinationURLPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void KeyAdded()
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, void>)@this->LpVtbl[4])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void KeyError(ushort code, uint systemCode)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, ushort, uint, void>)@this->LpVtbl[5])(@this, code, systemCode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void KeyMessage2(MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType, char* destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbMessage, uint cbMessage)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, MF_MEDIAKEYSESSION_MESSAGETYPE, char*, byte*, uint, void>)@this->LpVtbl[6])(@this, eMessageType, destinationURL, pbMessage, cbMessage);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void KeyMessage2(MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType, char* destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbMessage, uint cbMessage)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pbMessagePtr = &pbMessage)
            {
                ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, MF_MEDIAKEYSESSION_MESSAGETYPE, char*, byte*, uint, void>)@this->LpVtbl[6])(@this, eMessageType, destinationURL, pbMessagePtr, cbMessage);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void KeyMessage2(MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType, char* destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbMessage, uint cbMessage)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pbMessagePtr = (byte*) SilkMarshal.StringToPtr(pbMessage, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, MF_MEDIAKEYSESSION_MESSAGETYPE, char*, byte*, uint, void>)@this->LpVtbl[6])(@this, eMessageType, destinationURL, pbMessagePtr, cbMessage);
            SilkMarshal.Free((nint)pbMessagePtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void KeyMessage2(MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType, ref char destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbMessage, uint cbMessage)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* destinationURLPtr = &destinationURL)
            {
                ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, MF_MEDIAKEYSESSION_MESSAGETYPE, char*, byte*, uint, void>)@this->LpVtbl[6])(@this, eMessageType, destinationURLPtr, pbMessage, cbMessage);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void KeyMessage2(MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType, ref char destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbMessage, uint cbMessage)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* destinationURLPtr = &destinationURL)
            {
                fixed (byte* pbMessagePtr = &pbMessage)
                {
                    ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, MF_MEDIAKEYSESSION_MESSAGETYPE, char*, byte*, uint, void>)@this->LpVtbl[6])(@this, eMessageType, destinationURLPtr, pbMessagePtr, cbMessage);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void KeyMessage2(MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType, ref char destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbMessage, uint cbMessage)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* destinationURLPtr = &destinationURL)
            {
            var pbMessagePtr = (byte*) SilkMarshal.StringToPtr(pbMessage, NativeStringEncoding.UTF8);
                ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, MF_MEDIAKEYSESSION_MESSAGETYPE, char*, byte*, uint, void>)@this->LpVtbl[6])(@this, eMessageType, destinationURLPtr, pbMessagePtr, cbMessage);
            SilkMarshal.Free((nint)pbMessagePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void KeyMessage2(MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbMessage, uint cbMessage)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var destinationURLPtr = (byte*) SilkMarshal.StringToPtr(destinationURL, NativeStringEncoding.BStr);
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, MF_MEDIAKEYSESSION_MESSAGETYPE, byte*, byte*, uint, void>)@this->LpVtbl[6])(@this, eMessageType, destinationURLPtr, pbMessage, cbMessage);
            SilkMarshal.Free((nint)destinationURLPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void KeyMessage2(MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbMessage, uint cbMessage)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var destinationURLPtr = (byte*) SilkMarshal.StringToPtr(destinationURL, NativeStringEncoding.BStr);
            fixed (byte* pbMessagePtr = &pbMessage)
            {
                ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, MF_MEDIAKEYSESSION_MESSAGETYPE, byte*, byte*, uint, void>)@this->LpVtbl[6])(@this, eMessageType, destinationURLPtr, pbMessagePtr, cbMessage);
            }
            SilkMarshal.Free((nint)destinationURLPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void KeyMessage2(MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbMessage, uint cbMessage)
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var destinationURLPtr = (byte*) SilkMarshal.StringToPtr(destinationURL, NativeStringEncoding.BStr);
            var pbMessagePtr = (byte*) SilkMarshal.StringToPtr(pbMessage, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, MF_MEDIAKEYSESSION_MESSAGETYPE, byte*, byte*, uint, void>)@this->LpVtbl[6])(@this, eMessageType, destinationURLPtr, pbMessagePtr, cbMessage);
            SilkMarshal.Free((nint)pbMessagePtr);
            SilkMarshal.Free((nint)destinationURLPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void KeyStatusChange()
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, void>)@this->LpVtbl[7])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeySessionNotify2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
