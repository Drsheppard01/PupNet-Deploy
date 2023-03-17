// -----------------------------------------------------------------------------
// PROJECT   : PupNet
// COPYRIGHT : Andy Thomas (C) 2022-23
// LICENSE   : GPL-3.0-or-later
// HOMEPAGE  : https://github.com/kuiperzone/PupNet
//
// PupNet is free software: you can redistribute it and/or modify it under
// the terms of the GNU General Public License as published by the Free Software
// Foundation, either version 3 of the License, or (at your option) any later version.
//
// PupNet is distributed in the hope that it will be useful, but WITHOUT
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
// FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along
// with PupNet. If not, see <https://www.gnu.org/licenses/>.
// -----------------------------------------------------------------------------

using KuiperZone.PupNet.Builders;

namespace KuiperZone.PupNet;

/// <summary>
/// Creates a concrete instance of <see cref="PackageBuilder"/>.
/// </summary>
public class BuilderFactory
{
    /// <summary>
    /// Creates.
    /// </summary>
    public PackageBuilder Create(ConfigurationReader conf)
    {
        switch (conf.Arguments.Kind)
        {
            case DeployKind.AppImage: return new AppImageBuilder(conf);
            case DeployKind.Flatpak: return new FlatpakBuilder(conf);
            case DeployKind.Rpm: return new RpmBuilder(conf);
            case DeployKind.Deb: return new DebBuilder(conf);
            case DeployKind.Setup: return new SetupBuilder(conf);
            case DeployKind.Zip: return new ZipBuilder(conf);
            default: throw new ArgumentException($"Invalid or unsupported {nameof(DeployKind)} {conf.Arguments.Kind}");
        }
    }

    /// <summary>
    /// Creates with dummy configuration.
    /// </summary>
    public PackageBuilder Create(DeployKind kind)
    {
        return Create(new ConfigurationReader(kind));
    }
}