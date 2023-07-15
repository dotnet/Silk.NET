// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "Windows"/> class.</summary>
public static partial class WindowsTests
{
    /// <summary>Validates that the value of the <see cref = "Identity_LocalUserProvider"/> property is correct.</summary>
    [Test]
    public static void Identity_LocalUserProviderTest()
    {
        Assert.That(Identity_LocalUserProvider, Is.EqualTo(new Guid(0xA198529B, 0x730F, 0x4089, 0xB6, 0x46, 0xA1, 0x25, 0x57, 0xF5, 0x66, 0x5E)));
    }
}