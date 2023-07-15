// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IServerSecurity"/> struct.</summary>
public static unsafe partial class IServerSecurityTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IServerSecurity"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IServerSecurity).GUID, Is.EqualTo(IID_IServerSecurity));
    }

    /// <summary>Validates that the <see cref = "IServerSecurity"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IServerSecurity>(), Is.EqualTo(sizeof(IServerSecurity)));
    }

    /// <summary>Validates that the <see cref = "IServerSecurity"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IServerSecurity).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IServerSecurity"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IServerSecurity), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IServerSecurity), Is.EqualTo(4));
        }
    }
}