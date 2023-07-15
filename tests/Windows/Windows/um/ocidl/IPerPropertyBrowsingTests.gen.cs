// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IPerPropertyBrowsing"/> struct.</summary>
public static unsafe partial class IPerPropertyBrowsingTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPerPropertyBrowsing"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPerPropertyBrowsing).GUID, Is.EqualTo(IID_IPerPropertyBrowsing));
    }

    /// <summary>Validates that the <see cref = "IPerPropertyBrowsing"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPerPropertyBrowsing>(), Is.EqualTo(sizeof(IPerPropertyBrowsing)));
    }

    /// <summary>Validates that the <see cref = "IPerPropertyBrowsing"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPerPropertyBrowsing).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPerPropertyBrowsing"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPerPropertyBrowsing), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPerPropertyBrowsing), Is.EqualTo(4));
        }
    }
}