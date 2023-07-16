// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/RadialControllerInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IRadialControllerInterop"/> struct.</summary>
[SupportedOSPlatform("windows10.0.14393.0")]
public static unsafe partial class IRadialControllerInteropTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IRadialControllerInterop"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IRadialControllerInterop).GUID, Is.EqualTo(IID_IRadialControllerInterop));
    }

    /// <summary>Validates that the <see cref = "IRadialControllerInterop"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IRadialControllerInterop>(), Is.EqualTo(sizeof(IRadialControllerInterop)));
    }

    /// <summary>Validates that the <see cref = "IRadialControllerInterop"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IRadialControllerInterop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IRadialControllerInterop"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IRadialControllerInterop), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IRadialControllerInterop), Is.EqualTo(4));
        }
    }
}