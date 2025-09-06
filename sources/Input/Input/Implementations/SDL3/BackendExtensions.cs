// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text;

namespace Silk.NET.Input.SDL3;

internal static unsafe class BackendExtensions
{
    public static IntPtr FallbackUniqueId(this SdlInputBackend backend, uint sdlDeviceId, nint uniqueId)
    {
        Console.Error.WriteLine("Failed to create a deterministically unique identifier for joystick");
        return uniqueId ^ ((nint)sdlDeviceId | ((nint)sdlDeviceId << 16));
    }

    public static bool AttemptUniqueId(this SdlInputBackend sdlInputBackend, Ptr<sbyte> ptr, ref nint uniqueId1)
    {
        if (ptr.Native == null)
            return false;

        var name = ptr.ReadToString();
        var bytes = Encoding.Default.GetBytes(name);
        return AttemptUniqueId(sdlInputBackend, bytes, ref uniqueId1);
    }

    public static bool AttemptUniqueId<T>(this SdlInputBackend sdlInputBackend, T ptr, ref nint uniqueId1)
        where T : unmanaged =>
        AttemptUniqueId(sdlInputBackend, new ReadOnlySpan<byte>(&ptr, sizeof(T)), ref uniqueId1);

    public static bool AttemptUniqueId(this SdlInputBackend sdlInputBackend, ReadOnlySpan<byte> bytes, ref nint uniqueId1)
    {
        uniqueId1 = Modify(uniqueId1, bytes);
        return sdlInputBackend.DeviceRegistry.Add(uniqueId1);
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
