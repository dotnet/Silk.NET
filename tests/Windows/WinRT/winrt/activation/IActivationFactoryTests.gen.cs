// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/activation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IActivationFactory"/> struct.</summary>
public static unsafe partial class IActivationFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IActivationFactory"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IActivationFactory).GUID, Is.EqualTo(IID_IActivationFactory));
    }

    /// <summary>Validates that the <see cref = "IActivationFactory"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IActivationFactory>(), Is.EqualTo(sizeof(IActivationFactory)));
    }

    /// <summary>Validates that the <see cref = "IActivationFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IActivationFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IActivationFactory"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IActivationFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IActivationFactory), Is.EqualTo(4));
        }
    }
}