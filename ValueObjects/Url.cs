using System.Text.RegularExpressions;
using UtmBuiler.Core.ValueObjects.Exceptions;

namespace UtmBuiler.Core.ValueObjects
{
    public class Url : ValueObject
    {
        public Url(string address)
        {
            Address = address;
            InvalidUrlException.ThrowIfInvalidUrl(address);
        }
        /// <summary>
        /// Address of URL (Websiste Link)
        /// </summary>
        public string Address { get; }
    }
}
