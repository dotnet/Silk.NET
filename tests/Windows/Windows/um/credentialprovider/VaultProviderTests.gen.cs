// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "VaultProvider"/> struct.</summary>
public static unsafe partial class VaultProviderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "VaultProvider"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(VaultProvider).GUID, Is.EqualTo(IID_VaultProvider));
    }

    /// <summary>Validates that the <see cref = "VaultProvider"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VaultProvider>(), Is.EqualTo(sizeof(VaultProvider)));
    }

    /// <summary>Validates that the <see cref = "VaultProvider"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VaultProvider).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "VaultProvider"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(VaultProvider), Is.EqualTo(1));
    }
}