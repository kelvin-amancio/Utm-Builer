using UtmBuiler.Core.Extensions;
using UtmBuiler.Core.ValueObjects;

namespace UtmBuiler.Core
{
    public class Utm
    {
        public Utm(Url url, Campaign campaign)
        {
            Url = url;
            Campaign = campaign;
        }
        public Url Url { get; }
        public Campaign Campaign { get; }

        public static implicit operator string(Utm utm) => utm.ToString();

        public override string ToString()
        {
            var segments = new List<string>();
            segments.AddIfNotNull("utm_source", Campaign.Source);
            segments.AddIfNotNull("utm_medium", Campaign.Medium);
            segments.AddIfNotNull("utm_campaign", Campaign.Name);
            segments.AddIfNotNull("utm_id", Campaign.Id ?? string.Empty);
            segments.AddIfNotNull("utm_term", Campaign.Term ?? string.Empty);
            segments.AddIfNotNull("utm_content", Campaign.Content ?? string.Empty);

            return string.Join("&", segments);
        }
    }
}
