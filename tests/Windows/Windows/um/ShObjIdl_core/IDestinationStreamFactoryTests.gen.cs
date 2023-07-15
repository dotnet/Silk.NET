// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IDestinationStreamFactory"/> struct.</summary>
public static unsafe partial class IDestinationStreamFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDestinationStreamFactory"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDestinationStreamFactory).GUID, Is.EqualTo(IID_IDestinationStreamFactory));
    }

    /// <summary>Validates that the <see cref = "IDestinationStreamFactory"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDestinationStreamFactory>(), Is.EqualTo(sizeof(IDestinationStreamFactory)));
    }

    /// <summary>Validates that the <see cref = "IDestinationStreamFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDestinationStreamFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDestinationStreamFactory"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDestinationStreamFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDestinationStreamFactory), Is.EqualTo(4));
        }
    }
}