// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDirectManipulationAutoScrollBehavior"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IDirectManipulationAutoScrollBehaviorTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDirectManipulationAutoScrollBehavior"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDirectManipulationAutoScrollBehavior).GUID, Is.EqualTo(IID_IDirectManipulationAutoScrollBehavior));
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationAutoScrollBehavior"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDirectManipulationAutoScrollBehavior>(), Is.EqualTo(sizeof(IDirectManipulationAutoScrollBehavior)));
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationAutoScrollBehavior"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDirectManipulationAutoScrollBehavior).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationAutoScrollBehavior"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDirectManipulationAutoScrollBehavior), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDirectManipulationAutoScrollBehavior), Is.EqualTo(4));
        }
    }
}