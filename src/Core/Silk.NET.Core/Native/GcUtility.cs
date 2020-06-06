// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    public sealed class GcUtility
    {
        public Dictionary<int, List<GCHandle>> Pins { get; } = new Dictionary<int, List<GCHandle>>();

        public void PinUntilNextCall(object obj, int slot)
        {
            if (!Pins.ContainsKey(slot))
            {
                Pins[slot] = new List<GCHandle>();
            }

            foreach (var gcHandle in Pins[slot])
            {
                gcHandle.Free();
            }

            Pins[slot].Clear();
            Pins[slot].Add(GCHandle.Alloc(obj));
        }

        public void Pin(object obj, int slot = -1)
        {
            if (!Pins.ContainsKey(slot))
            {
                Pins[slot] = new List<GCHandle>();
            }

            Pins[slot].Add(GCHandle.Alloc(obj));
        }

        [SuppressMessage("ReSharper", "ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator")]
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

        ~GcUtility()
        {
            
        }
    }
}
