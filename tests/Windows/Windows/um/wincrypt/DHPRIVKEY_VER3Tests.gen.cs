// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DHPRIVKEY_VER3"/> struct.</summary>
public static unsafe partial class DHPRIVKEY_VER3Tests
{
    /// <summary>Validates that the <see cref = "DHPRIVKEY_VER3"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DHPRIVKEY_VER3>(), Is.EqualTo(sizeof(DHPRIVKEY_VER3)));
    }

    /// <summary>Validates that the <see cref = "DHPRIVKEY_VER3"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DHPRIVKEY_VER3).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DHPRIVKEY_VER3"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DHPRIVKEY_VER3), Is.EqualTo(44));
    }
}