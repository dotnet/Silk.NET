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
    /// <summary>
    /// A native api container. Serves as base class to all Native APIs.
    /// </summary>
    public abstract class NativeApiContainer : IDisposable
    {
        private readonly INativeContext _ctx;
        private IVTable _vTable;

        /// <summary>
        /// Creates a new <see cref="NativeApiContainer"/> with the given native context.
        /// </summary>
        /// <param name="ctx">The context.</param>
        /// <exception cref="InvalidOperationException">Thrown if the value returned by <see cref="CoreGetSlotCount"/> returns 0. See it's documentation. </exception>
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
        
        /// <summary>
        /// The <see cref="GcUtility"/> used by this container.
        /// </summary>
        public GcUtility GcUtility { get; }

        /// <summary>
        /// The currently active VTable
        /// </summary>
        /// <seealso cref="SwapVTable()"/>
        /// <seealso cref="CreateVTable()"/>
        /// <seealso cref="CoreGetSlotCount"/>
        public IVTable CurrentVTable => _vTable;
        
        /// <inheritdoc />
        public void Dispose()
        {
            _ctx.Dispose();
            CurrentVTable.Dispose();
        }

        /// <summary>
        /// Returns the number of slots used by this container. Required to initialize the VTable.
        /// </summary>
        /// <returns>The number of slots used by this container</returns>
        /// <remarks>Cannot return 0, because an empty container cannot exist.</remarks>
        protected virtual int CoreGetSlotCount() => 0;
        /// <summary>
        /// Returns the number of GC slots used by this container.
        /// </summary>
        /// <returns>The number of GC slots used by this container.</returns>
        /// <seealso cref="GcUtility"/>
        /// <seealso cref="Silk.NET.Core.Native.GcUtility"/>
        protected virtual int CoreGcSlotCount() => 0;
        /// <summary>
        /// Creates a new uninitialized VTable.
        /// </summary>
        /// <returns>A new uninitialized VTable</returns>
        /// <seealso cref="IVTable"/>
        /// <seealso cref="SwapVTable()"/>
        /// <remarks>This is thread-safe, and should be kept thread-safe by implementors wherever possible.</remarks>
        protected virtual IVTable CreateVTable() => new ConcurrentDictionaryVTable();
        
        /// <summary>
        /// Swaps the current VTable for a freshly created and initialized VTable.
        /// </summary>
        /// <returns>The old VTable</returns>
        /// <remarks>This is thread-safe, given a) <see cref="CreateVTable"/> is thread-safe and b) <see cref="CoreGetSlotCount"/> is thread-safe.</remarks>
        protected IVTable SwapVTable()
        {
            var table = CreateVTable();
            table.Initialize(_ctx, CoreGetSlotCount());
            return Interlocked.Exchange(ref _vTable, table);
        }

        /// <summary>
        /// Swaps the current VTable with the given VTable and returns the old one, as an atomic operation.
        /// </summary>
        /// <param name="newVTable">The new VTable.</param>
        /// <returns>The old VTable.</returns>
        protected IVTable SwapVTable(IVTable newVTable) => Interlocked.Exchange(ref _vTable, newVTable);

        /// <summary>
        /// Forward to <see cref="GcUtility"/>.
        /// </summary>
        /// <param name="o">The object to pin.</param>
        /// <param name="slot">The slot to associate this with.</param>
        /// <seealso cref="GcUtility"/>
        protected void Pin(object o, int slot = -1)
        {
            GcUtility.Pin(o, slot);
        }

        /// <summary>
        /// Forward to <see cref="GcUtility"/>.
        /// </summary>
        /// <param name="o">The object to pin.</param>
        /// <param name="slot">The slot to associate this with.</param>
        protected void PinUntilNextCall(object o, int slot = -1)
        {
            GcUtility.PinUntilNextCall(o, slot);
        }

        /// <summary>
        /// Forward to <see cref="GcUtility" />.
        /// </summary>
        /// <param name="o">The object to unpin.</param>
        /// <param name="slot">The slot to associate this with.</param>
        protected void Unpin(object o, int slot = -1)
        {
            GcUtility.Unpin(o, slot);
        }

        /// <summary>
        /// Purges the entry points, meaning purges the current VTable, <see cref="IVTable.Purge"/>
        /// </summary>
        /// <seealso cref="CurrentVTable"/>
        public void PurgeEntryPoints()
        {
            CurrentVTable.Purge();
        }
        
        /// <summary>
        /// Loads a given slot and entrypoint. Forwards to the current vtable.
        /// </summary>
        /// <param name="slot">The slot to load.</param>
        /// <param name="entryPoint">The entrypoint to load.</param>
        /// <returns>The loaded address.</returns>
        /// <seealso cref="CurrentVTable"/>
        /// <seealso cref="IVTable.Load"/>
        protected IntPtr Load(int slot, string entryPoint)
        {
            return CurrentVTable.Load(slot, entryPoint);
        }
    }
}
