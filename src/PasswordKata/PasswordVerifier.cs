using System;
using System.Text.RegularExpressions;

namespace PasswordKata
{
	public class PasswordVerifier
	{
        private readonly string _password;
        public bool Ensure_8Char { get; set; }
        public bool Ensure_ArgumentNotNull { get; set; }
        public bool Ensure_Uppercase { get; set; }
        public bool Ensure_lowercase { get; set; }
        public bool Ensure_Number { get; set; }
        public PasswordVerifier(string password)
        {
            _password = password;
            Ensure_8Char = true;
            Ensure_ArgumentNotNull = true;
            Ensure_Uppercase = true;
            Ensure_lowercase = true;
            Ensure_Number = true;
        }

        public bool Verify()
        {
            if (Ensure_8Char == true)
            {
                Ensure.ArgumentNotNull(_password, "Password");
            }
            if (Ensure_ArgumentNotNull == true)
            {
                Ensure.ArgumentCondition(_password.Length > 8, "Field must be 8 charector", "Password");
            }
            if (Ensure_Uppercase == true)
            {
                Ensure.ArgumentCondition(Regex.IsMatch(_password, "[A-Z]"), "Password must contain at least 1 Uppercase letter", "Password");
            }
            if (Ensure_lowercase == true)
            {
                Ensure.ArgumentCondition(Regex.IsMatch(_password, "[a-z]"), "Password must contain at least 1 lowercase letter", "Password");
            }
            if (Ensure_Number == true)
            {
                Ensure.ArgumentCondition(Regex.IsMatch(_password, "[0-9]"), "Password should contain at least 1 number", "Password");
            }
            return true;
        }
        
	}
}

