// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Input.Extensions
{
    public sealed class KeyboardState : IDisposable
    {
        private readonly int _keyCount, _pressedKeyCount;
        private readonly IMemoryOwner<byte> _keys, _pressedKeys;

        internal KeyboardState(IKeyboard keyboard, MemoryPool<byte> pool)
        {
            // The comments within this method were sponsored by my rubber duck

            // Properties
            Name = keyboard.Name;
            Index = keyboard.Index;
            IsConnected = keyboard.IsConnected;

            // Initial rentals
            var srcKeys = keyboard.SupportedKeys;
            _keyCount = _pressedKeyCount = srcKeys.Count;
            _keys = pool.Rent(_keyCount * sizeof(Key));
            _pressedKeys = pool.Rent(_keyCount * sizeof(Key)); // we don't know how many keys are pressed, rent fully
            
            // Copy the supported and pressed keys 
            var dstKeys = GetSupportedKeys(); // get a span of our newly rented key memory
            _pressedKeyCount = _keyCount; // set the pressed key count to the full rental we just did
            var dstPressedKeys = GetPressedKeys(); // get a span over the full rental
            _pressedKeyCount = 0; // set key count back to zero so we can count how many keys are pressed
            for (var i = 0; i < _keyCount; i++)
            {
                dstKeys[i] = srcKeys[i];
                if (keyboard.IsKeyPressed(srcKeys[i]))
                {
                    dstPressedKeys[_pressedKeyCount++] = srcKeys[i];
                }
            }
            
            // Trim the pressed keys span
            dstPressedKeys = GetPressedKeys(); // recreate the span over the full rental with the trimmed count
            using var wip = _pressedKeys; // create a variable with the full rental that we dispose of once we're done
            _pressedKeys = pool.Rent(_pressedKeyCount * sizeof(Key)); // create the trimmed rental
            dstPressedKeys.CopyTo(GetPressedKeys()); // copy the trimmed span over the full rental to the trimmed rental
        }

        public string Name { get; }

        public int Index { get; }

        public bool IsConnected { get; }

        public bool IsKeyPressed(Key key)
        {
            foreach (var pressedKey in GetPressedKeys())
            {
                if (pressedKey == key)
                {
                    return true;
                }
            }

            return false;
        }

        public unsafe Span<Key> GetSupportedKeys()
            => new(Unsafe.AsPointer(ref _keys.Memory.Span.GetPinnableReference()), _keyCount);
        public unsafe Span<Key> GetPressedKeys()
            => new(Unsafe.AsPointer(ref _pressedKeys.Memory.Span.GetPinnableReference()), _pressedKeyCount);

        public void Dispose()
        {
            _keys?.Dispose();
            _pressedKeys?.Dispose();
        }
    }
}
