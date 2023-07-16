// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DCompManipulationCompositor"/> struct.</summary>
public static unsafe partial class DCompManipulationCompositorTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DCompManipulationCompositor"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DCompManipulationCompositor).GUID, Is.EqualTo(CLSID_DCompManipulationCompositor));
    }

    /// <summary>Validates that the <see cref = "DCompManipulationCompositor"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DCompManipulationCompositor>(), Is.EqualTo(sizeof(DCompManipulationCompositor)));
    }

    /// <summary>Validates that the <see cref = "DCompManipulationCompositor"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DCompManipulationCompositor).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DCompManipulationCompositor"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DCompManipulationCompositor), Is.EqualTo(1));
    }
}