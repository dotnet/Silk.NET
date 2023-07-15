// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IKsJackDescription"/> struct.</summary>
public static unsafe partial class IKsJackDescriptionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IKsJackDescription"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IKsJackDescription).GUID, Is.EqualTo(IID_IKsJackDescription));
    }

    /// <summary>Validates that the <see cref = "IKsJackDescription"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IKsJackDescription>(), Is.EqualTo(sizeof(IKsJackDescription)));
    }

    /// <summary>Validates that the <see cref = "IKsJackDescription"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IKsJackDescription).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IKsJackDescription"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IKsJackDescription), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IKsJackDescription), Is.EqualTo(4));
        }
    }
}