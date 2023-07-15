// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IPropertySystemChangeNotify"/> struct.</summary>
public static unsafe partial class IPropertySystemChangeNotifyTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPropertySystemChangeNotify"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPropertySystemChangeNotify).GUID, Is.EqualTo(IID_IPropertySystemChangeNotify));
    }

    /// <summary>Validates that the <see cref = "IPropertySystemChangeNotify"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPropertySystemChangeNotify>(), Is.EqualTo(sizeof(IPropertySystemChangeNotify)));
    }

    /// <summary>Validates that the <see cref = "IPropertySystemChangeNotify"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPropertySystemChangeNotify).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPropertySystemChangeNotify"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPropertySystemChangeNotify), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPropertySystemChangeNotify), Is.EqualTo(4));
        }
    }
}