// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDirectManipulationPrimaryContent"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IDirectManipulationPrimaryContentTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDirectManipulationPrimaryContent"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDirectManipulationPrimaryContent).GUID, Is.EqualTo(IID_IDirectManipulationPrimaryContent));
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationPrimaryContent"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDirectManipulationPrimaryContent>(), Is.EqualTo(sizeof(IDirectManipulationPrimaryContent)));
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationPrimaryContent"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDirectManipulationPrimaryContent).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationPrimaryContent"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDirectManipulationPrimaryContent), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDirectManipulationPrimaryContent), Is.EqualTo(4));
        }
    }
}