// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "PropertyChainValue"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class PropertyChainValueTests
{
    /// <summary>Validates that the <see cref = "PropertyChainValue"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PropertyChainValue>(), Is.EqualTo(sizeof(PropertyChainValue)));
    }

    /// <summary>Validates that the <see cref = "PropertyChainValue"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PropertyChainValue).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PropertyChainValue"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PropertyChainValue), Is.EqualTo(80));
        }
        else
        {
            Assert.That(sizeof(PropertyChainValue), Is.EqualTo(48));
        }
    }
}