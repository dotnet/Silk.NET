// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "XAPO_REGISTRATION_PROPERTIES"/> struct.</summary>
public static unsafe partial class XAPO_REGISTRATION_PROPERTIESTests
{
    /// <summary>Validates that the <see cref = "XAPO_REGISTRATION_PROPERTIES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<XAPO_REGISTRATION_PROPERTIES>(), Is.EqualTo(sizeof(XAPO_REGISTRATION_PROPERTIES)));
    }

    /// <summary>Validates that the <see cref = "XAPO_REGISTRATION_PROPERTIES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XAPO_REGISTRATION_PROPERTIES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "XAPO_REGISTRATION_PROPERTIES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(XAPO_REGISTRATION_PROPERTIES), Is.EqualTo(1068));
    }
}