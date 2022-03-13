using System;
using GrandLarceny.Components;
using GrandLarceny.Data;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace GrandLarceny.Systems
{
    /// <summary>
    /// Represents a system which provides the class and city selection functionality for players.
    /// </summary>
    public class ClassSelectionSystem : ISystem
    {
        private TextDraw _txtClassSelHelper;
        private TextDraw _txtLasVenturas;
        private TextDraw _txtLosSantos;
        private TextDraw _txtSanFierro;

        [Event]
        public void OnGameModeInit(IServerService serverService, IWorldService worldService)
        {
            // Add all classes available in this game mode.
            serverService.AddPlayerClass(298, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(299, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(300, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(301, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(302, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(303, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(304, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(305, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(280, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(281, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(282, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(283, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(284, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(285, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(286, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(287, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(288, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(289, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(265, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(266, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(267, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(268, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(269, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(270, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(1, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(2, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(3, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(4, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(5, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(6, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(8, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(42, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(65, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(86, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(119, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(149, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(208, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(273, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(289, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(47, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(48, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(49, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(50, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(51, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(52, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(53, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(54, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(55, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(56, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(57, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(58, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(68, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(69, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(70, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(71, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(72, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(73, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(75, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(76, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(78, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(79, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(80, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(81, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(82, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(83, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(84, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(85, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(87, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(88, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(89, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(91, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(92, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(93, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(95, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(96, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(97, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(98, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);
            serverService.AddPlayerClass(99, new Vector3(1759.0189f, -1898.1260f, 13.5622f), 266.4503f);

            InitTextDraws(worldService);
        }

        [Event]
        public void OnPlayerConnect(Player player)
        {
            if (!player.IsNpc)
                player.AddComponent<CitySelectionComponent>();
        }

        [Event]
        public bool OnPlayerRequestClass(CitySelectionComponent citySelection, int classId)
        {
            var player = citySelection.GetComponent<Player>();

            if (player.State == PlayerState.Spectating)
                return false;

            player.ToggleSpectating(true);
            _txtClassSelHelper.Show(player);

            return false;
        }

        [Event]
        public void OnPlayerRequestClass(ClassSelectionComponent classSelection, int classId)
        {
            var player = classSelection.GetComponent<Player>();
            var citizen = classSelection.GetComponent<CitizenComponent>();

            SetClassSelectionPositionForCity(player, citizen.City);
        }

        [Event]
        public void OnPlayerUpdate(CitySelectionComponent citySelection)
        {
            var player = citySelection.GetComponent<Player>();

            // If the player has not yet selected a city, move to the first city.
            if (citySelection.SelectedCity == City.None)
            {
                SwitchToNextCity(citySelection, player);
                return;
            }

            // Only allow new selection every ~500 ms.
            if (DateTime.UtcNow - citySelection.LastSelection < TimeSpan.FromMilliseconds(500))
                return;

            player.GetKeys(out var keys, out _, out var leftRight);

            if (keys.HasFlag(Keys.Fire))
            {
                // Add a citizen component to define the spawn location of the player. 
                player.AddComponent<CitizenComponent>(citySelection.SelectedCity);

                // Add a class selection component to move the player to
                player.AddComponent<ClassSelectionComponent>();

                // End city selection for the player by removing the city selection component.
                citySelection.Destroy();

                // Hide textdraws used by the city selection.
                _txtClassSelHelper.Hide(player);
                _txtLosSantos.Hide(player);
                _txtSanFierro.Hide(player);
                _txtLasVenturas.Hide(player);

                // Disable spectating to allow the player to spawn in the world.
                player.ToggleSpectating(false);

                return;
            }

            // Use left and right arrow keys to switch between cities.
            if (leftRight > 0)
                SwitchToNextCity(citySelection, player);
            else if (leftRight < 0) SwitchToPreviousCity(citySelection, player);
        }

        /// <summary>
        /// Initializes the text draws used by this class selection system.
        /// </summary>
        private void InitTextDraws(IWorldService worldService)
        {
            void InitCityNameText(TextDraw txtInit)
            {
                txtInit.UseBox = false;
                txtInit.LetterSize = new Vector2(1.25f, 3.0f);
                txtInit.Font = TextDrawFont.Diploma;
                txtInit.Shadow = 0;
                txtInit.Outline = 1;
                txtInit.ForeColor = Color.FromInteger(0xEEEEEEFF, ColorFormat.RGBA);
                txtInit.BackColor = Color.Black;
            }

            _txtLosSantos = worldService.CreateTextDraw(new Vector2(10.0f, 380.0f), "Los Santos");
            _txtSanFierro = worldService.CreateTextDraw(new Vector2(10.0f, 380.0f), "San Fierro");
            _txtLasVenturas = worldService.CreateTextDraw(new Vector2(10.0f, 380.0f), "Las Venturas");

            InitCityNameText(_txtLosSantos);
            InitCityNameText(_txtSanFierro);
            InitCityNameText(_txtLasVenturas);

            _txtClassSelHelper = worldService.CreateTextDraw(new Vector2(10.0f, 415.0f),
                " Press ~b~~k~~GO_LEFT~ ~w~or ~b~~k~~GO_RIGHT~ ~w~to switch cities.~n~ Press ~r~~k~~PED_FIREWEAPON~ ~w~to select.");

            _txtClassSelHelper.UseBox = true;
            _txtClassSelHelper.BoxColor = Color.FromInteger(0x222222BB, ColorFormat.RGBA);
            _txtClassSelHelper.LetterSize = new Vector2(0.3, 1.0);
            _txtClassSelHelper.TextSize = new Vector2(400.0f, 40.0f);
            _txtClassSelHelper.Font = TextDrawFont.Slim;
            _txtClassSelHelper.Shadow = 0;
            _txtClassSelHelper.Outline = 1;
            _txtClassSelHelper.ForeColor = Color.White;
            _txtClassSelHelper.BackColor = Color.Black;
        }

        /// <summary>
        /// Switches the <paramref name="player" /> to the next city.
        /// </summary>
        private void SwitchToNextCity(CitySelectionComponent citySelection, Player player)
        {
            citySelection.SelectedCity = citySelection.SelectedCity == City.LasVenturas
                ? City.LosSantos
                : citySelection.SelectedCity + 1;

            player.PlaySound(1052);
            citySelection.LastSelection = DateTime.UtcNow;
            SetupSelectedCity(player, citySelection.SelectedCity);
        }

        /// <summary>
        /// Switches the <paramref name="player" /> to the previous city.
        /// </summary>
        private void SwitchToPreviousCity(CitySelectionComponent citySelection, Player player)
        {
            citySelection.SelectedCity = citySelection.SelectedCity == City.LosSantos
                ? City.LasVenturas
                : citySelection.SelectedCity - 1;

            player.PlaySound(1053);
            citySelection.LastSelection = DateTime.UtcNow;
            SetupSelectedCity(player, citySelection.SelectedCity);
        }

        /// <summary>
        /// Setup the city selection screen for the specified <paramref name="player" /> and <paramref name="city" />.
        /// </summary>
        /// <param name="player">The player for whom to setup the city selection screen.</param>
        /// <param name="city">The city for which to setup the selection screen.</param>
        private void SetupSelectedCity(Player player, City city)
        {
            switch (city)
            {
                case City.LosSantos:
                    player.Interior = 0;
                    player.CameraPosition = new Vector3(1630.6136f, -2286.0298f, 110.0f);
                    player.SetCameraLookAt(new Vector3(1887.6034f, -1682.1442f, 47.6167f));
                    _txtLosSantos.Show(player);
                    _txtSanFierro.Hide(player);
                    _txtLasVenturas.Hide(player);
                    break;
                case City.SanFierro:
                    player.Interior = 0;
                    player.CameraPosition = new Vector3(-1300.8754f, 68.0546f, 129.4823f);
                    player.SetCameraLookAt(new Vector3(-1817.9412f, 769.3878f, 132.6589f));
                    _txtLosSantos.Hide(player);
                    _txtSanFierro.Show(player);
                    _txtLasVenturas.Hide(player);
                    break;
                case City.LasVenturas:
                    player.Interior = 0;
                    player.CameraPosition = new Vector3(1310.6155f, 1675.9182f, 110.7390f);
                    player.SetCameraLookAt(new Vector3(2285.2944f, 1919.3756f, 68.2275f));
                    _txtLosSantos.Hide(player);
                    _txtSanFierro.Hide(player);
                    _txtLasVenturas.Show(player);
                    break;
            }
        }

        /// <summary>
        /// Moves the specified <paramref name="player" /> to the class selection location for the specified
        /// <paramref name="city" />.
        /// </summary>
        /// <param name="player">The player to move to the class selection position.</param>
        /// <param name="city">The city in which the class selection occurs.</param>
        private static void SetClassSelectionPositionForCity(Player player, City city)
        {
            switch (city)
            {
                case City.LosSantos:
                    player.Interior = 11;
                    player.Position = new Vector3(508.7362f, -87.4335f, 998.9609f);
                    player.Angle = 0;
                    player.CameraPosition = new Vector3(508.7362f, -83.4335f, 998.9609f);
                    player.SetCameraLookAt(new Vector3(508.7362f, -87.4335f, 998.9609f));
                    break;
                case City.SanFierro:
                    player.Interior = 3;
                    player.Position = new Vector3(-2673.8381f, 1399.7424f, 918.3516f);
                    player.Angle = 181;
                    player.CameraPosition = new Vector3(-2673.2776f, 1394.3859f, 918.3516f);
                    player.SetCameraLookAt(new Vector3(-2673.8381f, 1399.7424f, 918.3516f));
                    break;
                case City.LasVenturas:
                    player.Interior = 3;
                    player.Position = new Vector3(349.0453f, 193.2271f, 1014.1797f);
                    player.Angle = 286.25f;
                    player.CameraPosition = new Vector3(352.9164f, 194.5702f, 1014.1875f);
                    player.SetCameraLookAt(new Vector3(349.0453f, 193.2271f, 1014.1797f));
                    break;
            }
        }
    }
}