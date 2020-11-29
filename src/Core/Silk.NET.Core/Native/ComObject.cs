// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    public unsafe class ComObject : IDisposable
    {
        private ComObject(){}
        public ComObject(object o) => Handle = (IUnknown*) Marshal.GetIUnknownForObject(o);
        public static ComObject? FromPtr(IUnknown* ptr) => ptr is null ? null : new ComObject{Handle = ptr};
        public object Value => Marshal.GetObjectForIUnknown((IntPtr) Handle);
        public object UniqueValue => Marshal.GetUniqueObjectForIUnknown((IntPtr) Handle);
        public IUnknown* Handle { get; set; }

        public int QueryInterface(ref Guid riid, out ComObject? comObject)
        {
            void* ptr = null;
            var ret = Handle->QueryInterface(ref riid, ref ptr);
            comObject = FromPtr((IUnknown*)ptr);
            return ret;
        }

        public uint AddRef() => Handle->AddRef();
        public uint Release() => Handle->Release();
        private void ReleaseUnmanagedResources()
        {
            if (Handle != default)
            {
                Handle->Release();
                Handle = null;
            }
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        ~ComObject() => ReleaseUnmanagedResources();
    }
}
