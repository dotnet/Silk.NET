// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DirectManipulationManager"/> struct.</summary>
public static unsafe partial class DirectManipulationManagerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DirectManipulationManager"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DirectManipulationManager).GUID, Is.EqualTo(CLSID_DirectManipulationManager));
    }

    /// <summary>Validates that the <see cref = "DirectManipulationManager"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DirectManipulationManager>(), Is.EqualTo(sizeof(DirectManipulationManager)));
    }

    /// <summary>Validates that the <see cref = "DirectManipulationManager"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DirectManipulationManager).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DirectManipulationManager"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DirectManipulationManager), Is.EqualTo(1));
    }
}