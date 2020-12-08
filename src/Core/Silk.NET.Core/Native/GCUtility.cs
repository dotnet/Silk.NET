// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// Garbage Collector (GC) Utilities
    /// </summary>
    /// <seealso cref="NativeApiContainer"/>
    public class GcUtility
    {
        /// <summary>
        /// A collection of all pins currently maintained by this GcUtility, indexed by slot.
        /// </summary>
        public ConcurrentDictionary<int, List<GCHandle>> Pins { get; }

        /// <summary>
        /// Creates a new instance of <see cref="GcUtility"/> with the given concurrency level, and the given maximum slot count.
        /// </summary>
        /// <param name="concurrencyLevel">The concurrency level.</param>
        /// <param name="slotCount">The maximum slot count.</param>
        public GcUtility(int concurrencyLevel, int slotCount)
        {
            Pins = new ConcurrentDictionary<int, List<GCHandle>>(concurrencyLevel, slotCount);
        }
        
        /// <summary>
        /// Pin the given object until the next call.
        /// </summary>
        /// <param name="obj">The object to pin.</param>
        /// <param name="slot">The slot to associate this with.</param>
        /// <remarks>DO NOT USE TOGETHER WITH <see cref="Pin"/>.</remarks>
        public void PinUntilNextCall(object obj, int slot)
        {
            Pins.AddOrUpdate
            (
                slot, i =>
                {
                    var list = new List<GCHandle>();
                    list.Add(GCHandle.Alloc(obj));
                    return list;
                }, (i, list) =>
                {
                    list.Clear();
                    list.Add(GCHandle.Alloc(obj));
                    return list;
                }
            );
        }

        /// <summary>
        /// Pin the given object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="slot">The slot to associate this with.</param>
        public void Pin(object obj, int slot = -1)
        {
            Pins.AddOrUpdate
            (
                slot, i =>
                {
                    var list = new List<GCHandle>();
                    list.Add(GCHandle.Alloc(obj));
                    return list;
                }, (i, list) =>
                {
                    list.Add(GCHandle.Alloc(obj));
                    return list;
                }
            );
        }

        /// <summary>
        /// Unpin the given object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="slot">Optionally, the slot this was associated with initially.</param>
        public void Unpin(object obj, int? slot = null)
        {
            if (slot == null)
            {
                foreach (var list in Pins.Values)
                {
                    foreach (var handle in list)
                    {
                        if (handle.Target == obj)
                        {
                            handle.Free();
                        }
                    }
                }
            }
            else
            {
                foreach (var handle in Pins[slot.Value])
                {
                    if (handle.Target == obj)
                    {
                        handle.Free();
                    }
                }
            }
        }
    }
}
