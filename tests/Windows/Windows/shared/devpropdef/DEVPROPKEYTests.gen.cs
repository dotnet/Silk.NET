// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/devpropdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DEVPROPKEY"/> struct.</summary>
public static unsafe partial class DEVPROPKEYTests
{
    /// <summary>Validates that the <see cref = "DEVPROPKEY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DEVPROPKEY>(), Is.EqualTo(sizeof(DEVPROPKEY)));
    }

    /// <summary>Validates that the <see cref = "DEVPROPKEY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DEVPROPKEY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DEVPROPKEY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DEVPROPKEY), Is.EqualTo(20));
    }
}