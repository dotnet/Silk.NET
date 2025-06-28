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
    [Guid("1f2a94c9-a3df-430d-9d0f-acd85ddc29af")]
    [NativeName("Name", "IMFTimedText")]
    public unsafe partial struct IMFTimedText : IComVtbl<IMFTimedText>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("1f2a94c9-a3df-430d-9d0f-acd85ddc29af");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFTimedText val)
            => Unsafe.As<IMFTimedText, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFTimedText
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
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterNotifications(IMFTimedTextNotify* notify)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextNotify*, int>)@this->LpVtbl[3])(@this, notify);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterNotifications(ref IMFTimedTextNotify notify)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextNotify*, int>)@this->LpVtbl[3])(@this, notifyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SelectTrack(uint trackId, Silk.NET.Core.Bool32 selected)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, uint, Silk.NET.Core.Bool32, int>)@this->LpVtbl[4])(@this, trackId, selected);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, label, language, kind, isDefault, trackId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, label, language, kind, isDefault, trackIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, label, languagePtr, kind, isDefault, trackId);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* languagePtr = &language)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, label, languagePtr, kind, isDefault, trackIdPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, label, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, label, languagePtr, kind, isDefault, trackIdPtr);
            }
            SilkMarshal.Free((nint)languagePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, language, kind, isDefault, trackId);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, language, kind, isDefault, trackIdPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
                fixed (char* languagePtr = &language)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackId);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
                fixed (char* languagePtr = &language)
                {
                    fixed (uint* trackIdPtr = &trackId)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
            SilkMarshal.Free((nint)languagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, language, kind, isDefault, trackId);
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, language, kind, isDefault, trackIdPtr);
            }
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackId);
            }
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (char* languagePtr = &language)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
            }
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
            }
            SilkMarshal.Free((nint)languagePtr);
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, label, language, kind, isDefault, trackId);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, label, language, kind, isDefault, trackIdPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
                fixed (char* languagePtr = &language)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, label, languagePtr, kind, isDefault, trackId);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
                fixed (char* languagePtr = &language)
                {
                    fixed (uint* trackIdPtr = &trackId)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, label, languagePtr, kind, isDefault, trackIdPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, label, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, label, languagePtr, kind, isDefault, trackIdPtr);
                }
            SilkMarshal.Free((nint)languagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
                fixed (char* labelPtr = &label)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, language, kind, isDefault, trackId);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
                fixed (char* labelPtr = &label)
                {
                    fixed (uint* trackIdPtr = &trackId)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, language, kind, isDefault, trackIdPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
                fixed (char* labelPtr = &label)
                {
                    fixed (char* languagePtr = &language)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackId);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
                fixed (char* labelPtr = &label)
                {
                    fixed (char* languagePtr = &language)
                    {
                        fixed (uint* trackIdPtr = &trackId)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
                fixed (char* labelPtr = &label)
                {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
                fixed (char* labelPtr = &label)
                {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                    fixed (uint* trackIdPtr = &trackId)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                    }
            SilkMarshal.Free((nint)languagePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, language, kind, isDefault, trackId);
            SilkMarshal.Free((nint)labelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, language, kind, isDefault, trackIdPtr);
                }
            SilkMarshal.Free((nint)labelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
                fixed (char* languagePtr = &language)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackId);
                }
            SilkMarshal.Free((nint)labelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
                fixed (char* languagePtr = &language)
                {
                    fixed (uint* trackIdPtr = &trackId)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                    }
                }
            SilkMarshal.Free((nint)labelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
            SilkMarshal.Free((nint)labelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDataSource(ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* byteStreamPtr = &byteStream)
            {
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
            SilkMarshal.Free((nint)languagePtr);
            SilkMarshal.Free((nint)labelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, label, language, kind, isDefault, trackId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, label, language, kind, isDefault, trackIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, label, languagePtr, kind, isDefault, trackId);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* languagePtr = &language)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, label, languagePtr, kind, isDefault, trackIdPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, label, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, label, languagePtr, kind, isDefault, trackIdPtr);
            }
            SilkMarshal.Free((nint)languagePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, language, kind, isDefault, trackId);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, language, kind, isDefault, trackIdPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
                fixed (char* languagePtr = &language)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackId);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
                fixed (char* languagePtr = &language)
                {
                    fixed (uint* trackIdPtr = &trackId)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
            SilkMarshal.Free((nint)languagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, language, kind, isDefault, trackId);
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, language, kind, isDefault, trackIdPtr);
            }
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackId);
            }
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (char* languagePtr = &language)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
            }
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
            }
            SilkMarshal.Free((nint)languagePtr);
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, language, kind, isDefault, trackId);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, language, kind, isDefault, trackIdPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
                fixed (char* languagePtr = &language)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackId);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
                fixed (char* languagePtr = &language)
                {
                    fixed (uint* trackIdPtr = &trackId)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackIdPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackIdPtr);
                }
            SilkMarshal.Free((nint)languagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
                fixed (char* labelPtr = &label)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackId);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
                fixed (char* labelPtr = &label)
                {
                    fixed (uint* trackIdPtr = &trackId)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackIdPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
                fixed (char* labelPtr = &label)
                {
                    fixed (char* languagePtr = &language)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
                fixed (char* labelPtr = &label)
                {
                    fixed (char* languagePtr = &language)
                    {
                        fixed (uint* trackIdPtr = &trackId)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
                fixed (char* labelPtr = &label)
                {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
                fixed (char* labelPtr = &label)
                {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                    fixed (uint* trackIdPtr = &trackId)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                    }
            SilkMarshal.Free((nint)languagePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackId);
            SilkMarshal.Free((nint)labelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackIdPtr);
                }
            SilkMarshal.Free((nint)labelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
                fixed (char* languagePtr = &language)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
                }
            SilkMarshal.Free((nint)labelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
                fixed (char* languagePtr = &language)
                {
                    fixed (uint* trackIdPtr = &trackId)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                    }
                }
            SilkMarshal.Free((nint)labelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
            SilkMarshal.Free((nint)labelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* urlPtr = &url)
            {
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
            SilkMarshal.Free((nint)languagePtr);
            SilkMarshal.Free((nint)labelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, language, kind, isDefault, trackId);
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, language, kind, isDefault, trackIdPtr);
            }
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackId);
            }
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            fixed (char* languagePtr = &language)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackIdPtr);
                }
            }
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackIdPtr);
            }
            SilkMarshal.Free((nint)languagePtr);
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            fixed (char* labelPtr = &label)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackId);
            }
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            fixed (char* labelPtr = &label)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackIdPtr);
                }
            }
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            fixed (char* labelPtr = &label)
            {
                fixed (char* languagePtr = &language)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
                }
            }
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            fixed (char* labelPtr = &label)
            {
                fixed (char* languagePtr = &language)
                {
                    fixed (uint* trackIdPtr = &trackId)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            fixed (char* labelPtr = &label)
            {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
            }
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            fixed (char* labelPtr = &label)
            {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
            SilkMarshal.Free((nint)languagePtr);
            }
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackId);
            SilkMarshal.Free((nint)labelPtr);
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackIdPtr);
            }
            SilkMarshal.Free((nint)labelPtr);
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
            }
            SilkMarshal.Free((nint)labelPtr);
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (char* languagePtr = &language)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
            }
            SilkMarshal.Free((nint)labelPtr);
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
            SilkMarshal.Free((nint)languagePtr);
            SilkMarshal.Free((nint)labelPtr);
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDataSourceFromUrl([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
            }
            SilkMarshal.Free((nint)languagePtr);
            SilkMarshal.Free((nint)labelPtr);
            SilkMarshal.Free((nint)urlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, label, language, kind, track);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextTrack** trackPtr = &track)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, label, language, kind, trackPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, label, languagePtr, kind, track);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* languagePtr = &language)
            {
                fixed (IMFTimedTextTrack** trackPtr = &track)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, label, languagePtr, kind, trackPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, label, languagePtr, kind, track);
            SilkMarshal.Free((nint)languagePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (IMFTimedTextTrack** trackPtr = &track)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, label, languagePtr, kind, trackPtr);
            }
            SilkMarshal.Free((nint)languagePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, language, kind, track);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
                fixed (IMFTimedTextTrack** trackPtr = &track)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, language, kind, trackPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
                fixed (char* languagePtr = &language)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, track);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
                fixed (char* languagePtr = &language)
                {
                    fixed (IMFTimedTextTrack** trackPtr = &track)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, trackPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, track);
            SilkMarshal.Free((nint)languagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* labelPtr = &label)
            {
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                fixed (IMFTimedTextTrack** trackPtr = &track)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, trackPtr);
                }
            SilkMarshal.Free((nint)languagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, language, kind, track);
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (IMFTimedTextTrack** trackPtr = &track)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, language, kind, trackPtr);
            }
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, track);
            }
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (char* languagePtr = &language)
            {
                fixed (IMFTimedTextTrack** trackPtr = &track)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, trackPtr);
                }
            }
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, track);
            SilkMarshal.Free((nint)languagePtr);
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (IMFTimedTextTrack** trackPtr = &track)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, trackPtr);
            }
            SilkMarshal.Free((nint)languagePtr);
            SilkMarshal.Free((nint)labelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RemoveTrack(IMFTimedTextTrack* track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrack*, int>)@this->LpVtbl[8])(@this, track);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveTrack(ref IMFTimedTextTrack track)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextTrack* trackPtr = &track)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrack*, int>)@this->LpVtbl[8])(@this, trackPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCueTimeOffset(double* offset)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, double*, int>)@this->LpVtbl[9])(@this, offset);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCueTimeOffset(ref double offset)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* offsetPtr = &offset)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, double*, int>)@this->LpVtbl[9])(@this, offsetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCueTimeOffset(double offset)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, double, int>)@this->LpVtbl[10])(@this, offset);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTracks(IMFTimedTextTrackList** tracks)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[11])(@this, tracks);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTracks(ref IMFTimedTextTrackList* tracks)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextTrackList** tracksPtr = &tracks)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[11])(@this, tracksPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetActiveTracks(IMFTimedTextTrackList** activeTracks)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[12])(@this, activeTracks);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetActiveTracks(ref IMFTimedTextTrackList* activeTracks)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextTrackList** activeTracksPtr = &activeTracks)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[12])(@this, activeTracksPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextTracks(IMFTimedTextTrackList** textTracks)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[13])(@this, textTracks);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextTracks(ref IMFTimedTextTrackList* textTracks)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextTrackList** textTracksPtr = &textTracks)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[13])(@this, textTracksPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataTracks(IMFTimedTextTrackList** metadataTracks)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[14])(@this, metadataTracks);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataTracks(ref IMFTimedTextTrackList* metadataTracks)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextTrackList** metadataTracksPtr = &metadataTracks)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[14])(@this, metadataTracksPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInBandEnabled(Silk.NET.Core.Bool32 enabled)
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[15])(@this, enabled);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsInBandEnabled()
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, Silk.NET.Core.Bool32>)@this->LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterNotifications<TI0>(ComPtr<TI0> notify) where TI0 : unmanaged, IComVtbl<IMFTimedTextNotify>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterNotifications((IMFTimedTextNotify*) notify.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddTrack(label, language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddTrack(label, in language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddTrack(label, language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddTrack(in label, language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int AddTrack<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddTrack(in label, in language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int AddTrack<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddTrack(in label, language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrack<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddTrack(label, language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int AddTrack<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddTrack(label, in language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int AddTrack<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddTrack(label, language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveTrack<TI0>(ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RemoveTrack((IMFTimedTextTrack*) track.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTracks<TI0>(ref ComPtr<TI0> tracks) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrackList>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTracks((IMFTimedTextTrackList**) tracks.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetActiveTracks<TI0>(ref ComPtr<TI0> activeTracks) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrackList>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetActiveTracks((IMFTimedTextTrackList**) activeTracks.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTextTracks<TI0>(ref ComPtr<TI0> textTracks) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrackList>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTextTracks((IMFTimedTextTrackList**) textTracks.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMetadataTracks<TI0>(ref ComPtr<TI0> metadataTracks) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrackList>, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetMetadataTracks((IMFTimedTextTrackList**) metadataTracks.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
