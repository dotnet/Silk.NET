// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "_IManipulationEvents"/> struct.</summary>
public static unsafe partial class _IManipulationEventsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "_IManipulationEvents"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(_IManipulationEvents).GUID, Is.EqualTo(IID__IManipulationEvents));
    }

    /// <summary>Validates that the <see cref = "_IManipulationEvents"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<_IManipulationEvents>(), Is.EqualTo(sizeof(_IManipulationEvents)));
    }

    /// <summary>Validates that the <see cref = "_IManipulationEvents"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(_IManipulationEvents).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "_IManipulationEvents"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(_IManipulationEvents), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(_IManipulationEvents), Is.EqualTo(4));
        }
    }
}