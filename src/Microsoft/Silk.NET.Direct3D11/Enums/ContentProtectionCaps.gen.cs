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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Software\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_SOFTWARE")]
        ContentProtectionCapsSoftware = 0x1,
        [Obsolete("Deprecated in favour of \"Hardware\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE")]
        ContentProtectionCapsHardware = 0x2,
        [Obsolete("Deprecated in favour of \"ProtectionAlwaysOn\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_PROTECTION_ALWAYS_ON")]
        ContentProtectionCapsProtectionAlwaysOn = 0x4,
        [Obsolete("Deprecated in favour of \"PartialDecryption\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_PARTIAL_DECRYPTION")]
        ContentProtectionCapsPartialDecryption = 0x8,
        [Obsolete("Deprecated in favour of \"ContentKey\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_CONTENT_KEY")]
        ContentProtectionCapsContentKey = 0x10,
        [Obsolete("Deprecated in favour of \"FreshenSessionKey\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_FRESHEN_SESSION_KEY")]
        ContentProtectionCapsFreshenSessionKey = 0x20,
        [Obsolete("Deprecated in favour of \"EncryptedReadBack\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK")]
        ContentProtectionCapsEncryptedReadBack = 0x40,
        [Obsolete("Deprecated in favour of \"EncryptedReadBackKey\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK_KEY")]
        ContentProtectionCapsEncryptedReadBackKey = 0x80,
        [Obsolete("Deprecated in favour of \"SequentialCtrIV\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_SEQUENTIAL_CTR_IV")]
        ContentProtectionCapsSequentialCtrIV = 0x100,
        [Obsolete("Deprecated in favour of \"EncryptSlicedataOnly\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_ENCRYPT_SLICEDATA_ONLY")]
        ContentProtectionCapsEncryptSlicedataOnly = 0x200,
        [Obsolete("Deprecated in favour of \"DecryptionBlt\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_DECRYPTION_BLT")]
        ContentProtectionCapsDecryptionBlt = 0x400,
        [Obsolete("Deprecated in favour of \"HardwareProtectUncompressed\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECT_UNCOMPRESSED")]
        ContentProtectionCapsHardwareProtectUncompressed = 0x800,
        [Obsolete("Deprecated in favour of \"HardwareProtectedMemoryPageable\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECTED_MEMORY_PAGEABLE")]
        ContentProtectionCapsHardwareProtectedMemoryPageable = 0x1000,
        [Obsolete("Deprecated in favour of \"HardwareTeardown\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_TEARDOWN")]
        ContentProtectionCapsHardwareTeardown = 0x2000,
        [Obsolete("Deprecated in favour of \"HardwareDrmCommunication\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION")]
        ContentProtectionCapsHardwareDrmCommunication = 0x4000,
        [Obsolete("Deprecated in favour of \"HardwareDrmCommunicationMultiThreaded\"")]
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION_MULTI_THREADED")]
        ContentProtectionCapsHardwareDrmCommunicationMultiThreaded = 0x8000,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_SOFTWARE")]
        Software = 0x1,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE")]
        Hardware = 0x2,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_PROTECTION_ALWAYS_ON")]
        ProtectionAlwaysOn = 0x4,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_PARTIAL_DECRYPTION")]
        PartialDecryption = 0x8,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_CONTENT_KEY")]
        ContentKey = 0x10,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_FRESHEN_SESSION_KEY")]
        FreshenSessionKey = 0x20,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK")]
        EncryptedReadBack = 0x40,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK_KEY")]
        EncryptedReadBackKey = 0x80,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_SEQUENTIAL_CTR_IV")]
        SequentialCtrIV = 0x100,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_ENCRYPT_SLICEDATA_ONLY")]
        EncryptSlicedataOnly = 0x200,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_DECRYPTION_BLT")]
        DecryptionBlt = 0x400,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECT_UNCOMPRESSED")]
        HardwareProtectUncompressed = 0x800,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECTED_MEMORY_PAGEABLE")]
        HardwareProtectedMemoryPageable = 0x1000,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_TEARDOWN")]
        HardwareTeardown = 0x2000,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION")]
        HardwareDrmCommunication = 0x4000,
        [NativeName("Name", "D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION_MULTI_THREADED")]
        HardwareDrmCommunicationMultiThreaded = 0x8000,
    }
}
