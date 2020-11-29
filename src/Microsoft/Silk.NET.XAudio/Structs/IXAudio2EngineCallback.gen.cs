// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
    [NativeName("Name", "IXAudio2EngineCallback")]
    public unsafe partial struct IXAudio2EngineCallback
    {
        public IXAudio2EngineCallback
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
        /// <summary>To be added.</summary>
        public readonly void OnProcessingPassStart()
        {
            var @this = (IXAudio2EngineCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2EngineCallback*, void>)LpVtbl[0])(@this);
        }

        /// <summary>To be added.</summary>
        public readonly void OnProcessingPassEnd()
        {
            var @this = (IXAudio2EngineCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2EngineCallback*, void>)LpVtbl[1])(@this);
        }

        /// <summary>To be added.</summary>
        public readonly void OnCriticalError(int Error)
        {
            var @this = (IXAudio2EngineCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2EngineCallback*, int, void>)LpVtbl[2])(@this, Error);
        }

    }
}
