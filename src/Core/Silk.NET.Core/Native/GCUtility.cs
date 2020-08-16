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
    public class GcUtility
    {
        public ConcurrentDictionary<int, List<GCHandle>> Pins { get; }

        public GcUtility(int concurrencyLevel, int slotCount)
        {
            Pins = new ConcurrentDictionary<int, List<GCHandle>>(concurrencyLevel, slotCount);
        }
        
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
