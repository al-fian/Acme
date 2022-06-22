using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Acme.BusinessLayer
{
    public class Customer
    {
        public int CustomerId { get; private set; }

        private string? _firstName;
        public string? FirstName 
        { 
            get => _firstName; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("FirstName cannot be empty");

                _firstName = value;
            } 
        } 

        private string? _lastName;   
        public string? LastName 
        { 
            get => _lastName; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("LastName cannot be empty");
                
                _lastName = value;  
            }
        }

        public string FullName => $"{LastName}, {FirstName}";

        private string? _emailAddress;
        public string? EmailAddress 
        { 
            get => _emailAddress; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Email Address cannot be empty");

                if (!IsValidEmail(value))
                    throw new ArgumentException("Email Address is incorrect");

                _emailAddress = value;
            }
        }

        // copied pasted from the Microsoft docs
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

    }
}