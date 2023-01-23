// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable enable
using System;
using System.Diagnostics;
using System.Threading;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

namespace Silk.NET.Core.Native
{
    public abstract class NativeApiContainer : IDisposable
    {
        protected readonly INativeContext _ctx;
        private IVTable _vTable;

        public NativeApiContainer(INativeContext ctx)
        {
            _ctx = ctx;
            // Virtual member call should be fine unless we have a rogue implementer
            // The only implementer of this function should be SilkTouch
            // ReSharper disable VirtualMemberCallInConstructor
            _vTable = CreateVTable();
            GcUtility = new GcUtility(1, CoreGcSlotCount());
            PostInit();
            // ReSharper restore VirtualMemberCallInConstructor
        }
        
        public GcUtility GcUtility { get; }

        public IVTable CurrentVTable => _vTable;

        public void Dispose()
        {
            _ctx.Dispose();
            CurrentVTable.Dispose();
        }

        protected virtual int CoreGcSlotCount() => 0;
        protected virtual IVTable CreateVTable()
            => throw new NotImplementedException("Must be implemented by SilkTouch");
        protected IVTable SwapVTable() => SwapVTable(CreateVTable());
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
        
        [Obsolete("Use method without slot - this method will be removed in 3.0")]
        protected nint Load(int slot, string entryPoint)
        {
            return Load(entryPoint);
        }

        protected nint Load(string entryPoint)
        {
            var result = CurrentVTable.Load(entryPoint);
            if (result == 0)
            {
                ThrowSymbolLoadingEx(entryPoint);
            }
            return result;
        }

        private static void ThrowSymbolLoadingEx(string symbol) => throw new SymbolLoadingException(symbol);

        protected virtual void PostInit()
        {
            // do nothing by default
        }
    }
}
