// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Silk.NET.Core.Contexts;

namespace Silk.NET.Core.Native
{
    public abstract class NativeApiContainer : IDisposable
    {
        private const int ConcurrencyLevel = 1;
        private readonly INativeContext _ctx;
        private readonly ConcurrentDictionary<int, IntPtr> _entryPoints;

        protected NativeApiContainer(INativeContext ctx)
        {
            _ctx = ctx;
            // Virtual member call should be fine unless we have a rogue implementer
            // The only implementer of this function should be SilkTouch
            // ReSharper disable once VirtualMemberCallInConstructor
            var slotCount = CoreGetSlotCount();
            if (slotCount == 0)
            {
                throw new InvalidOperationException
                (
                    "The derived class does not implement CoreGetSlotCount, or does not have any slots." +
                    "This could be because of a SilkTouch bug, or because you're not using SilkTouch at all."
                );
            }
            _entryPoints = new ConcurrentDictionary<int, IntPtr>(ConcurrencyLevel, slotCount);
            GcUtility = new GcUtility(ConcurrencyLevel, slotCount);
        }

        public GcUtility GcUtility { get; }

        public void Dispose()
        {
            _ctx.Dispose();
        }

        protected virtual int CoreGetSlotCount() => 0;

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
            _entryPoints.Clear();
        }

        protected IntPtr Load(int slot, string entryPoint)
        {
            return _entryPoints.GetOrAdd(slot, i =>
            {
                var v = _ctx.GetProcAddress(entryPoint);

                if (v == IntPtr.Zero)
                    ThrowEntryPointNotFound(entryPoint, i);

                return v;
            });
        }

        private void ThrowEntryPointNotFound(string entryPoint, int slot)
        {
            throw new EntryPointNotFoundException($"Native symbol \"{entryPoint}\" not found (slot {slot})");
        }
    }
}
