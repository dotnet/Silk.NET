// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roparameterizediid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IRoMetaDataLocator"/> struct.</summary>
public static unsafe partial class IRoMetaDataLocatorTests
{
    /// <summary>Validates that the <see cref = "IRoMetaDataLocator"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IRoMetaDataLocator>(), Is.EqualTo(sizeof(IRoMetaDataLocator)));
    }

    /// <summary>Validates that the <see cref = "IRoMetaDataLocator"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IRoMetaDataLocator).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IRoMetaDataLocator"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IRoMetaDataLocator), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IRoMetaDataLocator), Is.EqualTo(4));
        }
    }
}