using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using GrandLarceny.Data;
using SampSharp.Entities.SAMP;

namespace GrandLarceny.Services
{
    /// <inheritdoc />
    public class VehicleSpawnParserService : IVehicleSpawnParserService
    {
        /// <inheritdoc />
        public IEnumerable<VehicleSpawn> Parse(Stream stream)
        {
            if (stream == null) throw new ArgumentNullException(nameof(stream));

            // Use a stream reader to read text from the stream.
            using var reader = new StreamReader(stream);

            // Read lines until the end of the stream.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                if (line == null)
                    break;

                var endOfLine = line.IndexOf(';');

                // The line should contain and end of line marker ';'.
                if (endOfLine <= 0)
                    continue;

                // Split segments of the line delimited by a ','.
                var segments = line.Substring(0, endOfLine).Split(',');

                // The segments should contain all model, x, y, z, angle, color1 and color2.
                if (segments.Length != 7)
                    continue;

                // Parse all segments into their respective value type.
                if (
                    !int.TryParse(segments[0].Trim(), out var modelId) ||
                    !Enum.IsDefined(typeof(VehicleModelType), modelId) ||
                    !float.TryParse(segments[1].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out var x) ||
                    !float.TryParse(segments[2].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out var y) ||
                    !float.TryParse(segments[3].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out var z) ||
                    !float.TryParse(segments[4].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out var angle) ||
                    !int.TryParse(segments[5].Trim(), out var color1) ||
                    !int.TryParse(segments[6].Trim(), out var color2)
                )
                    continue;

                yield return new VehicleSpawn
                {
                    Model = (VehicleModelType) modelId,
                    Position = new Vector3(x, y, z),
                    Angle = angle,
                    Color1 = color1,
                    Color2 = color2
                };
            }
        }
    }
}