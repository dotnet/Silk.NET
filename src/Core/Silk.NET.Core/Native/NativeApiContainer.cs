// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

#nullable enable
using System;
using System.Diagnostics;
using System.Threading;
using Silk.NET.Core.Contexts;

namespace Silk.NET.Core.Native
{
    public abstract class NativeApiContainer : IDisposable
    {
        private readonly INativeContext _ctx;
        private IVTable _vTable;

        protected NativeApiContainer(INativeContext ctx)
        {
            _ctx = ctx;
            // Virtual member call should be fine unless we have a rogue implementer
            // The only implementer of this function should be SilkTouch
            // ReSharper disable VirtualMemberCallInConstructor
            _vTable = CreateVTable();
            var slotCount = CoreGetSlotCount();
            if (slotCount == 0)
            {
                throw new InvalidOperationException
                (
                    "The derived class does not implement CoreGetSlotCount, or does not have any slots." +
                    "This could be because of a SilkTouch bug, or because you're not using SilkTouch at all."
                );
            }
            _vTable.Initialize(_ctx, slotCount);
            GcUtility = new GcUtility(1, CoreGcSlotCount());
            // ReSharper restore VirtualMemberCallInConstructor
        }
        
        public GcUtility GcUtility { get; }

        public IVTable CurrentVTable => _vTable;

        public void Dispose()
        {
            _ctx.Dispose();
            CurrentVTable.Dispose();
        }

        protected virtual int CoreGetSlotCount() => 0;
        protected virtual int CoreGcSlotCount() => 0;
        protected virtual IVTable CreateVTable() => new ConcurrentDictionaryVTable();
        protected IVTable SwapVTable() => Interlocked.Exchange(ref _vTable, CreateVTable());
        protected IVTable SwapVTable(IVTable newVTable) => Interlocked.Exchange(ref _vTable, newVTable);

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
            CurrentVTable.Purge();
        }
        
        protected IntPtr Load(int slot, string entryPoint)
        {
            return CurrentVTable.Load(slot, entryPoint);
        }
    }
}
