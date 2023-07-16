// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "VisualElement"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class VisualElementTests
{
    /// <summary>Validates that the <see cref = "VisualElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VisualElement>(), Is.EqualTo(sizeof(VisualElement)));
    }

    /// <summary>Validates that the <see cref = "VisualElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VisualElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "VisualElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(VisualElement), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(VisualElement), Is.EqualTo(40));
        }
    }
}