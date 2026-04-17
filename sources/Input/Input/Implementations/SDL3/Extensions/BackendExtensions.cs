// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input.SDL3;

internal static unsafe class BackendExtensions
{
    extension(SdlInputBackend backend)
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint FallbackUniqueId<T>(ulong sdlDeviceId, nint uniqueId)
        {
            InputLog.Warn($"Failed to create a deterministically unique identifier for device {sdlDeviceId} ({typeof(T).Name}).");

            // set the highest bit of the unique id as a hint that the id was not unique
            var highestBit = (nint)1 << ((sizeof(nint) * 8) - 1);
            var typeHash = (nint)typeof(T).GetHashCode();

            if (sdlDeviceId == 0 && uniqueId == 0)
            {
                return highestBit ^ typeHash;
            }

            if (uniqueId == 0)
            {
                return highestBit ^ (typeHash & (nint)sdlDeviceId);
            }

            if (sdlDeviceId == 0)
            {
                return highestBit ^ (typeHash & uniqueId);
            }

            return uniqueId ^ ( highestBit | ((nint)sdlDeviceId ^ ((nint)sdlDeviceId << (sizeof(nint) / 2))));
        }

        public bool AttemptUniqueId(Ptr<sbyte> ptr, ref nint uniqueId1)
        {
            if (ptr.Native == null)
            {
                return false;
            }

            var name = ptr.ReadToString();
            var bytes = Encoding.Default.GetBytes(name);
            return backend.AttemptUniqueId(bytes, ref uniqueId1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool AttemptUniqueId<T>(T value, ref nint uniqueId1)
            where T : unmanaged =>
            backend.AttemptUniqueId(new ReadOnlySpan<byte>(&value, sizeof(T)), ref uniqueId1);

        public bool AttemptUniqueId(ReadOnlySpan<byte> bytes, ref nint uniqueId1)
        {
            uniqueId1 = Modify(uniqueId1, bytes);
            return !backend.ContainsDevice(uniqueId1);
            static nint Modify(nint original, ReadOnlySpan<byte> withBytes)
            {
                if (sizeof(nint) == 4)
                {
                    var hash = new HashCode();
                    foreach(var b in withBytes)
                    {
                        hash.Add(b);
                    }

                    var hashCode = hash.ToHashCode();
                    return original ^ *(nint*)(&hashCode);
                }

                var hash64Bytes = (byte*)&original;

                for (int i = 0; i < withBytes.Length; i += 8)
                {
                    hash64Bytes[i % 8] ^= withBytes[i];
                }

                return *(nint*)hash64Bytes;
            }

        }
    }
}
