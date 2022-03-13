using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace GrandLarceny.Systems
{
    /// <summary>
    /// Represents a system which provides the map icons for players.
    /// </summary>
    public class MapMarkerSystem : ISystem
    {
        [Event]
        public void OnPlayerConnect(Player player)
        {
            player.SetMapIcon(49, new Vector3(822.6f, -1590.3f, 13.5f), (MapIcon) 7, default, MapIconType.Local);
            player.SetMapIcon(50, new Vector3(-2570.1f, 245.4f, 10.3f), (MapIcon) 7, default, MapIconType.Local);
            player.SetMapIcon(51, new Vector3(2726.6f, -2026.4f, 17.5f), (MapIcon) 7, default, MapIconType.Local);
            player.SetMapIcon(52, new Vector3(2080.3f, 2119.0f, 10.8f), (MapIcon) 7, default, MapIconType.Local);
            player.SetMapIcon(53, new Vector3(675.7f, -496.6f, 16.8f), (MapIcon) 7, default, MapIconType.Local);
            player.SetMapIcon(54, new Vector3(-1805.7f, 943.2f, 24.8f), (MapIcon) 29, default, MapIconType.Local);
            player.SetMapIcon(55, new Vector3(2750.9f, 2470.9f, 11.0f), (MapIcon) 29, default, MapIconType.Local);
            player.SetMapIcon(56, new Vector3(2351.8f, 2529.0f, 10.8f), (MapIcon) 29, default, MapIconType.Local);
            player.SetMapIcon(57, new Vector3(2635.5f, 1847.4f, 11.0f), (MapIcon) 29, default, MapIconType.Local);
            player.SetMapIcon(58, new Vector3(2083.4f, 2221.0f, 11.0f), (MapIcon) 29, default, MapIconType.Local);
            player.SetMapIcon(59, new Vector3(-1719.1f, 1359.4f, 8.6f), (MapIcon) 29, default, MapIconType.Local);
            player.SetMapIcon(60, new Vector3(2330.2f, 75.2f, 31.0f), (MapIcon) 29, default, MapIconType.Local);
            player.SetMapIcon(61, new Vector3(203.2f, -200.4f, 6.5f), (MapIcon) 29, default, MapIconType.Local);
            player.SetMapIcon(62, new Vector3(812.9f, -1616.1f, 13.6f), (MapIcon) 10, default, MapIconType.Local);
            player.SetMapIcon(63, new Vector3(1199.1f, -924.0f, 43.3f), (MapIcon) 10, default, MapIconType.Local);
            player.SetMapIcon(64, new Vector3(2362.2f, 2069.9f, 10.8f), (MapIcon) 10, default, MapIconType.Local);
            player.SetMapIcon(65, new Vector3(2469.5f, 2033.8f, 10.8f), (MapIcon) 10, default, MapIconType.Local);
            player.SetMapIcon(66, new Vector3(2172.9f, 2795.7f, 10.8f), (MapIcon) 10, default, MapIconType.Local);
            player.SetMapIcon(67, new Vector3(1875.3f, 2072.0f, 10.8f), (MapIcon) 10, default, MapIconType.Local);
            player.SetMapIcon(68, new Vector3(1161.5f, 2072.0f, 10.8f), (MapIcon) 10, default, MapIconType.Local);
            player.SetMapIcon(69, new Vector3(-2356.0f, 1009.0f, 49.0f), (MapIcon) 10, default, MapIconType.Local);
            player.SetMapIcon(70, new Vector3(-1913.3f, 826.2f, 36.9f), (MapIcon) 10, default, MapIconType.Local);
            player.SetMapIcon(71, new Vector3(-2335.6f, -165.6f, 39.5f), (MapIcon) 10, default, MapIconType.Local);
            player.SetMapIcon(72, new Vector3(2397.8f, -1895.6f, 13.7f), (MapIcon) 14, default, MapIconType.Local);
            player.SetMapIcon(73, new Vector3(2421.6f, -1509.6f, 24.1f), (MapIcon) 14, default, MapIconType.Local);
            player.SetMapIcon(74, new Vector3(-2671.6f, 257.4f, 4.6f), (MapIcon) 14, default, MapIconType.Local);
            player.SetMapIcon(75, new Vector3(2392.4f, 2046.5f, 10.8f), (MapIcon) 14, default, MapIconType.Local);
            player.SetMapIcon(76, new Vector3(2844.5f, 2401.1f, 11.0f), (MapIcon) 14, default, MapIconType.Local);
            player.SetMapIcon(77, new Vector3(2635.5f, 1674.3f, 11.0f), (MapIcon) 14, default, MapIconType.Local);
            player.SetMapIcon(78, new Vector3(2105.7f, 2228.7f, 11.0f), (MapIcon) 14, default, MapIconType.Local);
            player.SetMapIcon(79, new Vector3(-2154.0f, -2461.2f, 30.8f), (MapIcon) 14, default, MapIconType.Local);
            player.SetMapIcon(80, new Vector3(-1816.2f, 620.8f, 37.5f), (MapIcon) 14, default, MapIconType.Local);
            player.SetMapIcon(81, new Vector3(-1216.0f, 1831.4f, 45.3f), (MapIcon) 14, default, MapIconType.Local);
            player.SetMapIcon(82, new Vector3(172.73f, 1176.76f, 13.7f), (MapIcon) 14, default, MapIconType.Local);
            player.SetMapIcon(83, new Vector3(932.0f, -1353.0f, 14.0f), (MapIcon) 14, default, MapIconType.Local);
            player.SetMapIcon(84, new Vector3(1971.7f, -2036.6f, 13.5f), (MapIcon) 39, default, MapIconType.Local);
            player.SetMapIcon(85, new Vector3(2071.6f, -1779.9f, 13.5f), (MapIcon) 39, default, MapIconType.Local);
            player.SetMapIcon(86, new Vector3(2094.6f, 2119.0f, 10.8f), (MapIcon) 39, default, MapIconType.Local);
            player.SetMapIcon(87, new Vector3(-2490.5f, -40.1f, 39.3f), (MapIcon) 39, default, MapIconType.Local);
            player.SetMapIcon(88, new Vector3(1372.9f, -1278.8f, 12.5f), (MapIcon) 6, default, MapIconType.Local);
            player.SetMapIcon(89, new Vector3(2400.5f, -1978.4f, 13.5f), (MapIcon) 6, default, MapIconType.Local);
            player.SetMapIcon(90, new Vector3(-2626.6f, 209.4f, 4.9f), (MapIcon) 6, default, MapIconType.Local);
            player.SetMapIcon(91, new Vector3(2535.9f, 2083.5f, 10.8f), (MapIcon) 6, default, MapIconType.Local);
            player.SetMapIcon(92, new Vector3(2156.5f, 943.2f, 10.8f), (MapIcon) 6, default, MapIconType.Local);
            player.SetMapIcon(93, new Vector3(779.7f, 1874.3f, 4.9f), (MapIcon) 6, default, MapIconType.Local);
            player.SetMapIcon(94, new Vector3(-2092.7f, -2463.8f, 30.6f), (MapIcon) 6, default, MapIconType.Local);
            player.SetMapIcon(95, new Vector3(240.0f, -178.2f, 2.0f), (MapIcon) 6, default, MapIconType.Local);
            player.SetMapIcon(96, new Vector3(-1509.4f, 2611.8f, 58.5f), (MapIcon) 6, default, MapIconType.Local);
            player.SetMapIcon(97, new Vector3(-315.67f, 829.87f, 13.43f), (MapIcon) 6, default, MapIconType.Local);
            player.SetMapIcon(98, new Vector3(2332.9f, 63.6f, 31.0f), (MapIcon) 6, default, MapIconType.Local);
        }
    }
}