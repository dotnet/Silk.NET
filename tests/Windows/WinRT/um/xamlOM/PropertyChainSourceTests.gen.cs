// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "PropertyChainSource"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class PropertyChainSourceTests
{
    /// <summary>Validates that the <see cref = "PropertyChainSource"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PropertyChainSource>(), Is.EqualTo(sizeof(PropertyChainSource)));
    }

    /// <summary>Validates that the <see cref = "PropertyChainSource"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PropertyChainSource).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PropertyChainSource"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PropertyChainSource), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(PropertyChainSource), Is.EqualTo(40));
        }
    }
}