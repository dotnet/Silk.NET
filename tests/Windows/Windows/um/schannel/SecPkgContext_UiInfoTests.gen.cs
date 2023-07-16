// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SecPkgContext_UiInfo"/> struct.</summary>
public static unsafe partial class SecPkgContext_UiInfoTests
{
    /// <summary>Validates that the <see cref = "SecPkgContext_UiInfo"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SecPkgContext_UiInfo>(), Is.EqualTo(sizeof(SecPkgContext_UiInfo)));
    }

    /// <summary>Validates that the <see cref = "SecPkgContext_UiInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SecPkgContext_UiInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SecPkgContext_UiInfo"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SecPkgContext_UiInfo), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(SecPkgContext_UiInfo), Is.EqualTo(4));
        }
    }
}