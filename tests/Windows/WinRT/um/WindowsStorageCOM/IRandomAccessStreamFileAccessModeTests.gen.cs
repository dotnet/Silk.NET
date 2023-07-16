// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IRandomAccessStreamFileAccessMode"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class IRandomAccessStreamFileAccessModeTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IRandomAccessStreamFileAccessMode"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IRandomAccessStreamFileAccessMode).GUID, Is.EqualTo(IID_IRandomAccessStreamFileAccessMode));
    }

    /// <summary>Validates that the <see cref = "IRandomAccessStreamFileAccessMode"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IRandomAccessStreamFileAccessMode>(), Is.EqualTo(sizeof(IRandomAccessStreamFileAccessMode)));
    }

    /// <summary>Validates that the <see cref = "IRandomAccessStreamFileAccessMode"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IRandomAccessStreamFileAccessMode).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IRandomAccessStreamFileAccessMode"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IRandomAccessStreamFileAccessMode), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IRandomAccessStreamFileAccessMode), Is.EqualTo(4));
        }
    }
}