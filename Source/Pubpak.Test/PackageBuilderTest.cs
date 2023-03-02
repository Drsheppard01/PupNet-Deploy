// -----------------------------------------------------------------------------
// PROJECT   : Pubpak
// COPYRIGHT : Andy Thomas (C) 2022-23
// LICENSE   : GPL-3.0-or-later
// HOMEPAGE  : https://github.com/kuiperzone/Pubpak
//
// Pubpak is free software: you can redistribute it and/or modify it under
// the terms of the GNU General Public License as published by the Free Software
// Foundation, either version 3 of the License, or (at your option) any later version.
//
// Pubpak is distributed in the hope that it will be useful, but WITHOUT
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
// FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along
// with Pubpak. If not, see <https://www.gnu.org/licenses/>.
// -----------------------------------------------------------------------------

namespace KuiperZone.Pubpak.Test;

public class PackageBuilderTest
{
    [Fact]
    public void AppImage_DecodesOK()
    {
        var builder = new PackageBuilder(new DummyConf(PackKind.AppImage));

        AssertOK(builder);
    }

    [Fact]
    public void Flatpak_DecodesOK()
    {
        var builder = new PackageBuilder(new DummyConf(PackKind.Flatpak));

        AssertOK(builder);
    }

    [Fact]
    public void Rpm_DecodesOK()
    {
        var builder = new PackageBuilder(new DummyConf(PackKind.Rpm));

        AssertOK(builder);
    }

    private void AssertOK(PackageBuilder builder)
    {
        Console.WriteLine(builder.ToString(true));
    }
}