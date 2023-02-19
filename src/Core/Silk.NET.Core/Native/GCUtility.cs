// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    public class GcUtility
    {
        private ConcurrentDictionary<int, List<Pinned>> _pins;

        // this should be a record but NS20 exists
        private readonly struct Pinned
        {
            public Pinned(GCHandle handle, bool untilNextCall)
            {
                this.Handle = handle;
                this.UntilNextCall = untilNextCall;
            }

            public GCHandle Handle { get; }
            public bool UntilNextCall { get; }
        }

        public GcUtility(int concurrencyLevel, int slotCount)
        {
            _pins = new ConcurrentDictionary<int, List<Pinned>>(concurrencyLevel, slotCount);
        }

        private void AddPin(int slot, Pinned pin) => _pins.AddOrUpdate
        (
            slot,
            _ => new List<Pinned> { pin },
            (_, list) =>
            {
                // Remove all the "until next call" pins for this slot.
                for (var i = 0; i < list.Count; i++)
                {
                    var existingPin = list[i];
                    if (existingPin.UntilNextCall)
                    {
                        existingPin.Handle.Free();
                        list.RemoveAt(i);
                        i--;
                    }
                }

                // add our new pin
                list.Add(pin);
                return list;
            }
        );

        public void PinUntilNextCall(object obj, int slot)
            => AddPin(slot, new Pinned(GCHandle.Alloc(obj), true));

        public void Pin(object obj, int slot)
            => AddPin(slot, new Pinned(GCHandle.Alloc(obj), false));

        public void Unpin(object obj, int? slot = null)
        {
            static void CoreUnpin(IList<Pinned> pins, object? shouldMatch = null)
            {
                for (var i = 0; i < pins.Count; i++)
                {
                    var pin = pins[i];
                    if (shouldMatch is null || pin.Handle.Target == shouldMatch)
                    {
                        pin.Handle.Free();
                        pins.RemoveAt(i);
                        i--;
                    }
                }
            }

            if (slot == null)
            {
                foreach (var list in _pins.Values)
                {
                    CoreUnpin(list, obj);
                }
            }
            else
            {
                CoreUnpin(_pins[slot.Value], obj);
            }
        }
    }
}
