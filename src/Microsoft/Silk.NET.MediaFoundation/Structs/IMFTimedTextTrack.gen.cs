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
    [Guid("8822c32d-654e-4233-bf21-d7f2e67d30d4")]
    [NativeName("Name", "IMFTimedTextTrack")]
    public unsafe partial struct IMFTimedTextTrack : IComVtbl<IMFTimedTextTrack>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("8822c32d-654e-4233-bf21-d7f2e67d30d4");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFTimedTextTrack val)
            => Unsafe.As<IMFTimedTextTrack, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFTimedTextTrack
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
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetId()
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLabel(char** label)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char**, int>)@this->LpVtbl[4])(@this, label);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLabel(ref char* label)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** labelPtr = &label)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char**, int>)@this->LpVtbl[4])(@this, labelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetLabel([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char*, int>)@this->LpVtbl[5])(@this, label);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLabel([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char*, int>)@this->LpVtbl[5])(@this, labelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLabel([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, byte*, int>)@this->LpVtbl[5])(@this, labelPtr);
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLanguage(char** language)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char**, int>)@this->LpVtbl[6])(@this, language);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLanguage(ref char* language)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char**, int>)@this->LpVtbl[6])(@this, languagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly TimedTextTrackKind GetTrackKind()
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TimedTextTrackKind ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, TimedTextTrackKind>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsInBand()
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Silk.NET.Core.Bool32>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInBandMetadataTrackDispatchType(char** dispatchType)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char**, int>)@this->LpVtbl[9])(@this, dispatchType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInBandMetadataTrackDispatchType(ref char* dispatchType)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** dispatchTypePtr = &dispatchType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char**, int>)@this->LpVtbl[9])(@this, dispatchTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsActive()
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Silk.NET.Core.Bool32>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly TimedTextErrorCode GetErrorCode()
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TimedTextErrorCode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, TimedTextErrorCode>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetExtendedErrorCode()
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, int>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataFormat(Guid* format)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Guid*, int>)@this->LpVtbl[13])(@this, format);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDataFormat(ref Guid format)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* formatPtr = &format)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Guid*, int>)@this->LpVtbl[13])(@this, formatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly TimedTextTrackReadyState GetReadyState()
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TimedTextTrackReadyState ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, TimedTextTrackReadyState>)@this->LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCueList(IMFTimedTextCueList** cues)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, IMFTimedTextCueList**, int>)@this->LpVtbl[15])(@this, cues);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCueList(ref IMFTimedTextCueList* cues)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextCueList** cuesPtr = &cues)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, IMFTimedTextCueList**, int>)@this->LpVtbl[15])(@this, cuesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLabel(string[] labelSa)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var label = (char**) SilkMarshal.StringArrayToPtr(labelSa);
            var ret = @this->GetLabel(label);
            SilkMarshal.CopyPtrToStringArray((nint) label, labelSa);
            SilkMarshal.Free((nint) label);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLanguage(string[] languageSa)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var language = (char**) SilkMarshal.StringArrayToPtr(languageSa);
            var ret = @this->GetLanguage(language);
            SilkMarshal.CopyPtrToStringArray((nint) language, languageSa);
            SilkMarshal.Free((nint) language);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetInBandMetadataTrackDispatchType(string[] dispatchTypeSa)
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var dispatchType = (char**) SilkMarshal.StringArrayToPtr(dispatchTypeSa);
            var ret = @this->GetInBandMetadataTrackDispatchType(dispatchType);
            SilkMarshal.CopyPtrToStringArray((nint) dispatchType, dispatchTypeSa);
            SilkMarshal.Free((nint) dispatchType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCueList<TI0>(ref ComPtr<TI0> cues) where TI0 : unmanaged, IComVtbl<IMFTimedTextCueList>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetCueList((IMFTimedTextCueList**) cues.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextTrack*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
