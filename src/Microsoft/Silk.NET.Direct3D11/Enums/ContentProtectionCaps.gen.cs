// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS")]
    public enum ContentProtectionCaps : int
    {
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_SOFTWARE")]
        ContentProtectionCapsSoftware = 0x1,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE")]
        ContentProtectionCapsHardware = 0x2,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_PROTECTION_ALWAYS_ON")]
        ContentProtectionCapsProtectionAlwaysOn = 0x4,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_PARTIAL_DECRYPTION")]
        ContentProtectionCapsPartialDecryption = 0x8,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_CONTENT_KEY")]
        ContentProtectionCapsContentKey = 0x10,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_FRESHEN_SESSION_KEY")]
        ContentProtectionCapsFreshenSessionKey = 0x20,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK")]
        ContentProtectionCapsEncryptedReadBack = 0x40,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK_KEY")]
        ContentProtectionCapsEncryptedReadBackKey = 0x80,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_SEQUENTIAL_CTR_IV")]
        ContentProtectionCapsSequentialCtrIV = 0x100,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_ENCRYPT_SLICEDATA_ONLY")]
        ContentProtectionCapsEncryptSlicedataOnly = 0x200,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_DECRYPTION_BLT")]
        ContentProtectionCapsDecryptionBlt = 0x400,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECT_UNCOMPRESSED")]
        ContentProtectionCapsHardwareProtectUncompressed = 0x800,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECTED_MEMORY_PAGEABLE")]
        ContentProtectionCapsHardwareProtectedMemoryPageable = 0x1000,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_TEARDOWN")]
        ContentProtectionCapsHardwareTeardown = 0x2000,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION")]
        ContentProtectionCapsHardwareDrmCommunication = 0x4000,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION_MULTI_THREADED")]
        ContentProtectionCapsHardwareDrmCommunicationMultiThreaded = 0x8000,
    }
}
