// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_SCRIPT_TOPOLOGY")]
    public enum PanoseScriptTopology : int
    {
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_TOPOLOGY_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_TOPOLOGY_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_TOPOLOGY_ROMAN_DISCONNECTED")]
        RomanDisconnected = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_TOPOLOGY_ROMAN_TRAILING")]
        RomanTrailing = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_TOPOLOGY_ROMAN_CONNECTED")]
        RomanConnected = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_TOPOLOGY_CURSIVE_DISCONNECTED")]
        CursiveDisconnected = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_TOPOLOGY_CURSIVE_TRAILING")]
        CursiveTrailing = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_TOPOLOGY_CURSIVE_CONNECTED")]
        CursiveConnected = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_TOPOLOGY_BLACKLETTER_DISCONNECTED")]
        BlackletterDisconnected = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_TOPOLOGY_BLACKLETTER_TRAILING")]
        BlackletterTrailing = 0x9,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_TOPOLOGY_BLACKLETTER_CONNECTED")]
        BlackletterConnected = 0xA,
    }
}
