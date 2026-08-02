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
    [Guid("ad128745-211b-40a0-9981-fe65f166d0fd")]
    [NativeName("Name", "IMFTimedTextCueList")]
    public unsafe partial struct IMFTimedTextCueList : IComVtbl<IMFTimedTextCueList>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("ad128745-211b-40a0-9981-fe65f166d0fd");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFTimedTextCueList val)
            => Unsafe.As<IMFTimedTextCueList, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFTimedTextCueList
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
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetLength()
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCueByIndex(uint index, IMFTimedTextCue** cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[4])(@this, index, cue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCueByIndex(uint index, ref IMFTimedTextCue* cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextCue** cuePtr = &cue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[4])(@this, index, cuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCueById(uint id, IMFTimedTextCue** cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[5])(@this, id, cue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCueById(uint id, ref IMFTimedTextCue* cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextCue** cuePtr = &cue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[5])(@this, id, cuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCueByOriginalId([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* originalId, IMFTimedTextCue** cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, char*, IMFTimedTextCue**, int>)@this->LpVtbl[6])(@this, originalId, cue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCueByOriginalId([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* originalId, ref IMFTimedTextCue* cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextCue** cuePtr = &cue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, char*, IMFTimedTextCue**, int>)@this->LpVtbl[6])(@this, originalId, cuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCueByOriginalId([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char originalId, IMFTimedTextCue** cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* originalIdPtr = &originalId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, char*, IMFTimedTextCue**, int>)@this->LpVtbl[6])(@this, originalIdPtr, cue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCueByOriginalId([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char originalId, ref IMFTimedTextCue* cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* originalIdPtr = &originalId)
            {
                fixed (IMFTimedTextCue** cuePtr = &cue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, char*, IMFTimedTextCue**, int>)@this->LpVtbl[6])(@this, originalIdPtr, cuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCueByOriginalId([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string originalId, IMFTimedTextCue** cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var originalIdPtr = (byte*) SilkMarshal.StringToPtr(originalId, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, byte*, IMFTimedTextCue**, int>)@this->LpVtbl[6])(@this, originalIdPtr, cue);
            SilkMarshal.Free((nint)originalIdPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCueByOriginalId([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string originalId, ref IMFTimedTextCue* cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var originalIdPtr = (byte*) SilkMarshal.StringToPtr(originalId, NativeStringEncoding.LPWStr);
            fixed (IMFTimedTextCue** cuePtr = &cue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, byte*, IMFTimedTextCue**, int>)@this->LpVtbl[6])(@this, originalIdPtr, cuePtr);
            }
            SilkMarshal.Free((nint)originalIdPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTextCue(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* text, IMFTimedTextCue** cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, char*, IMFTimedTextCue**, int>)@this->LpVtbl[7])(@this, start, duration, text, cue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTextCue(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* text, ref IMFTimedTextCue* cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextCue** cuePtr = &cue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, char*, IMFTimedTextCue**, int>)@this->LpVtbl[7])(@this, start, duration, text, cuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTextCue(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char text, IMFTimedTextCue** cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* textPtr = &text)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, char*, IMFTimedTextCue**, int>)@this->LpVtbl[7])(@this, start, duration, textPtr, cue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTextCue(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char text, ref IMFTimedTextCue* cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* textPtr = &text)
            {
                fixed (IMFTimedTextCue** cuePtr = &cue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, char*, IMFTimedTextCue**, int>)@this->LpVtbl[7])(@this, start, duration, textPtr, cuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTextCue(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string text, IMFTimedTextCue** cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textPtr = (byte*) SilkMarshal.StringToPtr(text, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, IMFTimedTextCue**, int>)@this->LpVtbl[7])(@this, start, duration, textPtr, cue);
            SilkMarshal.Free((nint)textPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTextCue(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string text, ref IMFTimedTextCue* cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textPtr = (byte*) SilkMarshal.StringToPtr(text, NativeStringEncoding.LPWStr);
            fixed (IMFTimedTextCue** cuePtr = &cue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, IMFTimedTextCue**, int>)@this->LpVtbl[7])(@this, start, duration, textPtr, cuePtr);
            }
            SilkMarshal.Free((nint)textPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataCue(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize, IMFTimedTextCue** cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[8])(@this, start, duration, data, dataSize, cue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataCue(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize, ref IMFTimedTextCue* cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextCue** cuePtr = &cue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[8])(@this, start, duration, data, dataSize, cuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataCue(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataSize, IMFTimedTextCue** cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[8])(@this, start, duration, dataPtr, dataSize, cue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataCue(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataSize, ref IMFTimedTextCue* cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                fixed (IMFTimedTextCue** cuePtr = &cue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[8])(@this, start, duration, dataPtr, dataSize, cuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataCue(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize, IMFTimedTextCue** cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[8])(@this, start, duration, dataPtr, dataSize, cue);
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataCue(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize, ref IMFTimedTextCue* cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (IMFTimedTextCue** cuePtr = &cue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[8])(@this, start, duration, dataPtr, dataSize, cuePtr);
            }
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RemoveCue(IMFTimedTextCue* cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, IMFTimedTextCue*, int>)@this->LpVtbl[9])(@this, cue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveCue(ref IMFTimedTextCue cue)
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextCue* cuePtr = &cue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, IMFTimedTextCue*, int>)@this->LpVtbl[9])(@this, cuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCueByIndex<TI0>(uint index, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetCueByIndex(index, (IMFTimedTextCue**) cue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCueById<TI0>(uint id, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetCueById(id, (IMFTimedTextCue**) cue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCueByOriginalId<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* originalId, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetCueByOriginalId(originalId, (IMFTimedTextCue**) cue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCueByOriginalId<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char originalId, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetCueByOriginalId(in originalId, (IMFTimedTextCue**) cue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCueByOriginalId<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string originalId, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetCueByOriginalId(originalId, (IMFTimedTextCue**) cue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTextCue<TI0>(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* text, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddTextCue(start, duration, text, (IMFTimedTextCue**) cue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int AddTextCue<TI0>(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char text, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddTextCue(start, duration, in text, (IMFTimedTextCue**) cue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int AddTextCue<TI0>(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string text, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddTextCue(start, duration, text, (IMFTimedTextCue**) cue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataCue<TI0>(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddDataCue(start, duration, data, dataSize, (IMFTimedTextCue**) cue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDataCue<TI0>(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataSize, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddDataCue(start, duration, in data, dataSize, (IMFTimedTextCue**) cue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDataCue<TI0>(double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddDataCue(start, duration, data, dataSize, (IMFTimedTextCue**) cue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveCue<TI0>(ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RemoveCue((IMFTimedTextCue*) cue.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCueList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
