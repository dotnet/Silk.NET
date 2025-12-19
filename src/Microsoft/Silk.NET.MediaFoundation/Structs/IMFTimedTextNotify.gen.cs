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
    [Guid("df6b87b6-ce12-45db-aba7-432fe054e57d")]
    [NativeName("Name", "IMFTimedTextNotify")]
    public unsafe partial struct IMFTimedTextNotify : IComVtbl<IMFTimedTextNotify>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("df6b87b6-ce12-45db-aba7-432fe054e57d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFTimedTextNotify val)
            => Unsafe.As<IMFTimedTextNotify, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFTimedTextNotify
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
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextNotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextNotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextNotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextNotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextNotify*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextNotify*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void TrackAdded(uint trackId)
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IMFTimedTextNotify*, uint, void>)@this->LpVtbl[3])(@this, trackId);
        }

        /// <summary>To be documented.</summary>
        public readonly void TrackRemoved(uint trackId)
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IMFTimedTextNotify*, uint, void>)@this->LpVtbl[4])(@this, trackId);
        }

        /// <summary>To be documented.</summary>
        public readonly void TrackSelected(uint trackId, Silk.NET.Core.Bool32 selected)
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IMFTimedTextNotify*, uint, Silk.NET.Core.Bool32, void>)@this->LpVtbl[5])(@this, trackId, selected);
        }

        /// <summary>To be documented.</summary>
        public readonly void TrackReadyStateChanged(uint trackId)
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IMFTimedTextNotify*, uint, void>)@this->LpVtbl[6])(@this, trackId);
        }

        /// <summary>To be documented.</summary>
        public readonly void Error(TimedTextErrorCode errorCode, int extendedErrorCode, uint sourceTrackId)
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IMFTimedTextNotify*, TimedTextErrorCode, int, uint, void>)@this->LpVtbl[7])(@this, errorCode, extendedErrorCode, sourceTrackId);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Cue(TimedTextCueEvent cueEvent, double currentTime, IMFTimedTextCue* cue)
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IMFTimedTextNotify*, TimedTextCueEvent, double, IMFTimedTextCue*, void>)@this->LpVtbl[8])(@this, cueEvent, currentTime, cue);
        }

        /// <summary>To be documented.</summary>
        public readonly void Cue(TimedTextCueEvent cueEvent, double currentTime, ref IMFTimedTextCue cue)
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IMFTimedTextCue* cuePtr = &cue)
            {
                ((delegate* unmanaged[Stdcall]<IMFTimedTextNotify*, TimedTextCueEvent, double, IMFTimedTextCue*, void>)@this->LpVtbl[8])(@this, cueEvent, currentTime, cuePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void Reset()
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IMFTimedTextNotify*, void>)@this->LpVtbl[9])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void Cue<TI0>(TimedTextCueEvent cueEvent, double currentTime, ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->Cue(cueEvent, currentTime, (IMFTimedTextCue*) cue.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextNotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
