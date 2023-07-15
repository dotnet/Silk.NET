// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DirectManipulationUpdateManager"/> struct.</summary>
public static unsafe partial class DirectManipulationUpdateManagerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DirectManipulationUpdateManager"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DirectManipulationUpdateManager).GUID, Is.EqualTo(CLSID_DirectManipulationUpdateManager));
    }

    /// <summary>Validates that the <see cref = "DirectManipulationUpdateManager"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DirectManipulationUpdateManager>(), Is.EqualTo(sizeof(DirectManipulationUpdateManager)));
    }

    /// <summary>Validates that the <see cref = "DirectManipulationUpdateManager"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DirectManipulationUpdateManager).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DirectManipulationUpdateManager"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DirectManipulationUpdateManager), Is.EqualTo(1));
    }
}