// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Contexts;

namespace Silk.NET.Core.Native
{
    public abstract class NativeApiContainer : IDisposable
    {
        private readonly INativeContext _ctx;
        private readonly IntPtr[] _entryPoints;

        protected NativeApiContainer(INativeContext ctx)
        {
            _ctx = ctx;
            // Virtual member call should be fine unless we have a rogue implementer
            // The only implementer of this function should be SilkTouch
            // ReSharper disable once VirtualMemberCallInConstructor
            _entryPoints = new IntPtr[CoreGetSlotCount()];
        }

        public GcUtility GcUtility { get; } = new GcUtility();

        public void Dispose()
        {
            _ctx.Dispose();
        }

        protected virtual int CoreGetSlotCount()
        {
            throw new MissingMethodException
            (
                "The derived class does not implement CoreGetSlotCount. This could be because of a SilkTouch " +
                "bug, or because you're not using SilkTouch at all."
            );
        }

        protected void Pin(object o, int slot = -1)
        {
            GcUtility.Pin(o, slot);
        }

        protected void PinUntilNextCall(object o, int slot = -1)
        {
            GcUtility.PinUntilNextCall(o, slot);
        }

        protected void Unpin(object o, int slot = -1)
        {
            GcUtility.Unpin(o, slot);
        }

        public void PurgeEntryPoints()
        {
            for (var i = 0; i < _entryPoints.Length; i++)
            {
                _entryPoints[i] = IntPtr.Zero;
            }
        }

        protected IntPtr Load(int slot, string entryPoint)
        {
            var ptr = _entryPoints[slot];
            if (ptr != IntPtr.Zero)
            {
                return ptr;
            }

            ptr = _ctx.GetProcAddress(entryPoint);
            if (ptr == IntPtr.Zero)
            {
                throw new EntryPointNotFoundException($"Native symbol \"{entryPoint}\" not found (slot {slot})");
            }

            _entryPoints[slot] = ptr;
            return ptr;
        }
    }
}
