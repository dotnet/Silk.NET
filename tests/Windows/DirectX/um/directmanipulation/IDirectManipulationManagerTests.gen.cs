// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDirectManipulationManager"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IDirectManipulationManagerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDirectManipulationManager"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDirectManipulationManager).GUID, Is.EqualTo(IID_IDirectManipulationManager));
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationManager"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDirectManipulationManager>(), Is.EqualTo(sizeof(IDirectManipulationManager)));
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationManager"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDirectManipulationManager).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationManager"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDirectManipulationManager), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDirectManipulationManager), Is.EqualTo(4));
        }
    }
}