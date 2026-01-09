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
        public static nint FallbackUniqueId(ulong sdlDeviceId, nint uniqueId)
        {
            InputLog.Warn($"Failed to create a deterministically unique identifier for device {sdlDeviceId}.");
            return uniqueId ^ ((nint)sdlDeviceId | ((nint)sdlDeviceId << 16));
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
            return backend.RegisterDevice(uniqueId1);
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
